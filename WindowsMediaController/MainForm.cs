using Windows.Media.Control;

namespace WindowsMediaController;

using Windows.Media;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        InitializeAsync();
    }

    private void UpdateMediaInformation(GlobalSystemMediaTransportControlsSessionMediaProperties properties)
    {
        labelTitle.Text = properties.Title;
        labelSubtitle.Text = (properties.Artist.Length != 0 ? properties.Artist : properties.AlbumArtist) 
                             + (properties.AlbumTitle.Length != 0 ? " - " + properties.AlbumTitle : "");
    }

    private async void InitializeAsync()
    {
        try
        {
            var sessionManager = await MediaHandler.GetSessionManager();
            var properties = await MediaHandler.GetCurrentMedia();
            var currentSession = sessionManager.GetCurrentSession();
            
            UpdateMediaInformation(properties);
            currentSession.MediaPropertiesChanged += async (_, _) =>
            {
                UpdateMediaInformation(await currentSession.TryGetMediaPropertiesAsync());
            };
            sessionManager.CurrentSessionChanged += async (_, _) =>
            {
                var session = sessionManager.GetCurrentSession();
                UpdateMediaInformation(await session.TryGetMediaPropertiesAsync());
                session.MediaPropertiesChanged += async (_, _) =>
                {
                    UpdateMediaInformation(await session.TryGetMediaPropertiesAsync());
                };
            };
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }

    private async void buttonPlayPause_Click(object sender, EventArgs e)
    {
        try
        {
            await MediaHandler.ToggleMediaPlayback();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }

    private async void buttonPrevious_Click(object sender, EventArgs e)
    {
        try
        {
            await MediaHandler.PreviousTrack();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }

    private async void buttonNext_Click(object sender, EventArgs e)
    {
        try
        {
            await MediaHandler.NextTrack();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }
}