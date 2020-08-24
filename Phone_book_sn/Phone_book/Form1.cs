using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Phone_book.UI_Forms;

namespace Phone_book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            New_butt rg = new New_butt();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           Search_form rg = new Search_form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            About_us_form rg = new About_us_form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }
    }
}
