using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseProject.Classes;
using DatabaseProject.UI;

namespace DatabaseProject
{
    public partial class SignUp : Form
    {

        
      DBAccess objDBAccess = new DBAccess();
        public SignUp()
        {
            InitializeComponent();
        }

       

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            String userName = txtName.Text;
            String userEmail = txtEmail.Text;
            String userPassword = txtPassword.Text;
            String userCountry = txtCountry.Text;


            if (userName.Equals(""))
            {
                MessageBox.Show("Please enter your name", "Not to be Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter yourEmail", "Not to be Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please choose a password", "Not to be Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please pick a country", "Not to be Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name,Email,Password,Country) values(@userName,@userEmail,@userPassword,@userCountry)");
                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account created successfully", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
                else
                {
                    MessageBox.Show("Error occured while creating your account,please try again later", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void labelToSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
    }
}
