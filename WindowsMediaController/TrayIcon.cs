namespace WindowsMediaController;

using System.Windows.Forms;

public class TrayIcon
{
    private readonly NotifyIcon _notifyIcon;

    public TrayIcon(Form mainForm)
    {
        _notifyIcon = new NotifyIcon();
        _notifyIcon.Icon = mainForm.Icon;
        _notifyIcon.Text = "Windows Media Controller";
        _notifyIcon.Visible = true;

        var exitButton = new ToolStripMenuItem("E&xit", null, (_, _) => { Application.Exit(); });
        _notifyIcon.ContextMenuStrip = new ContextMenuStrip();
        _notifyIcon.ContextMenuStrip.Items.Add(exitButton);

        _notifyIcon.MouseClick += async (_, e) =>
        {
            if (e.Button == MouseButtons.Left)
            {
                await MediaHandler.ToggleMediaPlayback();
            }
        };
        
        _notifyIcon.DoubleClick += (_, _) =>
        {
            if (Screen.PrimaryScreen != null)
            {
                var x = Screen.PrimaryScreen.WorkingArea.Right - mainForm.Size.Width;
                var y = Screen.PrimaryScreen.WorkingArea.Bottom - mainForm.Size.Height;
                mainForm.Location = new Point(x, y);
            }
            mainForm.Visible = !mainForm.Visible;
        };
    }
}