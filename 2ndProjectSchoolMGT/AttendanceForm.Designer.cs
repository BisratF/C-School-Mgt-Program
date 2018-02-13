namespace _2ndProjectSchoolMGT
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.row_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.studentattendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolmgt_DataSet = new _2ndProjectSchoolMGT.schoolmgt_DataSet();
            this.apply_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.today_dropdown = new Bunifu.Framework.UI.BunifuDatepicker();
            this.remarks_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.daylyattendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.student_attendanceTableAdapter = new _2ndProjectSchoolMGT.schoolmgt_DataSetTableAdapters.student_attendanceTableAdapter();
            this.dayly_attendanceTableAdapter = new _2ndProjectSchoolMGT.schoolmgt_DataSetTableAdapters.dayly_attendanceTableAdapter();
            this.attendance_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.P = new Bunifu.Framework.UI.BunifuCheckbox();
            this.A = new Bunifu.Framework.UI.BunifuCheckbox();
            this.L = new Bunifu.Framework.UI.BunifuCheckbox();
            this.idattDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givennameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.date_txt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentattendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmgt_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daylyattendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.L);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.P);
            this.groupBox1.Controls.Add(this.today_dropdown);
            this.groupBox1.Controls.Add(this.remarks_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.attendance_txt);
            this.groupBox1.Controls.Add(this.date_txt);
            this.groupBox1.Controls.Add(this.row_txt);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Attendance Form";
            // 
            // row_txt
            // 
            this.row_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.row_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentattendanceBindingSource, "id_att", true));
            this.row_txt.Location = new System.Drawing.Point(255, 26);
            this.row_txt.Name = "row_txt";
            this.row_txt.Size = new System.Drawing.Size(28, 20);
            this.row_txt.TabIndex = 126;
            this.row_txt.TextChanged += new System.EventHandler(this.row_txt_TextChanged);
            // 
            // studentattendanceBindingSource
            // 
            this.studentattendanceBindingSource.DataMember = "student_attendance";
            this.studentattendanceBindingSource.DataSource = this.schoolmgt_DataSet;
            // 
            // schoolmgt_DataSet
            // 
            this.schoolmgt_DataSet.DataSetName = "schoolmgt_DataSet";
            this.schoolmgt_DataSet.EnforceConstraints = false;
            this.schoolmgt_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apply_btn
            // 
            this.apply_btn.ActiveBorderThickness = 1;
            this.apply_btn.ActiveCornerRadius = 20;
            this.apply_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.apply_btn.ActiveForecolor = System.Drawing.Color.White;
            this.apply_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.apply_btn.BackColor = System.Drawing.SystemColors.Control;
            this.apply_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apply_btn.BackgroundImage")));
            this.apply_btn.ButtonText = "Apply";
            this.apply_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apply_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.apply_btn.IdleBorderThickness = 1;
            this.apply_btn.IdleCornerRadius = 20;
            this.apply_btn.IdleFillColor = System.Drawing.Color.White;
            this.apply_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.apply_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.apply_btn.Location = new System.Drawing.Point(389, 10);
            this.apply_btn.Margin = new System.Windows.Forms.Padding(5);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(101, 37);
            this.apply_btn.TabIndex = 122;
            this.apply_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // today_dropdown
            // 
            this.today_dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.today_dropdown.BorderRadius = 0;
            this.today_dropdown.ForeColor = System.Drawing.Color.White;
            this.today_dropdown.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.today_dropdown.FormatCustom = "dd-MMM-yyyy";
            this.today_dropdown.Location = new System.Drawing.Point(117, 26);
            this.today_dropdown.Name = "today_dropdown";
            this.today_dropdown.Size = new System.Drawing.Size(187, 31);
            this.today_dropdown.TabIndex = 40;
            this.today_dropdown.Value = new System.DateTime(2017, 9, 15, 0, 0, 0, 0);
            this.today_dropdown.onValueChanged += new System.EventHandler(this.today_dropdown_onValueChanged);
            // 
            // remarks_txt
            // 
            this.remarks_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.remarks_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentattendanceBindingSource, "remarks", true));
            this.remarks_txt.Location = new System.Drawing.Point(604, 19);
            this.remarks_txt.Multiline = true;
            this.remarks_txt.Name = "remarks_txt";
            this.remarks_txt.Size = new System.Drawing.Size(236, 69);
            this.remarks_txt.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date:";
            // 
            // daylyattendanceBindingSource
            // 
            this.daylyattendanceBindingSource.DataMember = "dayly_attendance";
            this.daylyattendanceBindingSource.DataSource = this.schoolmgt_DataSet;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.GridView.AutoGenerateColumns = false;
            this.GridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idattDataGridViewTextBoxColumn,
            this.sirnameDataGridViewTextBoxColumn,
            this.givennameDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.presentDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.GridView.DataSource = this.studentattendanceBindingSource;
            this.GridView.DoubleBuffered = true;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.GridView.HeaderForeColor = System.Drawing.Color.White;
            this.GridView.Location = new System.Drawing.Point(3, 200);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridView.RowHeadersVisible = false;
            this.GridView.Size = new System.Drawing.Size(868, 568);
            this.GridView.TabIndex = 2;
            // 
            // student_attendanceTableAdapter
            // 
            this.student_attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // dayly_attendanceTableAdapter
            // 
            this.dayly_attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendance_txt
            // 
            this.attendance_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.attendance_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentattendanceBindingSource, "present", true));
            this.attendance_txt.Location = new System.Drawing.Point(665, 65);
            this.attendance_txt.Name = "attendance_txt";
            this.attendance_txt.Size = new System.Drawing.Size(120, 20);
            this.attendance_txt.TabIndex = 127;
            this.attendance_txt.TextChanged += new System.EventHandler(this.attendance_txt_TextChanged);
            // 
            // P
            // 
            this.P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.P.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.P.Checked = true;
            this.P.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.P.ForeColor = System.Drawing.Color.White;
            this.P.Location = new System.Drawing.Point(343, 37);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(20, 20);
            this.P.TabIndex = 128;
            this.P.OnChange += new System.EventHandler(this.amClicked);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Red;
            this.A.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.A.Checked = true;
            this.A.CheckedOnColor = System.Drawing.Color.Red;
            this.A.ForeColor = System.Drawing.Color.White;
            this.A.Location = new System.Drawing.Point(438, 37);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(20, 20);
            this.A.TabIndex = 129;
            this.A.OnChange += new System.EventHandler(this.A_Clicked);
            // 
            // L
            // 
            this.L.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.L.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.L.Checked = true;
            this.L.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.L.ForeColor = System.Drawing.Color.Black;
            this.L.Location = new System.Drawing.Point(530, 37);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(20, 20);
            this.L.TabIndex = 130;
            this.L.OnChange += new System.EventHandler(this.L_cliked);
            // 
            // idattDataGridViewTextBoxColumn
            // 
            this.idattDataGridViewTextBoxColumn.DataPropertyName = "id_att";
            this.idattDataGridViewTextBoxColumn.HeaderText = "Num";
            this.idattDataGridViewTextBoxColumn.Name = "idattDataGridViewTextBoxColumn";
            this.idattDataGridViewTextBoxColumn.Width = 30;
            // 
            // sirnameDataGridViewTextBoxColumn
            // 
            this.sirnameDataGridViewTextBoxColumn.DataPropertyName = "sir_name";
            this.sirnameDataGridViewTextBoxColumn.HeaderText = "SIR NAM";
            this.sirnameDataGridViewTextBoxColumn.Name = "sirnameDataGridViewTextBoxColumn";
            // 
            // givennameDataGridViewTextBoxColumn
            // 
            this.givennameDataGridViewTextBoxColumn.DataPropertyName = "given_name";
            this.givennameDataGridViewTextBoxColumn.HeaderText = "GIVEN NAME";
            this.givennameDataGridViewTextBoxColumn.Name = "givennameDataGridViewTextBoxColumn";
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "ID CODE";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "DAY";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // presentDataGridViewTextBoxColumn
            // 
            this.presentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.presentDataGridViewTextBoxColumn.DataPropertyName = "present";
            this.presentDataGridViewTextBoxColumn.HeaderText = "ATENDANCE";
            this.presentDataGridViewTextBoxColumn.Name = "presentDataGridViewTextBoxColumn";
            this.presentDataGridViewTextBoxColumn.ReadOnly = true;
            this.presentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.presentDataGridViewTextBoxColumn.Width = 102;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "REMARKS";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(369, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel1.TabIndex = 131;
            this.bunifuCustomLabel1.Text = "Present";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(464, 44);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel2.TabIndex = 132;
            this.bunifuCustomLabel2.Text = "Absent";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(556, 44);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(28, 13);
            this.bunifuCustomLabel3.TabIndex = 133;
            this.bunifuCustomLabel3.Text = "Late";
            // 
            // date_txt
            // 
            this.date_txt.BorderColor = System.Drawing.Color.SeaGreen;
            this.date_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentattendanceBindingSource, "day", true));
            this.date_txt.Location = new System.Drawing.Point(129, 26);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(120, 20);
            this.date_txt.TabIndex = 134;
            this.date_txt.TextChanged += new System.EventHandler(this.date_txt_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.apply_btn);
            this.groupBox2.Location = new System.Drawing.Point(3, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 55);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentattendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmgt_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daylyattendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private schoolmgt_DataSet schoolmgt_DataSet;
        private System.Windows.Forms.BindingSource studentattendanceBindingSource;
        private schoolmgt_DataSetTableAdapters.student_attendanceTableAdapter student_attendanceTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 apply_btn;
        private Bunifu.Framework.UI.BunifuDatepicker today_dropdown;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox remarks_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource daylyattendanceBindingSource;
        private schoolmgt_DataSetTableAdapters.dayly_attendanceTableAdapter dayly_attendanceTableAdapter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox row_txt;
        private Bunifu.Framework.UI.BunifuCheckbox P;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox attendance_txt;
        private Bunifu.Framework.UI.BunifuCheckbox L;
        private Bunifu.Framework.UI.BunifuCheckbox A;
        private System.Windows.Forms.DataGridViewTextBoxColumn idattDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn givennameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox date_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}