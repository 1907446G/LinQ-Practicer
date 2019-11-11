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
    public partial class HRStaff : Form
    {
        Employee currentUser = new Employee();
        public HRStaff(Employee loggedIn)
        {
            InitializeComponent();
            currentUser = loggedIn;
        }

        private void HRStaff_Load(object sender, EventArgs e)
        {
            using (var context = new AdventureWorks2017Entities())
            {
                var staff = context.Employees;
            }
        }
    }
}
