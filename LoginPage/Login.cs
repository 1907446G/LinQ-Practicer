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
    public partial class Login : Form
    {
        public Login()
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
            using (var context = new AdventureWorks2017Entities())
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
                        #region User's account validation
                        if (passwordField.Text.Equals(username.BirthDate.ToString("yyyyMMdd")))
                        {
                            MessageBox.Show("Login successful", "Welcome", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information);
                            var department = (from y in context.vEmployeeDepartments
                                              where username.BusinessEntityID == y.BusinessEntityID
                                              select y.Department);
                            #region Manager check
                            if (username.OrganizationLevel <= 2 || username.OrganizationLevel == null)
                            {
                                MessageBox.Show($"You have a Manager's access priviledge. " +
                                    $"Welcome {username.Person.FirstName} {username.Person.MiddleName} {username.Person.LastName} from {department.First()}",
                                    "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                HRManager hR = new HRManager(username);
                                hR.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show($"Welcome {username.Person.FirstName} {username.Person.MiddleName} {username.Person.LastName} from {department.First()}",
                                    "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            #endregion
                            
                        }
                        else
                        {
                            MessageBox.Show("Password incorrect", "Error", MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Error);
                        }
                        #endregion
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
