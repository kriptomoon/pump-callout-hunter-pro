using Microsoft.Web.WebView2.WinForms;

namespace PumpCalloutHunterPRO;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}

public sealed class MainForm : Form
{
    private readonly WebView2 browser = new() { Dock = DockStyle.Fill };

    public MainForm()
    {
        Text = "PUMP CALL OUT HUNTER PRO";
        Width = 1440;
        Height = 920;
        MinimumSize = new Size(980, 680);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(9, 13, 22);
        Controls.Add(browser);
        Shown += async (_, _) =>
        {
            try
            {
                await browser.EnsureCoreWebView2Async();
                browser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
                browser.CoreWebView2.Settings.IsStatusBarEnabled = false;
                var page = Path.Combine(AppContext.BaseDirectory, "src", "index.html");
                browser.Source = new Uri(page);
            }
            catch (Exception ex)
            {
                MessageBox.Show("WebView2 se nije mogao pokrenuti. Provjerite je li Microsoft Edge WebView2 Runtime instaliran.\n\n" + ex.Message,
                    "PUMP CALL OUT HUNTER PRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        };
    }
}
