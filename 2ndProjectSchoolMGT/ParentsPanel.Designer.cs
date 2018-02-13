namespace _2ndProjectSchoolMGT
{
    partial class ParentsPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentsPanel));
            this.label2 = new System.Windows.Forms.Label();
            this.search_grid_view = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.studentprofileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolmgt_DataSet = new _2ndProjectSchoolMGT.schoolmgt_DataSet();
            this.Parent_Search_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.search_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.student_profileTableAdapter = new _2ndProjectSchoolMGT.schoolmgt_DataSetTableAdapters.student_profileTableAdapter();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givennameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.search_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprofileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmgt_DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parents List";
            // 
            // search_grid_view
            // 
            this.search_grid_view.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_grid_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.search_grid_view.AutoGenerateColumns = false;
            this.search_grid_view.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.search_grid_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_grid_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.search_grid_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.search_grid_view.ColumnHeadersHeight = 36;
            this.search_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.search_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.givennameDataGridViewTextBoxColumn,
            this.sirnameDataGridViewTextBoxColumn,
            this.emergcontactDataGridViewTextBoxColumn,
            this.relationDataGridViewTextBoxColumn,
            this.email,
            this.contactoneDataGridViewTextBoxColumn});
            this.search_grid_view.DataSource = this.studentprofileBindingSource;
            this.search_grid_view.DoubleBuffered = true;
            this.search_grid_view.EnableHeadersVisualStyles = false;
            this.search_grid_view.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.search_grid_view.HeaderForeColor = System.Drawing.Color.White;
            this.search_grid_view.Location = new System.Drawing.Point(1, 156);
            this.search_grid_view.Name = "search_grid_view";
            this.search_grid_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.search_grid_view.RowHeadersVisible = false;
            this.search_grid_view.Size = new System.Drawing.Size(867, 606);
            this.search_grid_view.TabIndex = 6;
            this.search_grid_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_grid_view_CellClick);
            // 
            // studentprofileBindingSource
            // 
            this.studentprofileBindingSource.DataMember = "student_profile";
            this.studentprofileBindingSource.DataSource = this.schoolmgt_DataSet;
            // 
            // schoolmgt_DataSet
            // 
            this.schoolmgt_DataSet.DataSetName = "schoolmgt_DataSet";
            this.schoolmgt_DataSet.EnforceConstraints = false;
            this.schoolmgt_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Parent_Search_txt
            // 
            this.Parent_Search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Parent_Search_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Parent_Search_txt.BackgroundImage")));
            this.Parent_Search_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Parent_Search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.Parent_Search_txt.Icon = ((System.Drawing.Image)(resources.GetObject("Parent_Search_txt.Icon")));
            this.Parent_Search_txt.Location = new System.Drawing.Point(158, 54);
            this.Parent_Search_txt.Name = "Parent_Search_txt";
            this.Parent_Search_txt.Size = new System.Drawing.Size(169, 30);
            this.Parent_Search_txt.TabIndex = 10;
            this.Parent_Search_txt.text = "Search parent ...";
            this.Parent_Search_txt.OnTextChange += new System.EventHandler(this.txtParentSearch_OnTextChange);
            // 
            // search_btn
            // 
            this.search_btn.ActiveBorderThickness = 1;
            this.search_btn.ActiveCornerRadius = 20;
            this.search_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.search_btn.ActiveForecolor = System.Drawing.Color.White;
            this.search_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn.BackgroundImage")));
            this.search_btn.ButtonText = "Search";
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.search_btn.IdleBorderThickness = 1;
            this.search_btn.IdleCornerRadius = 20;
            this.search_btn.IdleFillColor = System.Drawing.Color.White;
            this.search_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.search_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.search_btn.Location = new System.Drawing.Point(354, 50);
            this.search_btn.Margin = new System.Windows.Forms.Padding(5);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(121, 38);
            this.search_btn.TabIndex = 54;
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Parent_Search_txt);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 124);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parents Form";
            // 
            // student_profileTableAdapter
            // 
            this.student_profileTableAdapter.ClearBeforeFill = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 30;
            // 
            // givennameDataGridViewTextBoxColumn
            // 
            this.givennameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.givennameDataGridViewTextBoxColumn.DataPropertyName = "given_name";
            this.givennameDataGridViewTextBoxColumn.HeaderText = "Parent of";
            this.givennameDataGridViewTextBoxColumn.Name = "givennameDataGridViewTextBoxColumn";
            // 
            // sirnameDataGridViewTextBoxColumn
            // 
            this.sirnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sirnameDataGridViewTextBoxColumn.DataPropertyName = "sir_name";
            this.sirnameDataGridViewTextBoxColumn.HeaderText = "";
            this.sirnameDataGridViewTextBoxColumn.Name = "sirnameDataGridViewTextBoxColumn";
            // 
            // emergcontactDataGridViewTextBoxColumn
            // 
            this.emergcontactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emergcontactDataGridViewTextBoxColumn.DataPropertyName = "emerg_contact";
            this.emergcontactDataGridViewTextBoxColumn.HeaderText = "Parent Name";
            this.emergcontactDataGridViewTextBoxColumn.Name = "emergcontactDataGridViewTextBoxColumn";
            // 
            // relationDataGridViewTextBoxColumn
            // 
            this.relationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.relationDataGridViewTextBoxColumn.DataPropertyName = "relation";
            this.relationDataGridViewTextBoxColumn.HeaderText = "relation";
            this.relationDataGridViewTextBoxColumn.Name = "relationDataGridViewTextBoxColumn";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // contactoneDataGridViewTextBoxColumn
            // 
            this.contactoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactoneDataGridViewTextBoxColumn.DataPropertyName = "contact_one";
            this.contactoneDataGridViewTextBoxColumn.HeaderText = "Emergency Contact";
            this.contactoneDataGridViewTextBoxColumn.Name = "contactoneDataGridViewTextBoxColumn";
            // 
            // ParentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search_grid_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentsPanel";
            this.Text = "ParentsPanel";
            this.Load += new System.EventHandler(this.ParentsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentprofileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmgt_DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid search_grid_view;
        private Bunifu.Framework.UI.BunifuTextbox Parent_Search_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 search_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private schoolmgt_DataSet schoolmgt_DataSet;
        private System.Windows.Forms.BindingSource studentprofileBindingSource;
        private schoolmgt_DataSetTableAdapters.student_profileTableAdapter student_profileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn givennameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoneDataGridViewTextBoxColumn;
    }
}