using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phone_book.UI_Forms
{
    public partial class New_butt : Form
    {
        public New_butt()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.info_group_box.Enabled = false;
            //-----clear Textboxes----//
            this.id_textBox1.ResetText();
            this.firstName_textBox6.ResetText();
            this.LastName_textBox5.ResetText();
            this.Tel_textBox4.ResetText();
            this.Cel_textBox3.ResetText();
            this.Email_textBox2.ResetText();
            this.Adress_textBox7.ResetText();
            this.Comment_textBox8.ResetText();

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            this.new_button.Enabled = true;
            this.save_button.Enabled = false;
            this.info_group_box.Enabled = false;

            //--save text file to a specific folder--//
            string fn;
            fn ="E:\\titus\\";
            string p;
            //---first name----//

            if (this.id_textBox1.Text == "")
            {
                MessageBox.Show("You must enter an id");
                this.new_button.Enabled = false;
                this.save_button.Enabled = true;
                this.info_group_box.Enabled = true;
            }
            else
            {
                p = fn + this.id_textBox1.Text + "_first Name.text";
                System.IO.File.WriteAllText(p, firstName_textBox6.Text, Encoding.UTF8);
                //---last name----//
                p = fn + this.id_textBox1.Text + "_last Name.text";
                System.IO.File.WriteAllText(p, LastName_textBox5.Text, Encoding.UTF8);
                //---telephone----//
                p = fn + this.id_textBox1.Text + "_telephone.text";
                System.IO.File.WriteAllText(p, Tel_textBox4.Text, Encoding.UTF8);
                //---cell number----//
                p = fn + this.id_textBox1.Text + "_Cell number.text";
                System.IO.File.WriteAllText(p, Cel_textBox3.Text, Encoding.UTF8);
                //---email----//
                p = fn + this.id_textBox1.Text + "_email.text";
                System.IO.File.WriteAllText(p, Email_textBox2.Text, Encoding.UTF8);
                //---address----//
                p = fn + this.id_textBox1.Text + "_address.text";
                System.IO.File.WriteAllText(p, Adress_textBox7.Text, Encoding.UTF8);
                //---comment----//
                p = fn + this.id_textBox1.Text + "_comment.text";
                System.IO.File.WriteAllText(p, Comment_textBox8.Text, Encoding.UTF8);


                MessageBox.Show("Saved successfully");



            }

        }

        private void New_butt_Load(object sender, EventArgs e)
        {
            
        }

        private void new_button_Click(object sender, EventArgs e)
        {
           
            this.new_button.Enabled = false;
            this.save_button.Enabled = true;
            this.info_group_box.Enabled = true;

            //-----clear Textboxes----//
            this.id_textBox1.ResetText();
            this.firstName_textBox6.ResetText();
            this.LastName_textBox5.ResetText();
            this.Tel_textBox4.ResetText();
            this.Cel_textBox3.ResetText();
            this.Email_textBox2.ResetText();
            this.Adress_textBox7.ResetText();
            this.Comment_textBox8.ResetText();

        }
    }
}
