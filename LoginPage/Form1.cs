using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            using(var context = new AdventureWorks2017Entities())
            {
                var checkLogin = context.Employees;
                var x = (from y in checkLogin
                         where y.LoginID.Equals(usernameField.Text) 
                         select y);

                if (usernameField.Text.Equals("") || passwordField.Text.Equals(""))
                {
                    MessageBox.Show("Please enter fill up your login information!", "Error", MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Error);
                }
                else if (!x.Any())
                {
                    MessageBox.Show("Username doesn't exist", "Error", MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Error);
                }
                else
                { 
                    foreach (var username in x)
                    {
                        if (passwordField.Text.Equals(username.BirthDate.ToString("yyyyMMdd")))
                        {
                            MessageBox.Show("Login successful", "Welcome", MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Password incorrect", "Error", MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Error);
                        }
                        if ((username.JobTitle.Contains("Manager")) || (username.JobTitle.Contains("President"))
                            || (username.JobTitle.Contains("Supervisor")) || (username.JobTitle.Contains("Officer"))){
                            MessageBox.Show("You have a Manager's access priviledge."
                                ,"Manager Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
