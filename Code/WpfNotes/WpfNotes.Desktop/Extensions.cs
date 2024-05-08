namespace Microsoft.Extensions.Configuration;

/// <summary>
/// Extensions
/// </summary>
internal static class Extensions
{
    /// <summary>
    /// Register Services
    /// </summary>
    /// <param name="services">Service Collection</param>
    /// <returns>Service Collection</returns>
    public static IServiceCollection RegisterServices(this IServiceCollection services) =>
        services
        .AddServices()
        .AddRender()
        .AddTransient<Dialog>()
        .AddTransient<MainWindow>();
}
