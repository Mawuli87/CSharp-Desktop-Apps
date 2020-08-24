using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phone_book.UI_Forms
{
    public partial class Search_form : Form
    {
        public Search_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter an id");
                return;
            }

            //--save text file to a specific folder--//
            string fn;
            fn = "E:\\titus\\";
            string p;
            //---first name----//

           
              p = fn + this.textBox1.Text + "_first Name.text";
             string r;
            //System.IO.File.WriteAllText(p, firstName_textBox6.Text, Encoding.UTF8);
            //read the text from files

            //read first name data
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.firstName_textBox6.Text = r;
            }
            else
            {
                MessageBox.Show("File not found");
            }

            //read last name data

            p = fn + this.textBox1.Text + "_last Name.text";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.LastName_textBox5.Text = r;
            }
            else
            {
                MessageBox.Show("File not found");
            }

            //read tel data
            p = fn + this.textBox1.Text + "_telephone.text";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Tel_textBox4.Text = r;
            }
            else
            {
                MessageBox.Show("File not found");
            }


            //read cel data
            p = fn + this.textBox1.Text + "_Cell number.text";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Cel_textBox3.Text = r;
            }
            else
            {
                MessageBox.Show("File not found");
            }


            //read email data
            p = fn + this.textBox1.Text + "_email.text";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Email_textBox2.Text = r;
            }
            else
            {
                MessageBox.Show("File not found");
            }



            //read adress data
            p = fn + this.textBox1.Text + "_address.text";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Adress_textBox7.Text = r;
            }
            else
            {
                MessageBox.Show("File not found");
            }


            //read comment data
            p = fn + this.textBox1.Text + "_comment.text";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Comment_textBox8.Text = r;
            }
            else
            {
                MessageBox.Show("File not found");
            }
            //end of all
            this.id_textBox1.Text = this.textBox1.Text;
        }
    }
}
