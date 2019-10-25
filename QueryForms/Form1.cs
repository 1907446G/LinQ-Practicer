using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QueryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using(var context = new AdventureWorks2017Entities())
            {
                var filter = context.People;
                var query = (from x in filter
                             where x.FirstName.Contains(QueryBox.Text)
                             select x);
                foreach (var item in query)
                {
                    var rows = new string[] { item.FirstName, item.LastName };
                    dataGridView1.Rows.Add(rows);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
