namespace _2ndProjectSchoolMGT
{
    partial class LibraryPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryPanel));
            this.Library_Data_Grid_View = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarytableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolmgt_DataSet = new _2ndProjectSchoolMGT.schoolmgt_DataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Shelf = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Publisher = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Category = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Description = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Pages = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Year = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Author = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Book_Id = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_ISBN = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_title = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Date_Added = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.dropDown_Category = new Bunifu.Framework.UI.BunifuDropdown();
            this.dropDown_Shelf = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel_Library_inside = new System.Windows.Forms.Panel();
            this.txt_File_Name = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.front_image_Picture_Box = new System.Windows.Forms.PictureBox();
            this.library_tableTableAdapter = new _2ndProjectSchoolMGT.schoolmgt_DataSetTableAdapters.library_tableTableAdapter();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.BtnStudentProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.print_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_New = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Library_Data_Grid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarytableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmgt_DataSet)).BeginInit();
            this.panel_Library_inside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.front_image_Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Library_Data_Grid_View
            // 
            this.Library_Data_Grid_View.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Library_Data_Grid_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Library_Data_Grid_View.AutoGenerateColumns = false;
            this.Library_Data_Grid_View.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Library_Data_Grid_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Library_Data_Grid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Library_Data_Grid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Library_Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Library_Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.bookidDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.dateaddedDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Library_Data_Grid_View.DataSource = this.librarytableBindingSource;
            this.Library_Data_Grid_View.DoubleBuffered = true;
            this.Library_Data_Grid_View.EnableHeadersVisualStyles = false;
            this.Library_Data_Grid_View.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.Library_Data_Grid_View.HeaderForeColor = System.Drawing.Color.White;
            this.Library_Data_Grid_View.Location = new System.Drawing.Point(1, 383);
            this.Library_Data_Grid_View.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Library_Data_Grid_View.Name = "Library_Data_Grid_View";
            this.Library_Data_Grid_View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Library_Data_Grid_View.RowHeadersVisible = false;
            this.Library_Data_Grid_View.Size = new System.Drawing.Size(868, 273);
            this.Library_Data_Grid_View.TabIndex = 46;
            this.Library_Data_Grid_View.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Library_Data_Grid_View_KeyDown);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 20;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 60;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.Width = 75;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 65;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 40;
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            // 
            // dateaddedDataGridViewTextBoxColumn
            // 
            this.dateaddedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dateaddedDataGridViewTextBoxColumn.DataPropertyName = "date_added";
            this.dateaddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.dateaddedDataGridViewTextBoxColumn.Name = "dateaddedDataGridViewTextBoxColumn";
            this.dateaddedDataGridViewTextBoxColumn.Width = 96;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            this.pagesDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // librarytableBindingSource
            // 
            this.librarytableBindingSource.DataMember = "library_table";
            this.librarytableBindingSource.DataSource = this.schoolmgt_DataSet;
            // 
            // schoolmgt_DataSet
            // 
            this.schoolmgt_DataSet.DataSetName = "schoolmgt_DataSet";
            this.schoolmgt_DataSet.EnforceConstraints = false;
            this.schoolmgt_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(286, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Shelf :";
            // 
            // txt_Shelf
            // 
            this.txt_Shelf.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Shelf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "shelf", true));
            this.txt_Shelf.Location = new System.Drawing.Point(337, 229);
            this.txt_Shelf.Name = "txt_Shelf";
            this.txt_Shelf.ReadOnly = true;
            this.txt_Shelf.Size = new System.Drawing.Size(69, 20);
            this.txt_Shelf.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Publisher :";
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Publisher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "publisher", true));
            this.txt_Publisher.Location = new System.Drawing.Point(82, 269);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(126, 20);
            this.txt_Publisher.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Category :";
            // 
            // txt_Category
            // 
            this.txt_Category.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Category.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "category", true));
            this.txt_Category.Location = new System.Drawing.Point(82, 229);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.ReadOnly = true;
            this.txt_Category.Size = new System.Drawing.Size(126, 20);
            this.txt_Category.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "description", true));
            this.txt_Description.Location = new System.Drawing.Point(514, 108);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(339, 219);
            this.txt_Description.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Author :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Pages  :";
            // 
            // txt_Pages
            // 
            this.txt_Pages.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Pages.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "pages", true));
            this.txt_Pages.Location = new System.Drawing.Point(328, 307);
            this.txt_Pages.Name = "txt_Pages";
            this.txt_Pages.Size = new System.Drawing.Size(88, 20);
            this.txt_Pages.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Year :";
            // 
            // txt_Year
            // 
            this.txt_Year.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Year.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "year", true));
            this.txt_Year.Location = new System.Drawing.Point(82, 307);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(105, 20);
            this.txt_Year.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ISBN Number";
            // 
            // txt_Author
            // 
            this.txt_Author.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Author.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "author", true));
            this.txt_Author.Location = new System.Drawing.Point(255, 66);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(355, 20);
            this.txt_Author.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Book ID";
            // 
            // txt_Book_Id
            // 
            this.txt_Book_Id.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Book_Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "book_id", true));
            this.txt_Book_Id.Location = new System.Drawing.Point(329, 144);
            this.txt_Book_Id.Name = "txt_Book_Id";
            this.txt_Book_Id.Size = new System.Drawing.Size(154, 20);
            this.txt_Book_Id.TabIndex = 27;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_ISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "isbn", true));
            this.txt_ISBN.Location = new System.Drawing.Point(701, 28);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(152, 20);
            this.txt_ISBN.TabIndex = 47;
            // 
            // txt_title
            // 
            this.txt_title.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "title", true));
            this.txt_title.Location = new System.Drawing.Point(255, 28);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(355, 20);
            this.txt_title.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Title :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(253, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Date Added :";
            // 
            // txt_Date_Added
            // 
            this.txt_Date_Added.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_Date_Added.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "date_added", true));
            this.txt_Date_Added.Location = new System.Drawing.Point(328, 262);
            this.txt_Date_Added.Name = "txt_Date_Added";
            this.txt_Date_Added.ReadOnly = true;
            this.txt_Date_Added.Size = new System.Drawing.Size(92, 20);
            this.txt_Date_Added.TabIndex = 50;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(363, 170);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(88, 29);
            this.btn_Generate.TabIndex = 123;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(46, 183);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(88, 29);
            this.btn_Upload.TabIndex = 124;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // dropDown_Category
            // 
            this.dropDown_Category.BackColor = System.Drawing.Color.Transparent;
            this.dropDown_Category.BorderRadius = 3;
            this.dropDown_Category.DisabledColor = System.Drawing.Color.Gray;
            this.dropDown_Category.ForeColor = System.Drawing.Color.White;
            this.dropDown_Category.Items = new string[] {
        "Text Book",
        "Fiction",
        "Science",
        "Maths",
        "History",
        "Art",
        "Other"};
            this.dropDown_Category.Location = new System.Drawing.Point(81, 224);
            this.dropDown_Category.Name = "dropDown_Category";
            this.dropDown_Category.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.dropDown_Category.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.dropDown_Category.selectedIndex = -1;
            this.dropDown_Category.Size = new System.Drawing.Size(144, 25);
            this.dropDown_Category.TabIndex = 125;
            this.dropDown_Category.Tag = "";
            this.dropDown_Category.onItemSelected += new System.EventHandler(this.dropDown_Category_onItemSelected);
            // 
            // dropDown_Shelf
            // 
            this.dropDown_Shelf.BackColor = System.Drawing.Color.Transparent;
            this.dropDown_Shelf.BorderRadius = 3;
            this.dropDown_Shelf.DisabledColor = System.Drawing.Color.Gray;
            this.dropDown_Shelf.ForeColor = System.Drawing.Color.White;
            this.dropDown_Shelf.Items = new string[] {
        "A1",
        "A2",
        "A3",
        "B1",
        "B2",
        "B3",
        "C1",
        "C2",
        "C3"};
            this.dropDown_Shelf.Location = new System.Drawing.Point(329, 226);
            this.dropDown_Shelf.Name = "dropDown_Shelf";
            this.dropDown_Shelf.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.dropDown_Shelf.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.dropDown_Shelf.selectedIndex = -1;
            this.dropDown_Shelf.Size = new System.Drawing.Size(77, 23);
            this.dropDown_Shelf.TabIndex = 126;
            this.dropDown_Shelf.onItemSelected += new System.EventHandler(this.dropDown_Shelf_onItemSelected);
            // 
            // panel_Library_inside
            // 
            this.panel_Library_inside.Controls.Add(this.txt_File_Name);
            this.panel_Library_inside.Controls.Add(this.label6);
            this.panel_Library_inside.Controls.Add(this.dropDown_Shelf);
            this.panel_Library_inside.Controls.Add(this.txt_Book_Id);
            this.panel_Library_inside.Controls.Add(this.dropDown_Category);
            this.panel_Library_inside.Controls.Add(this.txt_Author);
            this.panel_Library_inside.Controls.Add(this.btn_Upload);
            this.panel_Library_inside.Controls.Add(this.label7);
            this.panel_Library_inside.Controls.Add(this.btn_Generate);
            this.panel_Library_inside.Controls.Add(this.txt_Year);
            this.panel_Library_inside.Controls.Add(this.label8);
            this.panel_Library_inside.Controls.Add(this.front_image_Picture_Box);
            this.panel_Library_inside.Controls.Add(this.txt_Pages);
            this.panel_Library_inside.Controls.Add(this.label9);
            this.panel_Library_inside.Controls.Add(this.label10);
            this.panel_Library_inside.Controls.Add(this.txt_Description);
            this.panel_Library_inside.Controls.Add(this.label17);
            this.panel_Library_inside.Controls.Add(this.label11);
            this.panel_Library_inside.Controls.Add(this.txt_Date_Added);
            this.panel_Library_inside.Controls.Add(this.txt_Category);
            this.panel_Library_inside.Controls.Add(this.txt_title);
            this.panel_Library_inside.Controls.Add(this.label12);
            this.panel_Library_inside.Controls.Add(this.label5);
            this.panel_Library_inside.Controls.Add(this.txt_Publisher);
            this.panel_Library_inside.Controls.Add(this.txt_ISBN);
            this.panel_Library_inside.Controls.Add(this.label13);
            this.panel_Library_inside.Controls.Add(this.txt_Shelf);
            this.panel_Library_inside.Controls.Add(this.label14);
            this.panel_Library_inside.Enabled = false;
            this.panel_Library_inside.Location = new System.Drawing.Point(3, 3);
            this.panel_Library_inside.Name = "panel_Library_inside";
            this.panel_Library_inside.Size = new System.Drawing.Size(866, 334);
            this.panel_Library_inside.TabIndex = 127;
            // 
            // txt_File_Name
            // 
            this.txt_File_Name.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_File_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librarytableBindingSource, "image_path", true));
            this.txt_File_Name.Location = new System.Drawing.Point(10, 104);
            this.txt_File_Name.Name = "txt_File_Name";
            this.txt_File_Name.ReadOnly = true;
            this.txt_File_Name.Size = new System.Drawing.Size(178, 20);
            this.txt_File_Name.TabIndex = 127;
            this.txt_File_Name.Visible = false;
            // 
            // front_image_Picture_Box
            // 
            this.front_image_Picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.front_image_Picture_Box.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.librarytableBindingSource, "front_image", true));
            this.front_image_Picture_Box.Location = new System.Drawing.Point(5, 6);
            this.front_image_Picture_Box.Name = "front_image_Picture_Box";
            this.front_image_Picture_Box.Size = new System.Drawing.Size(186, 171);
            this.front_image_Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.front_image_Picture_Box.TabIndex = 116;
            this.front_image_Picture_Box.TabStop = false;
            // 
            // library_tableTableAdapter
            // 
            this.library_tableTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 340);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(869, 10);
            this.bunifuSeparator1.TabIndex = 131;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BtnStudentProfile
            // 
            this.BtnStudentProfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnStudentProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnStudentProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStudentProfile.BorderRadius = 0;
            this.BtnStudentProfile.ButtonText = "Reload";
            this.BtnStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudentProfile.DisabledColor = System.Drawing.Color.Gray;
            this.BtnStudentProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnStudentProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnStudentProfile.Iconimage = global::_2ndProjectSchoolMGT.Properties.Resources.Restart_48px;
            this.BtnStudentProfile.Iconimage_right = null;
            this.BtnStudentProfile.Iconimage_right_Selected = null;
            this.BtnStudentProfile.Iconimage_Selected = null;
            this.BtnStudentProfile.IconMarginLeft = 0;
            this.BtnStudentProfile.IconMarginRight = 0;
            this.BtnStudentProfile.IconRightVisible = true;
            this.BtnStudentProfile.IconRightZoom = 0D;
            this.BtnStudentProfile.IconVisible = true;
            this.BtnStudentProfile.IconZoom = 70D;
            this.BtnStudentProfile.IsTab = false;
            this.BtnStudentProfile.Location = new System.Drawing.Point(689, 350);
            this.BtnStudentProfile.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStudentProfile.Name = "BtnStudentProfile";
            this.BtnStudentProfile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnStudentProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnStudentProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnStudentProfile.selected = false;
            this.BtnStudentProfile.Size = new System.Drawing.Size(93, 33);
            this.BtnStudentProfile.TabIndex = 130;
            this.BtnStudentProfile.Text = "Reload";
            this.BtnStudentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudentProfile.Textcolor = System.Drawing.Color.White;
            this.BtnStudentProfile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // print_btn
            // 
            this.print_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.print_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print_btn.BorderRadius = 0;
            this.print_btn.ButtonText = "Print";
            this.print_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print_btn.DisabledColor = System.Drawing.Color.Gray;
            this.print_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.print_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.print_btn.Iconimage = global::_2ndProjectSchoolMGT.Properties.Resources.Print_48px;
            this.print_btn.Iconimage_right = null;
            this.print_btn.Iconimage_right_Selected = null;
            this.print_btn.Iconimage_Selected = null;
            this.print_btn.IconMarginLeft = 0;
            this.print_btn.IconMarginRight = 0;
            this.print_btn.IconRightVisible = true;
            this.print_btn.IconRightZoom = 0D;
            this.print_btn.IconVisible = true;
            this.print_btn.IconZoom = 70D;
            this.print_btn.IsTab = false;
            this.print_btn.Location = new System.Drawing.Point(782, 350);
            this.print_btn.Margin = new System.Windows.Forms.Padding(0);
            this.print_btn.Name = "print_btn";
            this.print_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.print_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.print_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.print_btn.selected = false;
            this.print_btn.Size = new System.Drawing.Size(88, 33);
            this.print_btn.TabIndex = 129;
            this.print_btn.Text = "Print";
            this.print_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print_btn.Textcolor = System.Drawing.Color.White;
            this.print_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // btn_New
            // 
            this.btn_New.ActiveBorderThickness = 1;
            this.btn_New.ActiveCornerRadius = 20;
            this.btn_New.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_New.ActiveForecolor = System.Drawing.Color.White;
            this.btn_New.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_New.BackColor = System.Drawing.SystemColors.Control;
            this.btn_New.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_New.BackgroundImage")));
            this.btn_New.ButtonText = "New";
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_New.IdleBorderThickness = 1;
            this.btn_New.IdleCornerRadius = 20;
            this.btn_New.IdleFillColor = System.Drawing.Color.White;
            this.btn_New.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_New.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_New.Location = new System.Drawing.Point(176, 664);
            this.btn_New.Margin = new System.Windows.Forms.Padding(5);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(101, 37);
            this.btn_New.TabIndex = 122;
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ActiveBorderThickness = 1;
            this.btn_Cancel.ActiveCornerRadius = 20;
            this.btn_Cancel.ActiveFillColor = System.Drawing.Color.Red;
            this.btn_Cancel.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Cancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.BackgroundImage")));
            this.btn_Cancel.ButtonText = "Cancel";
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.IdleBorderThickness = 1;
            this.btn_Cancel.IdleCornerRadius = 20;
            this.btn_Cancel.IdleFillColor = System.Drawing.Color.White;
            this.btn_Cancel.IdleForecolor = System.Drawing.Color.Red;
            this.btn_Cancel.IdleLineColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(561, 664);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(92, 38);
            this.btn_Cancel.TabIndex = 115;
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ActiveBorderThickness = 1;
            this.btn_Save.ActiveCornerRadius = 20;
            this.btn_Save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.IdleBorderThickness = 1;
            this.btn_Save.IdleCornerRadius = 20;
            this.btn_Save.IdleFillColor = System.Drawing.Color.White;
            this.btn_Save.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_Save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.Location = new System.Drawing.Point(450, 665);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(101, 37);
            this.btn_Save.TabIndex = 114;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ActiveBorderThickness = 1;
            this.btn_Edit.ActiveCornerRadius = 20;
            this.btn_Edit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.btn_Edit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Edit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.btn_Edit.IdleBorderThickness = 1;
            this.btn_Edit.IdleCornerRadius = 20;
            this.btn_Edit.IdleFillColor = System.Drawing.Color.White;
            this.btn_Edit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.btn_Edit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.btn_Edit.Location = new System.Drawing.Point(283, 664);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(113, 38);
            this.btn_Edit.TabIndex = 55;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // LibraryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 768);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.BtnStudentProfile);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.panel_Library_inside);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.Library_Data_Grid_View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryPanel";
            this.Text = "LibraryPanel";
            this.Load += new System.EventHandler(this.LibraryPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Library_Data_Grid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarytableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmgt_DataSet)).EndInit();
            this.panel_Library_inside.ResumeLayout(false);
            this.panel_Library_inside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.front_image_Picture_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid Library_Data_Grid_View;
        private System.Windows.Forms.Label label14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Shelf;
        private System.Windows.Forms.Label label13;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Publisher;
        private System.Windows.Forms.Label label12;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Category;
        private System.Windows.Forms.Label label11;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Pages;
        private System.Windows.Forms.Label label8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Year;
        private System.Windows.Forms.Label label7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Author;
        private System.Windows.Forms.Label label6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Book_Id;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_ISBN;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_Date_Added;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Save;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancel;
        private System.Windows.Forms.PictureBox front_image_Picture_Box;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_New;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Upload;
        private Bunifu.Framework.UI.BunifuDropdown dropDown_Category;
        private Bunifu.Framework.UI.BunifuDropdown dropDown_Shelf;
        private schoolmgt_DataSet schoolmgt_DataSet;
        private System.Windows.Forms.BindingSource librarytableBindingSource;
        private schoolmgt_DataSetTableAdapters.library_tableTableAdapter library_tableTableAdapter;
        private System.Windows.Forms.Panel panel_Library_inside;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_File_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateaddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton BtnStudentProfile;
        private Bunifu.Framework.UI.BunifuFlatButton print_btn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}