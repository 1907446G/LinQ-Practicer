using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null,
                dataGridView1,
                new object[] { true });
            using (var context = new AdventureWorks2017Entities())
            {

                var queryEmployees = (from x in context.vEmployees
                                      join y in context.Employees on x.BusinessEntityID equals y.BusinessEntityID
                                      select new
                                      {
                                          Title = x.Title,
                                          Name = x.FirstName + " " + x.MiddleName + " " + x.LastName,
                                          JobTitle = x.JobTitle,
                                          EmailAddress = x.EmailAddress,
                                          City = x.City,
                                          State = x.StateProvinceName
                                      });
                
                dataGridView1.DataSource = queryEmployees.ToList();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
