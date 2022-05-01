using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zde
{
    public partial class zle : Form
    {
        bool defaultTheme = true;
        bool darkTheme = false;
        bool lightTheme = false;
        bool optionsClicked = false;
        public zle()
        {
            InitializeComponent();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            optionPanel.Visible = false;
            optionsTitle.Visible = false;
            darkMode.Visible = false;
            lightMode.Visible = false;
            defaultMode.Visible = false;
            optionTitlePanel.Visible = false;
            optionPanel.BringToFront();
            optionsTitle.BringToFront();
            darkMode.BringToFront();
            lightMode.BringToFront();
            defaultMode.BringToFront();
            optionTitlePanel.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void panelMouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        private void darkModeEnable(object sender, EventArgs e)
        {
            darkTheme = true;
            defaultTheme = false;
            lightTheme = false;
            if (darkTheme)
            {
                this.BackColor = Color.FromArgb(20, 20, 20);
                optionsPanel.BackColor = Color.FromArgb(24, 24, 24);
                titlePanel.BackColor = Color.FromArgb(24, 24, 24);
                btnMin.BackColor = Color.FromArgb(10, 10, 10);
                btnExit.BackColor = Color.FromArgb(10, 10, 10);
                btnRun.BackColor = Color.FromArgb(12, 12, 12);
                btnClear.BackColor = Color.FromArgb(12, 12, 12);
                btnSave.BackColor = Color.FromArgb(12, 12, 12);
                btnOpen.BackColor = Color.FromArgb(12, 12, 12);
                optionsPanelTwo.BackColor = Color.FromArgb(15, 15, 15);
                optionPanel.BackColor = Color.FromArgb(5, 5, 5);
                defaultMode.BackColor = Color.FromArgb(10, 10, 10);
                lightMode.BackColor = Color.FromArgb(10, 10, 10);
                darkMode.BackColor = Color.FromArgb(10, 10, 10);
                btnClose.BackColor = Color.FromArgb(6, 6, 6);
                btnGitHub.BackColor = Color.FromArgb(15, 15, 15);
                btnOptions.BackColor = Color.FromArgb(20, 20, 20);
                optionTitlePanel.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void lightModeEnable(object sender, EventArgs e)
        {
            lightTheme = true;
            darkTheme = false;
            defaultTheme = false;
            if (lightTheme)
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
                optionsPanel.BackColor = Color.FromArgb(200, 200, 200);
                titlePanel.BackColor = Color.FromArgb(200, 200, 200);
                btnMin.BackColor = Color.FromArgb(175, 175, 175);
                btnExit.BackColor = Color.FromArgb(175, 175, 175);
                btnRun.BackColor = Color.FromArgb(150, 150, 150);
                btnClear.BackColor = Color.FromArgb(150, 150, 150);
                btnSave.BackColor = Color.FromArgb(150, 150, 150);
                btnOpen.BackColor = Color.FromArgb(150, 150, 150);
                optionsPanelTwo.BackColor = Color.FromArgb(200, 200, 200);
                optionPanel.BackColor = Color.FromArgb(160, 160, 160);
                defaultMode.BackColor = Color.FromArgb(140, 140, 140);
                lightMode.BackColor = Color.FromArgb(140, 140, 140);
                darkMode.BackColor = Color.FromArgb(140, 140, 140);
                btnClose.BackColor = Color.FromArgb(130, 130, 130);
                btnGitHub.BackColor = Color.FromArgb(150, 150, 150);
                btnOptions.BackColor = Color.FromArgb(180, 180, 180);
                optionTitlePanel.BackColor = Color.FromArgb(100, 100, 100);
            }
        }

        private void defaultEnable(object sender, EventArgs e)
        {
            defaultTheme = true;
            lightTheme = false;
            darkTheme = false;
            if (defaultTheme)
            {
                this.BackColor = Color.FromArgb(37, 37, 37);
                titlePanel.BackColor = Color.FromArgb(27, 27, 27);
                optionsPanel.BackColor = Color.FromArgb(27, 27, 27);
                btnMin.BackColor = Color.FromArgb(30, 30, 30);
                btnExit.BackColor = Color.FromArgb(30, 30, 30);
                btnRun.BackColor = Color.FromArgb(50, 50, 50);
                btnClear.BackColor = Color.FromArgb(50, 50, 50);
                btnSave.BackColor = Color.FromArgb(50, 50, 50);
                btnOpen.BackColor = Color.FromArgb(50, 50, 50);
                optionsPanelTwo.BackColor = Color.FromArgb(27, 27, 27);
                optionPanel.BackColor = Color.FromArgb(20, 20, 20);
                defaultMode.BackColor = Color.FromArgb(50, 50, 50);
                lightMode.BackColor = Color.FromArgb(50, 50, 50);
                darkMode.BackColor = Color.FromArgb(50, 50, 50);
                btnClose.BackColor = Color.FromArgb(40, 40, 40);
                btnGitHub.BackColor = Color.FromArgb(50, 50, 50);
                btnOptions.BackColor = Color.FromArgb(50, 50, 50);
                optionTitlePanel.BackColor = Color.FromArgb(50, 50, 50);
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            optionsClicked = true;
            if (optionsClicked)
            {
                optionPanel.Visible = true;
                optionsTitle.Visible = true;
                darkMode.Visible = true;
                lightMode.Visible = true;
                defaultMode.Visible = true;
                optionTitlePanel.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            optionPanel.Visible = false;
            optionsTitle.Visible = false;
            darkMode.Visible = false;
            lightMode.Visible = false;
            defaultMode.Visible = false;
            optionTitlePanel.Visible = false;
        }

        private void mainLoad(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(string.Format("file:///{0}ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("about:blank");
            this.webBrowser1.Navigate(string.Format("file:///{0}ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();

            using (StreamWriter writer = new StreamWriter("file.lua"))
            {
                writer.Write(script);
            }

            System.Diagnostics.Process.Start("CMD.exe", "/C file.lua");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();

            try
            {
                var saveFileDialog1 = new SaveFileDialog
                {
                    InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Scripts",
                    Filter = string.Format("Lua Files (*.lua)|*.lua", "*.lua"),
                    RestoreDirectory = true,
                    ShowHelp = false,
                    CheckFileExists = false
                };
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) { File.WriteAllText(saveFileDialog1.FileName, script); }
            }
            catch
            {

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Scripts";
                openFileDialog.Filter = string.Format("Lua files (*.lua)|*.lua", "*.lua");
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var MainText = reader.ReadToEnd();
                        webBrowser1.Document.InvokeScript("SetText", new object[]
                        {
                            MainText
                        });
                    }
                }
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/Zexenux");
        }
    }
}
