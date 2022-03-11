﻿using CitizenFXRemapper.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CitizenFXRemapper
{
    public partial class MainForm : Form
    {

        private readonly string CFGFileLocation = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg";
        private readonly string MainBackupDirectory = ".\\CFGS\\";
        private readonly string MainBackupLocaton = ".\\CFGS\\BackupConfig.cfg";


        public MainForm()
        {
            InitializeComponent();
            CloseButton.Click += (s, e) => { Application.Exit(); };
            MinimizeButton.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
            customTabControl1.SelectedIndexChanged += (s, e) =>
            {
                BottomToolStrip.Visible = customTabControl1.SelectedIndex == 0;
                BottomToolStrip.BringToFront();
            };
            FormHeader.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Borderless.ReleaseCapture();
                    Borderless.SendMessage(Handle, Borderless.WM_NCLBUTTONDOWN, Borderless.HT_CAPTION, 0);
                }
            };
            //MainForm Events
            FormTitle.Text = $"{Application.ProductName} by {Application.CompanyName}";
            this.Load += (s, e) =>
            {
                Directory.CreateDirectory(MainBackupDirectory);
                if (!File.Exists(MainBackupLocaton)) File.Copy(CFGFileLocation, $"{MainBackupLocaton}");
                Confighandler.ReadConfig(Filename: CFGFileLocation, RichTextBox: richTextBox1,KeybindList);
                LoadedConfig.Items.Add(CFGFileLocation);
                foreach (string File in Directory.GetFiles(MainBackupDirectory, "*.cfg"))
                {
                    LoadedConfig.Items.Add(File);
                }

                foreach (var keyname in Enum.GetValues(typeof(Keys)).Cast<System.Windows.Forms.Keys>())
                {
                    keylist.Items.Add(keyname.ToString());
                }
            };

            ActionTextbox.TextChanged += (s, e) =>
            {
                CheckForColorTexts();
            };

            LoadedConfig.SelectedIndexChanged += (s, e) =>
            {
                Confighandler.ReadConfig(Filename: LoadedConfig.Text, RichTextBox: richTextBox1, KeybindList);
            };
            iconBox.MouseUp += (s, e) =>
            {
                if (e.Button != MouseButtons.Left) return;
                if (MessageBox.Show($"This opens up the Github page for {Application.ProductName}. Do you want to continue?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start("https://github.com/Darahz/CitizenFXRemapper");
                }
            };

            KeybindList.SelectedIndexChanged += (s, e) => {
                KeybindBox.Visible = KeybindList.SelectedItems.Count != 0;
                KeybindBox.BringToFront();
                BottomToolStrip.Visible = KeybindList.SelectedItems.Count == 0;
            };

        }

        private void CheckForColorTexts()
        {
            PreviewRichtextbox.Text = ActionTextbox.Text;
            MatchCollection matches = Regex.Matches(ActionTextbox.Text, "~[a-zA-Z]~");
            foreach (Match match in matches)
            {
                switch (match.Value)
                {
                    case "~r~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Red;

                        break;
                    case "~g~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Green;

                        break;
                    case "~b~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Blue;
                        break;
                    case "~y~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Gold;
                        break;
                    case "~p~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Purple;

                        break;
                    case "~c~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Gray;
                        break;
                    case "~u~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Black;
                        break;
                    case "~o~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.Orange;
                        break;
                    case "~w~":
                        PreviewRichtextbox.Select(match.Index, PreviewRichtextbox.TextLength);
                        PreviewRichtextbox.SelectionColor = Color.White;
                        break;

                    default:
                        break;
                }
                
            }

        }
    }
}