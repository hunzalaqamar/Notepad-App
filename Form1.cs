using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_2
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
            AddLineNumbers();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Text Files only (.txt)|*.txt";
            OFD.Title = "Opening a File";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(OFD.FileName);
                rtb1_NP.Text = sr.ReadToEnd();
                this.Text = OFD.FileName;
                sr.Close();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files only|*.txt";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(rtb1_NP.Text);
                this.Text = sfd.FileName;
                sw.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files only|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(rtb1_NP.Text);
                this.Text = sfd.FileName;
                sw.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _selectedText = "";
            _selectedText = rtb1_NP.SelectedText;
            FontDialog fd = new FontDialog();
            if(fd.ShowDialog() == DialogResult.OK && _selectedText == "")
            {
                rtb1_NP.Font = fd.Font;
            }
            else
            {
                rtb1_NP.SelectionFont = fd.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _selectedText =  rtb1_NP.SelectedText;
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK && _selectedText == "")
            {
                rtb1_NP.ForeColor = cd.Color;
            }
            else
            {
                rtb1_NP.SelectionColor = cd.Color;
            }
        }

        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.BackColor = Color.Black;
            rtb1_NP.ForeColor = Color.White;
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1_NP.BackColor = Color.White;
            rtb1_NP.ForeColor = Color.Black;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pDiag1_Notepad.Document = pDoc1_Notepad;
            if(pDiag1_Notepad.ShowDialog() == DialogResult.OK)
            {
                pDoc1_Notepad.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;
            FindForm FF = new FindForm();
            FF.ShowDialog();
            string _findStr = FF.FindWhatTextBox;
            string _replaceStr = FF.ReplaceWithTextbox;
            int start = 0;
            int end = rtb1_NP.Text.LastIndexOf(_findStr);

            if (_replaceStr == "")
            {
                while (start < end)
                {
                    rtb1_NP.Find(_findStr, start, rtb1_NP.TextLength, RichTextBoxFinds.MatchCase);
                    rtb1_NP.SelectionBackColor = Color.Yellow;
                    start = rtb1_NP.Text.IndexOf(_findStr, start) + 1;
                    counter++;
                }
                MessageBox.Show("Total Occurances Found: " + counter, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                while (start < end)
                {
                    rtb1_NP.Find(_findStr, start, rtb1_NP.TextLength, RichTextBoxFinds.MatchCase);
                    rtb1_NP.SelectionBackColor = Color.Yellow;
                    rtb1_NP.SelectedText = _replaceStr;
                    start = rtb1_NP.Text.IndexOf(_replaceStr, start) + 1;
                    counter++;
                }
                MessageBox.Show("Total Occurances Found: " + counter, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void pd1_Notepad_PrintPage(object sender, PrintPageEventArgs e)
        {
        }

        private void pDoc1_Notepad_PrintPage(object sender, PrintPageEventArgs e)
        { 
            e.Graphics.DrawString(rtb1_NP.Text.ToString(), new Font(rtb1_NP.Font.FontFamily, rtb1_NP.Font.Size), Brushes.Black, new PointF(50,50));
        }

        private void rtb1_NP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AddLineNumbers();
            }
        }
        public void AddLineNumbers()
        {
            Point pt = new Point(0, 0);
            int First_Index = rtb1_NP.GetCharIndexFromPosition(pt);
            int First_Line = rtb1_NP.GetLineFromCharIndex(First_Index);
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            int Last_Index = rtb1_NP.GetCharIndexFromPosition(pt);
            int Last_Line = rtb1_NP.GetLineFromCharIndex(Last_Index);
            rtb2_LN.SelectionAlignment = HorizontalAlignment.Center;
            rtb2_LN.Text = "";
            rtb2_LN.Width = getWidth();
            for (int i = First_Line; i <= Last_Line +2; i++)
            {
                rtb2_LN.Text += i + 1 + Environment.NewLine;
            }
        }
        public int getWidth()
        {
            int w = 25;
            int line = rtb1_NP.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)rtb1_NP.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)rtb1_NP.Font.Size;
            }
            else
            {
                w = 50 + (int)rtb1_NP.Font.Size;
            }

            return w;
        }
    }

}
