using CitizenFXRemapper.Classes;
using System;
using System.Diagnostics;
using System.IO;
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
            this.Load += (s, e) => {
                Directory.CreateDirectory(MainBackupDirectory);
                if (!File.Exists(MainBackupLocaton)) File.Copy(CFGFileLocation, $"{MainBackupLocaton}");
                Confighandler.ReadConfig(Filename: CFGFileLocation, RichTextBox:richTextBox1) ;
                LoadedConfig.Items.Add(CFGFileLocation);
                foreach (string File in Directory.GetFiles(MainBackupDirectory,"*.cfg"))
                {
                    LoadedConfig.Items.Add(File);
                }
            };

            LoadedConfig.SelectedIndexChanged += (s, e) => {
                Confighandler.ReadConfig(Filename: LoadedConfig.Text, RichTextBox: richTextBox1);
            };
            iconBox.MouseUp += (s, e) =>
            {
                if (e.Button != MouseButtons.Left) return;
                if(MessageBox.Show($"This opens up the Github page for {Application.ProductName}. Do you want to continue?","Continue?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start("https://github.com/Darahz/CitizenFXRemapper");
                }
            };
        }
    }
}
