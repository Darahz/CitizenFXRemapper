using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenFXRemapper
{
    public partial class NewItemDialog : Form
    {

        private ListViewItem result = new ListViewItem();
        public bool isEdited = false;
        public NewItemDialog(string key, string characterAction, bool EditItem)
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Keys)).Cast<System.Windows.Forms.Keys>())
            {
                comboBox1.Items.Add(item.ToString());
            }

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                string value = comboBox1.GetItemText(comboBox1.Items[i]);
                if(Regex.Match(value, "D[0-9]").Success){
                    comboBox1.Items[comboBox1.FindStringExact(value)] = value.Replace("D", string.Empty);
                }
            }


            int index = comboBox1.FindString(key.ToUpper().Trim());
            comboBox1.SelectedIndex = comboBox1.FindString(key);
            if (characterAction != string.Empty) textBox1.Text = characterAction;
            if (characterAction != string.Empty) richTextBox1.Text = characterAction;
            if (EditItem) button2.Text = "Save Keybind";
            isEdited = EditItem;
            CheckForColorTexts();
            textBox1.TextChanged += (s, e) =>
            {
                CheckForColorTexts();
            };
        }

        private void CheckForColorTexts()
        {
            richTextBox1.Text = textBox1.Text;
            for (int i = 0; i < textBox1.Text.ToCharArray().Length; i++)
            {
                char c = textBox1.Text.ToCharArray()[i];
                if (c == '~')
                {
                    int cur = i;
                    if (i + 1 >= textBox1.TextLength) return;
                    if (i + 2 >= textBox1.TextLength) return;

                    char before = textBox1.Text.ToCharArray()[i];
                    char next = textBox1.Text.ToCharArray()[i + 1];
                    char After = textBox1.Text.ToCharArray()[i + 2];

                    string total = $"{before}{next}{After}";

                    switch (total)
                    {
                        case "~r~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Red;
                            break;
                        case "~g~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Green;
                            break;
                        case "~b~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Blue;
                            break;
                        case "~y~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Gold;
                            break;
                        case "~p~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Purple;
                            break;
                        case "~c~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Gray;
                            break;
                        case "~u~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Black;
                            break;
                        case "~o~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.Orange;
                            break;
                        case "~w~":
                            richTextBox1.Select(i, richTextBox1.TextLength);
                            richTextBox1.SelectionColor = Color.White;
                            break;
                    }
                }
            }

        }

        private void InsertColorREDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~r~");
            textBox1.SelectionStart = selection + 3;
        }

        private void InsertColorBLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~b~");
            textBox1.SelectionStart = selection + 3;
        }

        private void InsertColorGREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~g~");
            textBox1.SelectionStart = selection + 3;
        }

        private void InsertColorYELLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~y~");
            textBox1.SelectionStart = selection + 3;
        }

        private void InsertColorPURPULEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~p~");
            textBox1.SelectionStart = selection + 3;
        }

        private void InsertColorORANGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~o~");
            textBox1.SelectionStart = selection + 3;
        }

        private void InsertColorGREYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~c~");
            textBox1.SelectionStart = selection + 3;

        }

        private void InsertColorWHITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~w~");
            textBox1.SelectionStart = selection + 3;
        }

        private void InsertStyleBOLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selection = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(selection, "~h~");
            textBox1.SelectionStart = selection + 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal ListViewItem returnResult()
        {
            ListViewItem lwi = new ListViewItem();
            lwi.Text = comboBox1.Text;
            lwi.SubItems.Add(textBox1.Text);
            result = lwi;
            return result;

        }

        public static void Find(RichTextBox rtb, String word, Color color)
        {
            if (word == "")
            {
                return;
            }
            int s_start = rtb.SelectionStart, startIndex = 0, index;
            while ((index = rtb.Text.IndexOf(word, startIndex)) != -1)
            {
                rtb.Select(index, word.Length);
                rtb.SelectionColor = color;
                startIndex = index + word.Length;
            }
            rtb.SelectionStart = 0;
            rtb.SelectionLength = rtb.TextLength;
            rtb.SelectionColor = Color.Black;
        }
    }
}
