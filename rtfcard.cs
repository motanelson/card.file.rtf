using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Windowscardrtf
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.size2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.noBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCardFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.size1ToolStripMenuItem,
            this.size2ToolStripMenuItem,
            this.noBoldToolStripMenuItem,
            this.addNewCardFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.boldToolStripMenuItem.Text = "bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click_1);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click_1);
            // 
            // size1ToolStripMenuItem
            // 
            this.size1ToolStripMenuItem.Name = "size1ToolStripMenuItem";
            this.size1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.size1ToolStripMenuItem.Text = "size1";
            this.size1ToolStripMenuItem.Click += new System.EventHandler(this.size1ToolStripMenuItem_Click);
            // 
            // size2ToolStripMenuItem
            // 
            this.size2ToolStripMenuItem.Name = "size2ToolStripMenuItem";
            this.size2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.size2ToolStripMenuItem.Text = "size2";
            this.size2ToolStripMenuItem.Click += new System.EventHandler(this.size2ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(645, 22);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(628, 148);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(640, 137);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // noBoldToolStripMenuItem
            // 
            this.noBoldToolStripMenuItem.Name = "noBoldToolStripMenuItem";
            this.noBoldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noBoldToolStripMenuItem.Text = "no bold";
            this.noBoldToolStripMenuItem.Click += new System.EventHandler(this.noBoldToolStripMenuItem_Click_1);
            // 
            // addNewCardFileToolStripMenuItem
            // 
            this.addNewCardFileToolStripMenuItem.Name = "addNewCardFileToolStripMenuItem";
            this.addNewCardFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCardFileToolStripMenuItem.Text = "add New Card File";
            this.addNewCardFileToolStripMenuItem.Click += new System.EventHandler(this.addNewCardFileToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem size2ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem noBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCardFileToolStripMenuItem;
    }
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

    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
