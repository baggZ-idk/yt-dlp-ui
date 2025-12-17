using System.Diagnostics;

namespace yt_dlp_ui
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static async Task<string> RunCommand(string command)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };

            var outputBuilder = new System.Text.StringBuilder();
            var errorBuilder = new System.Text.StringBuilder();

            process.OutputDataReceived += (s, e) => { if (e.Data != null) outputBuilder.AppendLine(e.Data); };
            process.ErrorDataReceived += (s, e) => { if (e.Data != null) errorBuilder.AppendLine(e.Data); };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await process.WaitForExitAsync();

            if (errorBuilder.Length > 0)
                return "ERROR: " + errorBuilder.ToString();

            return outputBuilder.ToString();
        }
    }
}