using System;
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
        internal static void ReadConfig(string Filename, RichTextBox RichTextBox)
        {
            Cursor.Current = Cursors.WaitCursor;
            ColorRichtextbox(Filename, RichTextBox);
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