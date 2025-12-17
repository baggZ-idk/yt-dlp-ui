using System.Diagnostics;

namespace yt_dlp_ui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Download = new Button();
            label = new Label();
            Console = new TextBox();
            URL = new TextBox();
            GitHub = new Button();
            SuspendLayout();
            // 
            // Download
            // 
            Download.BackColor = Color.FromArgb(64, 64, 64);
            Download.FlatAppearance.BorderSize = 0;
            Download.FlatStyle = FlatStyle.Flat;
            Download.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Download.ForeColor = Color.White;
            Download.Location = new Point(694, 70);
            Download.Name = "Download";
            Download.Size = new Size(94, 29);
            Download.TabIndex = 0;
            Download.Text = "Download";
            Download.UseVisualStyleBackColor = false;
            Download.Click += Download_ClickAsync;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(32, 32, 32);
            label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(302, 9);
            label.Name = "label";
            label.Size = new Size(187, 54);
            label.TabIndex = 1;
            label.Text = "yt-dlp-ui";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Console
            // 
            Console.BackColor = Color.Black;
            Console.BorderStyle = BorderStyle.None;
            Console.Font = new Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Console.ForeColor = Color.White;
            Console.Location = new Point(12, 108);
            Console.Multiline = true;
            Console.Name = "Console";
            Console.ReadOnly = true;
            Console.ScrollBars = ScrollBars.Vertical;
            Console.Size = new Size(776, 184);
            Console.TabIndex = 2;
            // 
            // URL
            // 
            URL.BackColor = Color.FromArgb(64, 64, 64);
            URL.BorderStyle = BorderStyle.None;
            URL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            URL.ForeColor = Color.White;
            URL.Location = new Point(12, 70);
            URL.Name = "URL";
            URL.Size = new Size(676, 27);
            URL.TabIndex = 3;
            // 
            // GitHub
            // 
            GitHub.BackColor = Color.FromArgb(64, 64, 64);
            GitHub.FlatAppearance.BorderSize = 0;
            GitHub.FlatStyle = FlatStyle.Flat;
            GitHub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GitHub.ForeColor = Color.White;
            GitHub.Location = new Point(12, 12);
            GitHub.Name = "GitHub";
            GitHub.Size = new Size(107, 50);
            GitHub.TabIndex = 4;
            GitHub.Text = "GitHub";
            GitHub.UseVisualStyleBackColor = false;
            GitHub.Click += GitHub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(800, 304);
            Controls.Add(GitHub);
            Controls.Add(URL);
            Controls.Add(Console);
            Controls.Add(label);
            Controls.Add(Download);
            Name = "Form1";
            Text = "yt-dlp-ui";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Download;
        private Label label;
        private TextBox Console;
        private TextBox URL;
        private Button GitHub;
    }
}
