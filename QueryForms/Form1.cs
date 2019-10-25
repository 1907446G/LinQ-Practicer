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
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void QueryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QueryBtn_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            using (var context = new AdventureWorks2017Entities())
            {
                
                var filter = context.People;
                var query = (from x in filter
                             where x.FirstName.Contains(QueryBox.Text)
                             select x);
                foreach (var item in query)
                {
                    var row = new string[] { item.FirstName, item.LastName };
                    dataTable.Rows.Add(row);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Second Name");

            dataGridView1.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows != null)
            {
                label1.Text = $"Selected Name: {dataGridView1.Rows[e.RowIndex].Cells[0].Value}";
            }
        }
    }
}
