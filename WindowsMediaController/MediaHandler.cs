using Windows.Media.Control;

namespace WindowsMediaController;

public class MediaHandler
{
    public static async Task<GlobalSystemMediaTransportControlsSessionManager> GetSessionManager()
    {
        return await GlobalSystemMediaTransportControlsSessionManager.RequestAsync();
    }
    private static async Task<GlobalSystemMediaTransportControlsSession> GetCurrentSession()
    {
        var sessionManager = await GetSessionManager();
        return sessionManager.GetCurrentSession();
    }

    public static async Task<GlobalSystemMediaTransportControlsSessionMediaProperties> GetCurrentMedia()
    {
        return await (await GetCurrentSession()).TryGetMediaPropertiesAsync();
    }

    public static async Task<bool> ToggleMediaPlayback()
    {
        var session = await GetCurrentSession();
        return await session.TryTogglePlayPauseAsync();
    }

    public static async Task<bool> PreviousTrack()
    {
        var session = await GetCurrentSession();
        return await session.TrySkipPreviousAsync();
    }
    
    public static async Task<bool> NextTrack()
    {
        var session = await GetCurrentSession();
        return await session.TrySkipNextAsync();
    }
}