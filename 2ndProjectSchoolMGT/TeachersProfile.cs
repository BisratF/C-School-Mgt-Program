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
    public partial class TeachersProfile : Form
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        string dob, emp,empEdit,dobEdited,fileName;
        DateTime date,hired;
        public TeachersProfile()
        {
            InitializeComponent();
        }
       
        private void TeachersProfile_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'schoolmgt_DataSet.teachers_profile_table' table. You can move, or remove it, as needed.
            this.teachers_profile_tableTableAdapter.Fill(this.schoolmgt_DataSet.teachers_profile_table);
            teachersprofiletableBindingSource.DataSource = (this.schoolmgt_DataSet.teachers_profile_table);

          //  this.pay_roll_tableTableAdapter.Fill(this.schoolmgt_DataSet.pay_roll_table);
          //  this.payrolltableBindingSource.DataSource = (this.schoolmgt_DataSet.pay_roll_table);
            level_txt.BringToFront();
            Sex_txt.BringToFront();
            DOB_txt.BringToFront();
            employment_Date_txt.BringToFront();
            employment_txt.BringToFront();

        }

        private void Add_Teacher_btn_Click(object sender, EventArgs e)
        {
            panel_teachers.Enabled = true;
            sir_Name_txt.Focus();
            DataGridViewRow row = (DataGridViewRow)teachers_Profile_Table_Grid_view.Rows[0].Clone();
            
            row.Cells[4].Value = "ID";
            string IdCell = id_txt.Text.ToString();

            if (IdCell.Count() > 0)
            {
                try
                {

                    this.schoolmgt_DataSet.teachers_profile_table.Addteachers_profile_tableRow(this.schoolmgt_DataSet.teachers_profile_table.Newteachers_profile_tableRow());
                    teachersprofiletableBindingSource.MoveLast();

                    Dob_Datepicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    Employment_Datepicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string update = "a new teacher has been registerd";
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
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            panel_teachers.Enabled = true;
            sir_Name_txt.Focus();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            var check = id_txt.Text.ToString();
            if (check == "1")
            {
                MessageBox.Show("Please generate teacher id");
             
            }
               
          else
            {
                try
                {
                    this.teachersprofiletableBindingSource.EndEdit();
                    teachers_profile_tableTableAdapter.Update(this.schoolmgt_DataSet.teachers_profile_table);
                    panel_teachers.Enabled = false;
                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            teachersprofiletableBindingSource.ResetBindings(false);
            panel_teachers.Enabled = false;
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    txt_picture_path.Text = fileName;
                    profile_picture.Image = Image.FromFile(fileName);
                }
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

     

        private void generate_btn_Click(object sender, EventArgs e)
        {
            var y = order_txt.Text.ToString();


            if (Given_Name_txt.Text.Count() >= 2)
            {
                var x = Given_Name_txt.Text.Substring(0, 2);
                id_txt.Text = x + dobEdited + y;
            }
            else
                id_txt.Text = dobEdited + y;

        }
        private void Employment_Dropdown_onItemSelected(object sender, EventArgs e)
        {
            var emp = Employment_Dropdown.selectedValue.ToString();
            employment_txt.Text = emp;
            int x = Employment_Dropdown.selectedIndex;
            e_index_txt.Text = x.ToString();
        }
        private void employment_txt_TextChanged(object sender, EventArgs e)
        {
            var emp = employment_txt.Text.ToString();
            if (emp.Count() == 0)
            {
                Employment_Dropdown.selectedIndex = 0;

            }
            else if (Employment_Dropdown.selectedIndex == 0)
            {
                employment_txt.Text = "";
            }
        }
        private void e_index_txt_TextChanged(object sender, EventArgs e)
        {
            var insideString = e_index_txt.Text.ToString();
            if (insideString.Count() != 0)
            {
                int p = int.Parse(insideString);
                int x = int.Parse(e_index_txt.Text);
                Employment_Dropdown.selectedIndex = p;

            }
        }

        private void drop_down_Sex_onItemSelected(object sender, EventArgs e)
        {
            var sex = drop_down_Sex.selectedValue.ToString();
            if (sex.Count() > 0)
            {
               Sex_txt.Text = sex;
            }
            else if (sex.Count() == 8)
            {
                Sex_txt.Text = "";
            }
        }

        private void Sex_txt_TextChanged(object sender, EventArgs e)
        {
            var sex = Sex_txt.Text.ToString();
            int count = sex.Count();

            switch (count)
            {
                case 4:
                    drop_down_Sex.selectedIndex = 0;
                    break;
                case 6:
                    drop_down_Sex.selectedIndex = 1;
                    break;
                default:
                    drop_down_Sex.selectedIndex = 2;
                    break;
            }

        }

        private void Level_DropDown_onItemSelected(object sender, EventArgs e)
        {
            var relation = Level_DropDown.selectedValue.ToString();
              level_txt.Text = relation;
            int x = Level_DropDown.selectedIndex;
            levl_index_txt.Text = x.ToString();
        }

        private void level_txt_TextChanged(object sender, EventArgs e)
        {
            var rel = level_txt.Text.ToString();
            if (rel.Count() == 0)
            {
                Level_DropDown.selectedIndex = 0;

            }
            else if (Level_DropDown.selectedIndex == 0)
            {
                level_txt.Text = "";
            }
        }

        private void panel_teachers_EnabledChanged(object sender, EventArgs e)
        {
            if (panel_teachers.Enabled == false)
            {
                level_txt.BringToFront();
                Sex_txt.BringToFront();
                DOB_txt.BringToFront();
                employment_Date_txt.BringToFront();
                employment_txt.BringToFront();
            }
            else if (panel_teachers.Enabled == true)
            {
                Level_DropDown.BringToFront();
                drop_down_Sex.BringToFront();
                Dob_Datepicker.BringToFront();
                Employment_Dropdown.BringToFront();
                Employment_Datepicker.BringToFront();
                if (DOB_txt.Text.Length >= 4)
                {
                    int pre = 2016;
                    var vale = DOB_txt.Text.Substring(DOB_txt.Text.Length - 4);
                    int ye = int.Parse(vale);

                    if ((Given_Name_txt.Text.Count() > 0) && (ye < pre))
                    {
                        generate_btn.Enabled = true;

                    }

                }
            }

        }

        private void teachers_Profile_Table_Grid_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are  you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    teachersprofiletableBindingSource.RemoveCurrent();
                    string update = "a record has been deleted from teachers profile";
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
            }
        }

        private void levl_index_txt_TextChanged(object sender, EventArgs e)
        {
            var insideString = levl_index_txt.Text.ToString();
            if (insideString.Count() != 0)
            {
                int p = int.Parse(insideString);
                int x = int.Parse(levl_index_txt.Text);
                Level_DropDown.selectedIndex = p;

            }
        }

        private void Dob_Datepicker_onValueChanged(object sender, EventArgs e)
        {
              dob = Dob_Datepicker.Value.ToString("dd-MMM-yyyy");
              dobEdited = Dob_Datepicker.Value.ToString("ddMMyy");
              DOB_txt.Text = dob;
        }

        private void DOB_txt_TextChanged(object sender, EventArgs e)
        {
            if (DOB_txt.Text.Count() > 0)
            {
                date = DateTime.Parse(DOB_txt.Text);
                Dob_Datepicker.Value = date;
            }
        }

        private void Employment_Datepicker_onValueChanged(object sender, EventArgs e)
        {
            emp = Employment_Datepicker.Value.ToString("dd-MMM-yyyy");
            empEdit = Employment_Datepicker.Value.ToString("ddMMyy");
            employment_Date_txt.Text = emp;
        }

        private void employment_Date_txt_TextChanged(object sender, EventArgs e)
        {
            if (employment_Date_txt.Text.Count() > 0)
            {
                hired = DateTime.Parse(employment_Date_txt.Text);
                Employment_Datepicker.Value = hired;
            }
        }
    }

    }

