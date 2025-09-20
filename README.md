# Windows Media Controller

A lightweight Windows system tray application that provides universal media controls for any media playing on your Windows system.

## Features

- **Universal Media Control**: Control media playback from any application (Spotify, YouTube, VLC, etc.) that uses Windows' Global System Media Transport Controls
- **System Tray Integration**: Minimalistic tray icon for quick access without cluttering your desktop
- **Quick Controls**: 
  - Left-click tray icon to play/pause
  - Double-click tray icon to show/hide the control window
- **Media Information Display**: Shows current track title, artist, and album information
- **Control Buttons**: Play/Pause, Previous Track, Next Track functionality
- **Lightweight**: Minimal resource usage with clean, simple interface

## Requirements

- **Operating System**: Windows 10 version 1809 (build 17763) or later
- **Runtime**: .NET 9.0 Desktop Runtime
- **Architecture**: x64 or x86 (Any CPU)

## Installation

### Option 1: Download Pre-built Release
1. Go to the [Releases](../../releases) page
2. Download the latest release
3. Extract and run `WindowsMediaController.exe`

### Option 2: Build from Source
1. **Prerequisites**:
   - [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) (Required - project targets .NET 9.0)
   - Visual Studio 2022 (17.8 or later) or JetBrains Rider (optional, for development)

2. **Clone the repository**:
   ```bash
   git clone https://github.com/iwillreku3206/WindowsMediaController.git
   cd WindowsMediaController
   ```

3. **Build the application**:
   ```bash
   dotnet build --configuration Release
   ```

4. **Run the application**:
   ```bash
   dotnet run --project WindowsMediaController
   ```

> **Note**: This project specifically targets .NET 9.0. Make sure you have the .NET 9.0 SDK installed, as older versions will not work.

## Usage

1. **Start the Application**: Run `WindowsMediaController.exe`
2. **System Tray**: The application will appear as an icon in your system tray
3. **Media Control**:
   - **Left-click** the tray icon to toggle play/pause
   - **Double-click** the tray icon to show/hide the media information window
   - **Right-click** the tray icon to access the context menu (Exit)
4. **Control Window**: When visible, the window shows:
   - Current track title
   - Artist and album information
   - Play/Pause, Previous, and Next buttons
5. **Exit**: Right-click the tray icon and select "Exit" to close the application

## How It Works

This application leverages Windows' built-in [Global System Media Transport Controls (GSMTC)](https://docs.microsoft.com/en-us/windows/uwp/audio-video-camera/system-media-transport-controls) API to:

- Detect the currently active media session
- Retrieve media metadata (title, artist, album)
- Send media control commands (play, pause, next, previous)
- Monitor media property changes in real-time

The app works with any media application that properly implements Windows media controls, including:
- Spotify
- YouTube (in browsers)
- VLC Media Player
- Windows Media Player
- Groove Music
- And many more!

## Development

### Project Structure
```
WindowsMediaController/
├── WindowsMediaController/
│   ├── Program.cs              # Application entry point
│   ├── MainForm.cs            # Main control window
│   ├── MainForm.Designer.cs   # UI designer file
│   ├── TrayIcon.cs            # System tray functionality
│   ├── MediaHandler.cs        # Media control logic
│   └── WindowsMediaController.csproj
├── WindowsMediaController.sln
└── README.md
```

### Key Technologies
- **.NET 9.0**: Modern .NET framework
- **Windows Forms**: UI framework
- **Windows Runtime (WinRT)**: For accessing Windows APIs
- **Global System Media Transport Controls**: Windows media integration

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

### Development Setup
1. Clone the repository
2. Open `WindowsMediaController.sln` in Visual Studio 2022 or your preferred IDE
3. Build and run the project

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE.txt](LICENSE.txt) file for details.

## Troubleshooting

### Common Issues

**Application doesn't detect media:**
- Ensure your media application supports Windows media controls
- Try restarting both the media application and Windows Media Controller

**Tray icon not appearing:**
- Check if the application is running in Task Manager
- Ensure system tray icons are enabled in Windows settings

**Build errors:**
- Verify you have .NET 9.0 SDK installed
- Check that you're using Windows 10 version 1809 or later

### System Requirements Details
- **Minimum Windows Version**: Windows 10 build 17763 (October 2018 Update)
- **Memory**: ~10-20 MB RAM usage
- **Disk**: <5 MB installation size
