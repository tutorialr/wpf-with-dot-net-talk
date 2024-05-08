namespace WpfNotes.Library;

/// <summary>
/// Extensions
/// </summary>
public static class Extensions
{
    private const string app_settings = "appsettings.json";

    /// <summary>
    /// Add Services
    /// </summary>
    /// <param name="services">Services</param>
    /// <param name="root">Configuration Root</param>
    /// <param name="config">Config</param>
    /// <returns>Service Collection</returns>
    private static IServiceCollection AddServices(
        this IServiceCollection services, IConfigurationRoot root, NotesConfig? config = null) =>
        services.AddSingleton<INotesConfig>(config ?? root.GetSection(nameof(NotesConfig)).Get<NotesConfig>() ?? new())
        .AddSingleton<INotesProvider, NotesProvider>()
        .AddSingleton<IApplicationProvider, ApplicationProvider>();

    /// <summary>
    /// Add Services
    /// </summary>
    /// <param name="services">Service Collection</param>
    /// <param name="config">Config</param>
    /// <returns>Service Collection</returns>
    public static IServiceCollection AddServices(
        this IServiceCollection services, NotesConfig? config = null) =>
        services.AddServices(new ConfigurationBuilder()
        .AddJsonFile(app_settings, true, true)
        .Build(),
        config);
}