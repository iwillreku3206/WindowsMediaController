namespace WindowsMediaController;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        var mainForm = new MainForm();
        var trayIcon = new TrayIcon(mainForm);
        
        Application.Run();
    }
}