using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Windowscardrtf
{
    public partial class Form1 : Form
    {
        public static String[] cards = { };
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void  addNewCardFileToolStripMenuItem_Click_1(object sender, EventArgs e)

        {
            Array.Resize(ref cards, cards.Length + 1);
            cards[cards.Length - 1] = textBox2.Rtf;
            listBox1.Items.Add(textBox1.Text);

        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String s = "";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Trim() != "")
            {
                for (int i = 0; i < cards.Length; i++)
                {
                    s = s + listBox1.Items[i].ToString() + "\x02" + cards[i] + "\x01";

                }
                File.WriteAllText(saveFileDialog1.FileName, s);
            }
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String s = "";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Trim() != "")
            {
                for (int i = 0; i < cards.Length; i++)
                {
                    s = s + listBox1.Items[i].ToString() + "\x02" + cards[i] + "\x01";

                }
                File.WriteAllText(saveFileDialog1.FileName, "s");
            }
            textBox2.Clear();
            //textBox2.Rtf = "";
            textBox1.Text = "";
            listBox1.Items.Clear();
            Array.Resize(ref cards, 0);
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String[] s = { };
            String[] ss = { };
            int counter = 0;
            listBox1.Items.Clear();
            Array.Resize(ref cards, 0);

            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.Trim() != "")
            {
                s = File.ReadAllText(openFileDialog1.FileName).Trim().Split('\x01');
                Array.Resize(ref cards, s.Length - 1);

                MessageBox.Show(cards.Length.ToString());
                foreach (var s2 in s)
                {
                    ss = s2.Split('\x02');
                    if (ss.Length > 1)
                    {
                        listBox1.Items.Add(ss[0]);
                        cards[counter] = ss[1];

                    }
                    counter = counter + 1;

                }


            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            textBox2.Rtf = cards[listBox1.SelectedIndex];
        }

        
        private void boldToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String s = textBox2.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s + "\\b\\f1\\fs17 \\par} ";

            textBox2.Rtf = s;
            textBox2.SelectionStart = s.Length - 2;
        }

        private void noBoldToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String s = textBox2.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s + "\\b0\\f1\\fs17  \\par}";

            textBox2.Rtf = s;
            textBox2.SelectionStart = s.Length - 2;

        }

        private void size1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = textBox2.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s + "\\f1\\fs22  \\par}";

            textBox2.Rtf = s;
            textBox2.SelectionStart = s.Length - 2;
        }

        private void size2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = textBox2.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s + "\\f1\\fs32  \\par}";

            textBox2.Rtf = s;
            textBox2.SelectionStart = s.Length - 2;

        }

        private void  colorToolStripMenuItem_Click_1(object sender, EventArgs e)

        {
            String s = textBox2.Rtf + "";
            String ss = "";
            String sss = "";
            int i = 0;
            s = s.Trim();
            i = s.IndexOf("\\viewkind4");
            ss = s.Substring(0, i);
            sss = s.Substring(i, s.Length - i);
            s = ss + "{\\colortbl ;\\red238\\green0\\blue0;}\r\n" + sss;


            i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s + "\\f1\\cf1\\fs17  \\par}";

            textBox2.Rtf = s;
            textBox2.SelectionStart = s.Length - 2;
            //MessageBox.Show(textBox2.Rtf);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = "";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Trim() != "")
            {
                for (int i = 0; i < cards.Length; i++)
                {
                    s = s + listBox1.Items[i].ToString() + "\x02" + cards[i] + "\x01";

                }
                File.WriteAllText(saveFileDialog1.FileName, "s");
            }
            textBox2.Clear();
            //textBox2.Rtf = "";
            textBox1.Text = "";
            listBox1.Items.Clear();
            Array.Resize(ref cards, 0);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
