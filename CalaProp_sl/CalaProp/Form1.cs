using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalaProp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text =this.main_num_label.Text+ "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";

            if (this.main_num_label.Text !="")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
           
            this.main_num_label.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }

            this.main_num_label.Text = "";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "*";
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }

            this.main_num_label.Text = "";
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "%";
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }

            this.main_num_label.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r;
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.main_num_label.Text, out sn);
            r = 0;
            if (this.operator_label.Text == "+") {
                r = fn + sn;
            }
            //substraction
            if (this.operator_label.Text == "-")
            {
                r = fn - sn;
            }
            //multiplication
            if (this.operator_label.Text == "*")
            {
                r = fn * sn;
            }
            //division
            if (this.operator_label.Text == "%")
            {
                r = fn / sn;
            }
            //display result
            this.main_num_label.Text = r.ToString();
            this.operator_label.Text = "";
            this.first_num_label.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + ".";
        }
    }
}
