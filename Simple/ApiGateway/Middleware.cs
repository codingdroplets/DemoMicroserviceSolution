using System;
using System.Text;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Options;

namespace Simple.ApiGateway;

public class Middleware : IMiddleware
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly List<Route> apiRoutes;

    public Middleware(IHttpClientFactory httpClientFactory, IOptionsMonitor<List<Route>> options)
    {
        _httpClientFactory = httpClientFactory;
        apiRoutes = options.CurrentValue;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var urlSegments = context.Request.Path.ToString().Split('/');
        var urlPath = string.Join('/', urlSegments[1..]);
        if (urlPath == "/") urlPath = string.Empty;
        var routeFound = apiRoutes.FirstOrDefault(a => urlPath.ToLower().StartsWith(a.RouteName));
        if (routeFound is not null)
        {
            context.Request.Scheme = routeFound.Scheme;
            context.Request.Host = new HostString(routeFound.Host, routeFound.Port);
            context.Request.Path = $"/{urlPath}";
            await ExecuteAsync(context);
        }
        else
        {
            await context.Response.WriteAsync("Welcome to API Gateway!");
        }
    }

    private async Task ExecuteAsync(HttpContext context)
    {
        try
        {
            var response = await SendRequest(context.Request);
            if (response is not null)
            {
                context.Response.StatusCode = (int)response.StatusCode;
                if (response.IsSuccessStatusCode)
                    await context.Response.WriteAsync(await response.Content.ReadAsStringAsync());
            }
        }
        catch (Exception ex)
        {                        
            context.Response.StatusCode = 500;
            System.Console.WriteLine(ex.Message);            
        }
    }

    private async Task<HttpResponseMessage> SendRequest(HttpRequest request)
    {
        using var client = _httpClientFactory.CreateClient();
        string requestContent;
        using (Stream receiveStream = request.Body)
        using (StreamReader readStream = new(receiveStream, Encoding.UTF8))
            requestContent = await readStream.ReadToEndAsync();

        using var newRequest = new HttpRequestMessage(new HttpMethod(request.Method), request.GetDisplayUrl());
        newRequest.Content = new StringContent(requestContent, Encoding.UTF8, request.ContentType);
        return await client.SendAsync(newRequest);
    }
}