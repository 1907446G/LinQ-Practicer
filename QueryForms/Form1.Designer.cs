namespace QueryForms
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adventureWorks2017DataSet = new QueryForms.AdventureWorks2017DataSet();
            this.adventureWorks2017DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstNameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameC,
            this.LastNameC});
            this.dataGridView1.DataSource = this.adventureWorks2017DataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adventureWorks2017DataSet
            // 
            this.adventureWorks2017DataSet.DataSetName = "AdventureWorks2017DataSet";
            this.adventureWorks2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adventureWorks2017DataSetBindingSource
            // 
            this.adventureWorks2017DataSetBindingSource.DataSource = this.adventureWorks2017DataSet;
            this.adventureWorks2017DataSetBindingSource.Position = 0;
            // 
            // FirstNameC
            // 
            this.FirstNameC.HeaderText = "First Name";
            this.FirstNameC.MinimumWidth = 6;
            this.FirstNameC.Name = "FirstNameC";
            this.FirstNameC.Width = 125;
            // 
            // LastNameC
            // 
            this.LastNameC.HeaderText = "Last Name";
            this.LastNameC.MinimumWidth = 6;
            this.LastNameC.Name = "LastNameC";
            this.LastNameC.Width = 125;
            // 
            // QueryBox
            // 
            this.QueryBox.Location = new System.Drawing.Point(13, 282);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(531, 22);
            this.QueryBox.TabIndex = 1;
            this.QueryBox.TextChanged += new System.EventHandler(this.QueryBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(13, 311);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameC;
        private System.Windows.Forms.BindingSource adventureWorks2017DataSetBindingSource;
        private AdventureWorks2017DataSet adventureWorks2017DataSet;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Button searchBtn;
    }
}

