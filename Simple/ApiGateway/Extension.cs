namespace Simple.ApiGateway;

public static class Extension
{
    public static void AddApiGateway(this WebApplicationBuilder builder)
    {
        var result = builder.Services.FirstOrDefault(a => a.ServiceType == typeof(IHttpClientFactory));
        if (result is null) builder.Services.AddHttpClient();

        builder.Services.Configure<List<Route>>(builder.Configuration.GetSection("SimpleApiGatewayRoute"));
        builder.Services.AddSingleton<Middleware>();
    }

    public static void UseApiGateway(this WebApplication app)
    {
        app.UseMiddleware<Middleware>();
    }
}