using CitizenFXRemapper.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace CitizenFXRemapper
{
    public partial class MainForm : Form
    {

        private readonly string CFGFileLocation = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg";
        private readonly string MainBackupDirectory = ".\\CFGS\\";
        private readonly string MainBackupLocaton = ".\\CFGS\\BackupConfig.cfg";
        private List<string> configWithoutBindings = new List<string>();

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
                if (!System.IO.File.Exists(MainBackupLocaton)) System.IO.File.Copy(CFGFileLocation, $"{MainBackupLocaton}");
                Confighandler.ReadConfig(Filename: CFGFileLocation, RichTextBox: rawconfig,KeybindList);
                LoadedConfig.Items.Add(CFGFileLocation);

                List<string> FullConfig = File.ReadAllLines(CFGFileLocation).ToList();
                List<string> Userbinds = FullConfig.Where(x => x.StartsWith("bind")).ToList();
                configWithoutBindings = FullConfig.Except(Userbinds).ToList();
                configWithoutBindings = configWithoutBindings.Skip(2).ToList();

                foreach (string File in Directory.GetFiles(MainBackupDirectory, "*.cfg"))
                {
                    LoadedConfig.Items.Add(File);
                }

                foreach (var keyname in Enum.GetValues(typeof(Keys)).Cast<System.Windows.Forms.Keys>())
                {
                    keylist.Items.Add(keyname.ToString());
                }

                for (int i = 0; i < keylist.Items.Count; i++)
                {
                    string value = keylist.GetItemText(keylist.Items[i]);
                    if (Regex.Match(value, "D[0-9]").Success)
                    {
                        keylist.Items[keylist.FindStringExact(value)] = value.Replace("D", string.Empty);
                    }
                }
            };

            ActionTextbox.TextChanged += (s, e) =>
            {
                CheckForColorTexts();
            };

            LoadedConfig.SelectedIndexChanged += (s, e) =>
            {
                Confighandler.ReadConfig(Filename: LoadedConfig.Text, RichTextBox: rawconfig, KeybindList);
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
                if (KeybindList.SelectedItems.Count == 0)
                {
                    keylist.Text = string.Empty;
                    ActionTextbox.Text = string.Empty;
                    return;
                };
                
                keylist.SelectedIndex = keylist.FindString(KeybindList.SelectedItems[0].SubItems[2].Text);
                
                ActionTextbox.Text = KeybindList.SelectedItems[0].SubItems[3].Text;
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

        private void InsertColorREDToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~r~");

        private void insertColorBLUEToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~b~");

        private void insertColorGREENToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~g~");

        private void insertColorYELLOWToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~y~");

        private void insertColorPURPULEToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~p~");

        private void insertColorORANGEToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~o~");

        private void insertColorGREYToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~c~");

        private void insertColorWHITEToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~e~");

        private void insertStyleBOLDToolStripMenuItem_Click(object sender, EventArgs e) => InsertString("~H~");

        private void InsertString(string insert)
        {
            int selection = ActionTextbox.SelectionStart;
            ActionTextbox.Text = ActionTextbox.Text.Insert(selection, insert);
            ActionTextbox.SelectionStart = selection + 3;
        }


        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lwi = new ListViewItem();
            lwi.Text = "bind";
            lwi.SubItems.Add("KEYBOARD");
            lwi.SubItems.Add("0");
            lwi.SubItems.Add(string.Empty);
            KeybindList.Items.Add(lwi);
            KeybindList.Items[KeybindList.Items.Count - 1].Focused = true;
            KeybindList.Items[KeybindList.Items.Count - 1].Selected = true;
        }

        private void addItemAboneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KeybindList.SelectedItems.Count == 0) return;

            ListViewItem lwi = new ListViewItem();
            lwi.Text = "bind";
            lwi.SubItems.Add("KEYBOARD");
            lwi.SubItems.Add("0");
            lwi.SubItems.Add(string.Empty);

            KeybindList.Items.Insert(KeybindList.SelectedItems[0].Index, lwi);
            KeybindList.Items[KeybindList.SelectedItems[0].Index - 1].Focused = true;
            KeybindList.Items[KeybindList.SelectedItems[0].Index - 1].Selected = true;
        }

        private void addItemBelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lwi = new ListViewItem();
            lwi.Text = "bind";
            lwi.SubItems.Add("KEYBOARD");
            lwi.SubItems.Add("0");
            lwi.SubItems.Add(string.Empty);

            KeybindList.Items.Insert(KeybindList.SelectedItems[0].Index + 1, lwi);
            KeybindList.Items[KeybindList.SelectedItems[0].Index + 1].Focused = true;
            KeybindList.Items[KeybindList.SelectedItems[0].Index + 1].Selected = true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KeybindList.SelectedItems.Count == 0) return;
            if (MessageBox.Show("Are you sure you want to remove this?","You sure about this?",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                KeybindList.SelectedItems[0].Remove();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(MainBackupDirectory);
            if (!System.IO.File.Exists(MainBackupLocaton)) System.IO.File.Copy(CFGFileLocation, $"{MainBackupLocaton}");

            //Classes.Filehelper.GetSha256(string:Filename);

        }

        private void customTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SidePanel.Visible = customTabControl1.SelectedIndex == 0;
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            List<string> configToSave = new List<string>
            {
                "// generated by CitizenFX",
                "unbindall"
            };

            for (int i = 0; i < KeybindList.Items.Count; i++)
            {
                StringBuilder config = new StringBuilder();
                for (int j = 0; j < KeybindList.Items[i].SubItems.Count; j++)
                {
                    config.Append($"{KeybindList.Items[i].SubItems[j].Text} ");
                }
                configToSave.Add(config.ToString().TrimEnd());
            }
            configWithoutBindings.ForEach(x => {
                configToSave.Add(x);
            });
            string rndname = $"C:\\temp\\{Path.GetRandomFileName()}";
            File.WriteAllLines(rndname, configToSave);
            string tmpsha = Filehelper.GetSha256(rndname);
            string cursha = Filehelper.GetSha256(CFGFileLocation);
            File.Delete(rndname);

            if (tmpsha != cursha)
            {
                string backupName = $"{MainBackupDirectory}\\{DateTime.Now.ToString("MM-dd-yyyy hh.mm")}-Backup.cfg";
                File.Copy(CFGFileLocation, backupName);
                File.WriteAllLines(CFGFileLocation, configToSave);
                MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadedConfig.Items.Add($"{MainBackupLocaton}\\{DateTime.Now.ToShortTimeString()}-Backup.cfg");
            }
            else
            {
                MessageBox.Show("No changes made. Old config kept", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ActionTextbox_TextChanged(object sender, EventArgs e)
        {
            if (KeybindList.SelectedItems.Count == 0) return;
            KeybindList.SelectedItems[0].SubItems[3].Text = ActionTextbox.Text;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Cfg files (.cfg)|*.cfg";
                sfd.InitialDirectory = MainBackupDirectory;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    List<string> configToSave = new List<string>
                    {
                        "// generated by CitizenFX",
                        "unbindall"
                    };

                    for (int i = 0; i < KeybindList.Items.Count; i++)
                    {
                        StringBuilder config = new StringBuilder();
                        for (int j = 0; j < KeybindList.Items[i].SubItems.Count; j++)
                        {
                            config.Append($"{KeybindList.Items[i].SubItems[j].Text} ");
                        }
                        configToSave.Add(config.ToString().TrimEnd());
                    }
                    configWithoutBindings.ForEach(x => {
                        configToSave.Add(x);
                    });
                    string rndname = $"C:\\temp\\{Path.GetRandomFileName()}";
                    File.WriteAllLines(rndname, configToSave);
                    string tmpsha = Filehelper.GetSha256(rndname);
                    string cursha = Filehelper.GetSha256(CFGFileLocation);
                    File.Delete(rndname);

                    if (tmpsha != cursha)
                    {
                        string backupName = $"{MainBackupDirectory}\\{DateTime.Now.ToString("MM-dd-yyyy")}-Backup.cfg";
                        File.Copy(CFGFileLocation, backupName,true);
                        File.WriteAllLines(sfd.FileName, configToSave);
                        MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadedConfig.Items.Add($"{MainBackupLocaton}\\{DateTime.Now.ToShortTimeString()}-Backup.cfg");
                    }
                    else
                    {
                        MessageBox.Show("No changes made. Old config kept", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    }
}