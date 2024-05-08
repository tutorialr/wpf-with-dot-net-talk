namespace WpfNotes.Desktop;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="application">Application</param>
    /// <param name="services">Services</param>
    /// <param name="dialog">Dialog</param>
    public MainWindow(IApplicationProvider application, IServiceProvider services, Dialog dialog)
    {
        InitializeComponent();
        Resources.Add(nameof(services), services);
        Display.DataContext = application.Content;
        application.Confirm = dialog.DeleteAsync;
        application.Upsert = dialog.UpsertAsync;
    }
}