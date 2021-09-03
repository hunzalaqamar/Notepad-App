using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        public string FindWhatTextBox
        {
            get { return tb1_find.Text; }
        }
        public string ReplaceWithTextbox
        {
            get { return tb2_replace.Text; }
        }

        private void btn1_find_Click(object sender, EventArgs e)
        {
            if(tb1_find.Text.ToString() == "")
            {
                MessageBox.Show("Please Write the word or statement you want to find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
            }
        }

        private void btn2_Replace_Click(object sender, EventArgs e)
        {
            if (tb1_find.Text.ToString() == "" || tb2_replace.Text.ToString() == "")
            {
                MessageBox.Show("Please Write the word or statement you want to find", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
            }
        }
    }
}
