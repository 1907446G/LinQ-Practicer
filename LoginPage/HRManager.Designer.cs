namespace LoginPage
{
    partial class HRManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeeList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2017DataSet = new LoginPage.AdventureWorks2017DataSet();
            this.vEmployeeTableAdapter = new LoginPage.AdventureWorks2017DataSetTableAdapters.vEmployeeTableAdapter();
            this.manageStaffBtn = new System.Windows.Forms.Button();
            this.addStaffBtn = new System.Windows.Forms.Button();
            this.exitedStaffBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeList
            // 
            this.employeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeList.AutoSize = true;
            this.employeeList.Location = new System.Drawing.Point(0, 0);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(96, 17);
            this.employeeList.TabIndex = 0;
            this.employeeList.Text = "Employee List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 349);
            this.dataGridView1.TabIndex = 1;
            // 
            // vEmployeeBindingSource
            // 
            this.vEmployeeBindingSource.DataMember = "vEmployee";
            this.vEmployeeBindingSource.DataSource = this.adventureWorks2017DataSet;
            // 
            // adventureWorks2017DataSet
            // 
            this.adventureWorks2017DataSet.DataSetName = "AdventureWorks2017DataSet";
            this.adventureWorks2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEmployeeTableAdapter
            // 
            this.vEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // manageStaffBtn
            // 
            this.manageStaffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manageStaffBtn.AutoSize = true;
            this.manageStaffBtn.Location = new System.Drawing.Point(12, 397);
            this.manageStaffBtn.Name = "manageStaffBtn";
            this.manageStaffBtn.Size = new System.Drawing.Size(203, 27);
            this.manageStaffBtn.TabIndex = 2;
            this.manageStaffBtn.Text = "Manage Staff";
            this.manageStaffBtn.UseVisualStyleBackColor = true;
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStaffBtn.AutoSize = true;
            this.addStaffBtn.Location = new System.Drawing.Point(283, 397);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(235, 27);
            this.addStaffBtn.TabIndex = 3;
            this.addStaffBtn.Text = "Add New Staff";
            this.addStaffBtn.UseVisualStyleBackColor = true;
            // 
            // exitedStaffBtn
            // 
            this.exitedStaffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitedStaffBtn.AutoSize = true;
            this.exitedStaffBtn.Location = new System.Drawing.Point(595, 397);
            this.exitedStaffBtn.Name = "exitedStaffBtn";
            this.exitedStaffBtn.Size = new System.Drawing.Size(193, 27);
            this.exitedStaffBtn.TabIndex = 4;
            this.exitedStaffBtn.Text = "View Exited Staff";
            this.exitedStaffBtn.UseVisualStyleBackColor = true;
            // 
            // HRManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitedStaffBtn);
            this.Controls.Add(this.addStaffBtn);
            this.Controls.Add(this.manageStaffBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employeeList);
            this.Name = "HRManager";
            this.Text = "Human Resource";
            this.Load += new System.EventHandler(this.HRManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdventureWorks2017DataSet adventureWorks2017DataSet;
        private System.Windows.Forms.BindingSource vEmployeeBindingSource;
        private AdventureWorks2017DataSetTableAdapters.vEmployeeTableAdapter vEmployeeTableAdapter;
        private System.Windows.Forms.Button manageStaffBtn;
        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button exitedStaffBtn;
    }
}