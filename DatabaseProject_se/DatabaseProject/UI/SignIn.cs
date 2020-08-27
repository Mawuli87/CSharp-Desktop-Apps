using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject.Classes;

namespace DatabaseProject.UI
{
    public partial class SignIn : Form
    {
        public static string id, name, email, password, country;
        DBAccess objDbAccess = new DBAccess();
        //table to store users when fetch from database
        DataTable dtUsers = new DataTable();
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userEmailLogin = txtEmailLogin.Text;
            string userPasswordLogin = txtPasswordLogin.Text;


            if (userEmailLogin.Equals(""))
            {
                MessageBox.Show("Please enter your Email", "Not to be Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (userPasswordLogin.Equals(""))
            {

                MessageBox.Show("Please enter your Password", "Not to be Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "select * from Users where Email = '" + userEmailLogin + "' AND Password = '" + userPasswordLogin + "'";

                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();

                    MessageBox.Show("Login successful", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objDbAccess.closeConn();
                    //redirect tohomepage
                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials, Check your inputs", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LabelToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
