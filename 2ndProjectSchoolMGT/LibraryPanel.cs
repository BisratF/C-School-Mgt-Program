using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace _2ndProjectSchoolMGT
{
    public partial class LibraryPanel : Form
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand command = new MySqlCommand();
        string fileName;
     
        public LibraryPanel()
        {
            InitializeComponent();
        }
        private void LibraryPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolmgt_DataSet.library_table' table. You can move, or remove it, as needed.
            this.library_tableTableAdapter.Fill(this.schoolmgt_DataSet.library_table);
            librarytableBindingSource.DataSource = this.schoolmgt_DataSet.library_table;
           // panel_Library_inside.Enabled = false;
        }
        

        //  string result = txt_title.Text.Substring(0, 3);

        private void dropDown_Category_onItemSelected(object sender, EventArgs e)
        {
            var category = dropDown_Category.selectedValue.ToString();
            txt_Category.Text = category;
        }

        private void dropDown_Shelf_onItemSelected(object sender, EventArgs e)
        {
            var shelf = dropDown_Shelf.selectedValue.ToString();
            txt_Shelf.Text = shelf;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            
            try
            {
                panel_Library_inside.Enabled = true;
                txt_title.Focus();
                this.schoolmgt_DataSet.library_table.Addlibrary_tableRow(this.schoolmgt_DataSet.library_table.Newlibrary_tableRow());
               
                librarytableBindingSource.MoveLast();
                var day = DateTime.Now.ToShortDateString();;
                txt_Date_Added.Text = day;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string update = "a new book has been added to library database";
            string Query = "insert into schoolmgtdb.notice_table(notice) values ('" + update + "');";
            MySqlCommand cmdDatabase = new MySqlCommand(Query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmdDatabase.ExecuteReader();
                // MessageBox.Show("lets see");

                con.Close();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            }












        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            panel_Library_inside.Enabled = true;
            txt_title.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (schoolmgt_DataSet ds = new schoolmgt_DataSet())
            {

            }


            try
            {
                librarytableBindingSource.EndEdit();
                library_tableTableAdapter.Update(this.schoolmgt_DataSet.library_table);
                panel_Library_inside.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            panel_Library_inside.Enabled = false;
            librarytableBindingSource.ResetBindings(false);
            
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG",ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    txt_File_Name.Text = fileName;
                    front_image_Picture_Box.Image = Image.FromFile(fileName);
                }
            }
        }
        byte [] ConvertImageToBinary (Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void Library_Data_Grid_View_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show("Are  you sure you want to delete this record?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                  
                    librarytableBindingSource.RemoveCurrent();
                    
                }
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        { string titl;
            var today = DateTime.Now.ToString("HHmmss");
            var getter = txt_title.Text.Count();
            if (getter < 3)
            {
                switch (getter)
                {
                    case 1:
                        titl = txt_title.Text.Substring(0, 1);
                        txt_Book_Id.Text = titl + today;
                        break;
                    case 2:
                        titl = txt_title.Text.Substring(0, 2);
                        txt_Book_Id.Text = titl + today;
                        break;
                   default:
                        titl = txt_title.Text;
                        txt_Book_Id.Text = titl + today;
                        break;
                }
             }
            else
                txt_Book_Id.Text = txt_title.Text.Substring(0, 3) + today;
            
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
              printDocument1.DocumentName = "test Page Print";
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {  
            Bitmap bm = new Bitmap(this.Library_Data_Grid_View.Width, this.Library_Data_Grid_View.Height);

            Library_Data_Grid_View.DrawToBitmap(bm, new Rectangle(0, 0, this.Library_Data_Grid_View.Width, this.Library_Data_Grid_View.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
