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

namespace DatabaseProject.UI
{
    public partial class HomePage : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            txtNameHome.Text = SignIn.name;
            txtEmailHome.Text = SignIn.email;
            txtPasswordHome.Text = SignIn.password;
            txtCountryHome.Text = SignIn.country;
            welcomeName.Text = SignIn.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newUserName = txtNameHome.Text;
            string newUserEmail = txtEmailHome.Text;
            string newUserPassword = txtPasswordHome.Text;
            string newUserCountry = txtCountryHome.Text;

            if (newUserName.Equals(""))
            {
                MessageBox.Show("Please enter your new Name", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newUserEmail.Equals(""))
            {

                MessageBox.Show("Please enter your new Email", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newUserPassword.Equals(""))
            {
                MessageBox.Show("Please enter your new Password", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (newUserCountry.Equals(""))
            {
                MessageBox.Show("Please select your new country", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Update Users SET Name='" + @newUserName + "',Email='" + @newUserEmail + "',Password='" + @newUserPassword + "',Country='" + @newUserCountry + "' where ID = '" + SignIn.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);


                updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newUserEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newUserPassword);
                updateCommand.Parameters.AddWithValue("@userCountry", @newUserCountry);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account information updated successfully", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
                else
                {
                    MessageBox.Show("Error occured while creating your account,please try again later", "Account Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Account_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure","Delete Account",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(dialogResult == DialogResult.Yes)
            {
                string query = "DELETE from Users Where ID='" + SignIn.id + "'";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account information deleted successfully", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                   SignUp  signUp = new SignUp();
                    signUp.Show();
                }
                else
                {
                    MessageBox.Show("Error occured while deleting your account,please try again later", "Account deletion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
