using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenFXRemapper.Classes
{
    internal class Confighandler
    {
        public static List<string> FullConfig = new List<string>();
        public static List<string> Userbinds = new List<string>();
        public static List<string> FullWithoutBinds = new List<string>();

        internal static void ReadConfig(string Filename, RichTextBox RichTextBox, ListView keybindlist)
        {
            Cursor.Current = Cursors.WaitCursor;
            ColorRichtextbox(Filename, RichTextBox);

            keybindlist.Items.Clear();

            FullConfig = File.ReadAllLines(Filename).ToList();
            Userbinds = FullConfig.Where(x => x.StartsWith("bind")).ToList();
            FullWithoutBinds = FullConfig.Except(Userbinds).ToList();

            for (int i = 0; i < Userbinds.Count; i++)
            {
                string[] raw = Userbinds[i].Split(' ');
                string action = raw[0];
                string inputMethod = raw[1];
                string key = raw[2];
                string result = string.Join(" ", raw.Skip(3));

                ListViewItem lwi = new ListViewItem();
                lwi.Text = action;
                lwi.SubItems.Add(inputMethod);
                lwi.SubItems.Add(key);
                lwi.SubItems.Add(result);
                keybindlist.Items.Add(lwi);

            }
            keybindlist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


            Cursor.Current = Cursors.Default;
        }

        private static void ColorRichtextbox(string filename, RichTextBox richTextBox)
        {
            richTextBox.Clear();
            if (filename != string.Empty)
            {
                string[] FileContent = File.ReadAllText(filename).Split('\n').ToArray();
                string[] FirstItems = FileContent.Take(2).ToArray();

                richTextBox.Text += string.Join("", FirstItems);
                richTextBox.Text += string.Join("", FileContent.Skip(2).OrderBy(x => x));
            }

            for (int i = 0; i < richTextBox.Lines.Length; i++)
            {

                if (richTextBox.Lines[i].StartsWith("//"))
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i), richTextBox.Lines[i].Length);
                    richTextBox.SelectionColor = Color.Green;
                }

                if (i < 2) continue;

                Match chrpos = Regex.Match(richTextBox.Lines[i], "bind");

                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index, chrpos.Length);
                    richTextBox.SelectionColor = Color.GreenYellow;
                }

                chrpos = Regex.Match(richTextBox.Lines[i], "\"[^\"]*\"");
                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index + 1, (chrpos.Length - 2));
                    richTextBox.SelectionColor = Color.LightSeaGreen;
                }

                chrpos = Regex.Match(richTextBox.Lines[i], "rbind");
                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index, chrpos.Length);
                    richTextBox.SelectionColor = Color.Salmon;
                }

                chrpos = Regex.Match(richTextBox.Lines[i], "seta");
                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index, chrpos.Length);
                    richTextBox.SelectionColor = Color.Violet;
                }

                chrpos = Regex.Match(richTextBox.Lines[i], "true");
                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index, chrpos.Length);
                    richTextBox.SelectionColor = Color.LightGreen;
                }

                chrpos = Regex.Match(richTextBox.Lines[i], "false");
                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index, chrpos.Length);
                    richTextBox.SelectionColor = Color.Salmon;
                }

                chrpos = Regex.Match(richTextBox.Lines[i], "\\s\\d\\s");
                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index, chrpos.Length);
                    richTextBox.SelectionColor = Color.Yellow;
                }

                chrpos = Regex.Match(richTextBox.Lines[i], "\\s[Ff][0-9]+\\s");
                if (chrpos.Success)
                {
                    richTextBox.Select(richTextBox.GetFirstCharIndexFromLine(i) + chrpos.Index, chrpos.Length);
                    richTextBox.SelectionColor = Color.Yellow;
                }

            }
        }
    }
}