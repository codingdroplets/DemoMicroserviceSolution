using Simple.ApiGateway;
var builder = WebApplication.CreateBuilder(args);
builder.AddApiGateway();
var app = builder.Build();
app.UseApiGateway();
app.Run();