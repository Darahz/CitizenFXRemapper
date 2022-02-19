﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenFXRemapper
{
    public partial class Form1 : Form
    {



        private List<Userbind> keybinds = new List<Userbind>();
        public List<string> FullConfig = new List<string>();
        public List<string> Userbinds = new List<string>();
        public List<string> FullWithoutBinds = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            typeof(Control).GetProperty("DoubleBuffered",System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(listView1, true, null);
            listView1.AutoArrange = false;
            this.Load += (o, e) =>
            {
                LoadConfig(string.Empty);
            };

            button1.Click += (s, e) => {
                if (File.Exists(".\\configBackup.cfg")) File.Delete(".\\configBackup.cfg");
                File.Copy($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg", ".\\configBackup.cfg");

            };

            button2.Click += (s, e) =>
            {
                SaveConfig(string.Empty);
            };
            
        }

        private void SaveConfig(string filename)
        {
            if (filename == string.Empty) filename = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg";
            StringBuilder sb = new StringBuilder();
            sb.Append($"// generated by CitizenFX - Updated by CitizenFXRemapper{Environment.NewLine}");
            sb.Append($"// unbindall{Environment.NewLine}");

            foreach (var item in FullWithoutBinds)
            {
                sb.Append($"{item}{Environment.NewLine}");
            }

            keybinds.Clear();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sb.Append($"{listView1.Items[i].SubItems[0].Text} {listView1.Items[i].SubItems[1].Text} {listView1.Items[i].SubItems[2].Text} {listView1.Items[i].SubItems[3].Text}{Environment.NewLine}");
            }

            if (!File.Exists(".\\configBackup.cfg"))
            {
                if (MessageBox.Show("There is no backup created yet. Do you want to create one now?", "uh oh!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Copy($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg", ".\\configBackup.cfg");
                }
            }

            File.WriteAllText(filename, sb.ToString());
            MessageBox.Show("Done");
        }

        private void LoadConfig(string filename)
        {
            listView1.Items.Clear();
            if (filename == string.Empty) filename = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg";
            this.Text = $"{Application.ProductName}";
            FullConfig = File.ReadAllLines(filename).ToList();
            Userbinds = FullConfig.Where(x => x.StartsWith("bind")).ToList();
            FullWithoutBinds = FullConfig.Except(Userbinds).ToList();

            for (int i = 0; i < Userbinds.Count; i++)
            {
                string[] raw = Userbinds[i].Split(' ');
                string action = raw[0];
                string inputMethod = raw[1];
                string key = raw[2];
                string result = string.Join(" ", raw.Skip(3));
                keybinds.Add(new Userbind(action, inputMethod, key, result));

                ListViewItem lwi = new ListViewItem();
                lwi.Text = action;
                lwi.SubItems.Add(inputMethod);
                lwi.SubItems.Add(key);
                lwi.SubItems.Add(result);
                listView1.Items.Add(lwi);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void addItemBelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            NewItemDialog newItemDialog = new NewItemDialog(key: string.Empty,characterAction: string.Empty, EditItem:false);
            newItemDialog.StartPosition = FormStartPosition.CenterParent;
            newItemDialog.ShowDialog();
            var result = newItemDialog.returnResult();
            if (result.Text == "None") return;

            ListViewItem lwi = new ListViewItem();
            lwi.Text = "bind";
            lwi.SubItems.Add("KEYBOARD");
            lwi.SubItems.Add(result.Text);
            lwi.SubItems.Add(result.SubItems[1].Text);
            listView1.Items.Insert(listView1.SelectedItems[0].Index, lwi);

        }
        private void addItemAboneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            NewItemDialog newItemDialog = new NewItemDialog(key: string.Empty, characterAction: string.Empty, EditItem: false);
            newItemDialog.StartPosition = FormStartPosition.CenterParent;
            newItemDialog.ShowDialog();
            var result = newItemDialog.returnResult();
            if (result.Text == "None") return;

            ListViewItem lwi = new ListViewItem();
            lwi.Text = "bind";
            lwi.SubItems.Add("KEYBOARD");
            lwi.SubItems.Add(result.Text);
            lwi.SubItems.Add(result.SubItems[1].Text);
            listView1.Items.Insert(listView1.SelectedItems[0].Index, lwi);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            if(MessageBox.Show("Are you sure about this?","oh no", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            NewItemDialog newItemDialog = new NewItemDialog(key: listView1.SelectedItems[0].SubItems[2].Text,characterAction: listView1.SelectedItems[0].SubItems[3].Text, EditItem: true);
            newItemDialog.StartPosition = FormStartPosition.CenterParent;
            newItemDialog.ShowDialog();
            var result = newItemDialog.returnResult();
            if (newItemDialog.isEdited)
            {
                listView1.SelectedItems[0].SubItems[2].Text = result.Text;
                listView1.SelectedItems[0].SubItems[3].Text = result.SubItems[1].Text;
            }
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            NewItemDialog newItemDialog = new NewItemDialog(key: listView1.SelectedItems[0].SubItems[2].Text, characterAction: listView1.SelectedItems[0].SubItems[3].Text, EditItem: true);
            newItemDialog.StartPosition = FormStartPosition.CenterParent;
            newItemDialog.ShowDialog();
            var result = newItemDialog.returnResult();
            if (newItemDialog.isEdited)
            {
                listView1.SelectedItems[0].SubItems[2].Text = result.Text;
                listView1.SelectedItems[0].SubItems[3].Text = result.SubItems[1].Text;
            }
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewItemDialog newItemDialog = new NewItemDialog(key: string.Empty, characterAction: string.Empty, EditItem: false);
            newItemDialog.StartPosition = FormStartPosition.CenterParent;
            newItemDialog.ShowDialog();
            var result = newItemDialog.returnResult();
            if (result.Text == "None") return;

            ListViewItem lwi = new ListViewItem();
            lwi.Text = "bind";
            lwi.SubItems.Add("KEYBOARD");
            lwi.SubItems.Add(result.Text);
            lwi.SubItems.Add(result.SubItems[1].Text);
            listView1.Items.Add(lwi);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0) contextMenuStrip1.Items[4].Enabled = false;
            //if (listView1.SelectedItems.Count == 0) contextMenuStrip1.Items[5].Enabled = false;
            contextMenuStrip1.Items[5].Enabled = listView1.SelectedItems.Count != 0;
            contextMenuStrip1.Items[6].Enabled = listView1.SelectedItems.Count != 0;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".cfg";
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = Application.ExecutablePath;
            sfd.Filter = "\"CFG Files|*.cfg|All Files|*.*\"";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveConfig(sfd.FileName);
            }
            comboBox1.Items.Clear();
            foreach (string file in Directory.GetFiles(".\\", "*.cfg", SearchOption.TopDirectoryOnly))
            {
                comboBox1.Items.Add(file);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles(".\\", "*.cfg", SearchOption.TopDirectoryOnly))
            {
                comboBox1.Items.Add(file);
            }
        }

        private void restoreFromBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(".\\configBackup.cfg"))
            {
                MessageBox.Show("No backup found");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to restore from backup? (your old backup will persist)", "Uh oh!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg");
                    File.Copy(".\\configBackup.cfg", $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CitizenFX\\fivem.cfg");
                }
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start over?", "Uh oh!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listView1.Items.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadConfig(comboBox1.Text);
            comboBox1.Items.Clear();
            foreach (string file in Directory.GetFiles(".\\", "*.cfg", SearchOption.TopDirectoryOnly))
            {
                comboBox1.Items.Add(file);
            }
            comboBox1.SelectedIndex = 0;
        }
    }
}
