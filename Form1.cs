
using System.Diagnostics;
using System.Security.Policy;

namespace yt_dlp_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Download_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(URL.Text)) return;

            Console.Text += await Program.RunCommand($"yt-dlp {URL.Text}") + "\n";
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = ProgramInfo.github,
                UseShellExecute = true
            });
        }
    }
}
