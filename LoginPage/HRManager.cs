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
    public partial class HRManager : Form
    {
        public Employee currentUser = new Employee();
        public HRManager(Employee loggedInUser)
        {
            InitializeComponent();
            currentUser = loggedInUser;
        }

        private void HRManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2017DataSet.vEmployee' table. You can move, or remove it, as needed.
            this.vEmployeeTableAdapter.Fill(this.adventureWorks2017DataSet.vEmployee);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Job Title");
            dataTable.Columns.Add("Email Address");
            dataTable.Columns.Add("City");
            dataTable.Columns.Add("State");
            using (var context = new AdventureWorks2017Entities())
            {
                
                var queryEmployees = (from x in context.vEmployees
                                      where context.uspGetManagerEmployees(currentUser.BusinessEntityID).First().BusinessEntityID == currentUser.BusinessEntityID
                                      select new
                                      {
                                          Title = x.Title,
                                          FirstName = x.FirstName,
                                          MiddleName = x.MiddleName,
                                          LastName = x.LastName,
                                          JobTitle = x.JobTitle,
                                          EmailAddress = x.EmailAddress,
                                          City = x.City,
                                          State = x.StateProvinceName
                                      });
                foreach (var item in queryEmployees)
                {
                    var name = $"{item.FirstName} {item.MiddleName} {item.LastName}";
                    var title = item.Title;
                    var jobTitle = item.JobTitle;
                    var email = item.EmailAddress;
                    var city = item.City;
                    var state = item.State;
                    var row = new string[] { title, name, jobTitle, email, city, state };
                    dataTable.Rows.Add(row);
                }
            }
            dataGridView1.DataSource = dataTable;
        }
    }
}
