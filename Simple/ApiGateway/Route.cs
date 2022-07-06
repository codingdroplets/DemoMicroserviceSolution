namespace Simple.ApiGateway;

public class Route
{
    public string RouteName { get; set; } = null!;
    public string Scheme { get; set; } = "https";
    public string Host { get; set; } = "localhost";
    public int Port { get; set; } = 5000;
}