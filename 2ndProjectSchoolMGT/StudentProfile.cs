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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace _2ndProjectSchoolMGT
{
    public partial class StudentProfile : Form
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
       
        DateTime date;
        string dob;
        string dobEdited;
        string fileName;
        public StudentProfile()

        {
            InitializeComponent();
         
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolmgt_DataSet2.grade_entry' table. You can move, or remove it, as needed.
            


            // TODO: This line of code loads data into the 'schoolmgt_DataSet.student_profile' table. You can move, or remove it, as needed.
            this.student_profileTableAdapter.Fill(this.schoolmgt_DataSet.student_profile);
            this.studentprofileBindingSource.DataSource = (this.schoolmgt_DataSet.student_profile);

            schoolmgt_DataSet.EnforceConstraints = false;
            this.grade_entryTableAdapter.Fill(this.schoolmgt_DataSet.grade_entry);
            this.gradeentryBindingSource.DataSource = (this.schoolmgt_DataSet.grade_entry);


            txt_Relation.BringToFront();
            txt_Student_Sex.BringToFront();
            txt_Dob.BringToFront();
            txt_Student_Grade.BringToFront();
        }

        private void Btn_Add_Student_Click(object sender, EventArgs e)
        {

              
            try
            {
                
                student_Profile_Panel.Enabled = true;
                string newStudent = "new student has been registered";
                txt_Student_sir_name.Focus();
                this.schoolmgt_DataSet.student_profile.Addstudent_profileRow(this.schoolmgt_DataSet.student_profile.Newstudent_profileRow());
                studentprofileBindingSource.MoveLast();
                string Query = "insert into schoolmgtdb.grade_entry(grade_number) values('" + this.txt_number.Text + "');" +
                               "insert into schoolmgtdb.dayly_attendance(id_att) values('" + this.txt_number.Text + "');" +
                               "insert into schoolmgtdb.notice_table(notice) values ('" + newStudent + "');";
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


               // this.schoolmgt_DataSet.grade_entry.Addgrade_entryRow(this.schoolmgt_DataSet.grade_entry.Newgrade_entryRow());
              //  this.gradeentryBindingSource.MoveLast();
                var now = DateTime.Now.ToString("dd-MMM-yyy");
                txt_Student_Registered_Date.Text = now;
                bunifu_Datepicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            student_Profile_Panel.Enabled = true;
            txt_Student_sir_name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {  


                this.studentprofileBindingSource.EndEdit();
                student_profileTableAdapter.Update(this.schoolmgt_DataSet.student_profile);

                // this.gradeentryBindingSource.EndEdit();

                

                this.grade_entryTableAdapter.Update(this.schoolmgt_DataSet.grade_entry);
              
                student_Profile_Panel.Enabled = false;
                //  bunifu_Datepicker

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            studentprofileBindingSource.ResetBindings(false);
            student_Profile_Panel.Enabled = false;
        }

        private void grade_DropDown_onItemSelected(object sender, EventArgs e)
        {
            var grade = grade_DropDown.selectedValue.ToString();
            if (grade.Contains("Grade"))
            {
                txt_Student_Grade.Text = "";
            }
            else
                txt_Student_Grade.Text = grade;
        }

        private void drop_down_Sex_onItemSelected(object sender, EventArgs e)
        {
            var sex = drop_down_Sex.selectedValue.ToString();
            if(sex.Count()>0)
            {
                txt_Student_Sex.Text = sex;
            }
            else if (sex.Count() == 8)
            {
                txt_Student_Sex.Text = "";
            }

        }

        private void txt_Student_Sex_TextChanged(object sender, EventArgs e)
        {
            var sex = txt_Student_Sex.Text.ToString();
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

        private void txt_Student_Grade_TextChanged(object sender, EventArgs e)
        {
            var grade = txt_Student_Grade.Text.ToString();
            int x = grade.Count();
            switch (x)
            {
                case 0:
                    grade_DropDown.selectedIndex = 2;
                    break;
                case 7:
                    grade_DropDown.selectedIndex = 0;
                    break;
                case 9:
                    grade_DropDown.selectedIndex = 1;
                    break;
            }
        }


        private void bunifu_Datepicker_onValueChanged(object sender, EventArgs e)
        {
            dob = bunifu_Datepicker.Value.ToString("dd-MMM-yyyy");
            dobEdited = bunifu_Datepicker.Value.ToString("ddMMyy");
            txt_Dob.Text = dob;
        }

        private void txt_Dob_TextChanged(object sender, EventArgs e)
        {
            if (txt_Dob.Text.Count() > 0)
            {
                date = DateTime.Parse(txt_Dob.Text);
                bunifu_Datepicker.Value = date;
            }

        }
        private void btn_Student_Generate_Click(object sender, EventArgs e)
        {
            var y = txt_number.Text.ToString();


            if (txt_Student_given_Name.Text.Count() >= 2)
            {
                var x = txt_Student_given_Name.Text.Substring(0, 2);
                txt_Student_Id.Text = x + dobEdited + y;
            }
            else
                txt_Student_Id.Text = dobEdited + y;
        }

        private void btn_Student_Upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    txt_picture_path.Text = fileName;
                    student_Picture_Box.Image = Image.FromFile(fileName);
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

        private void txt_Student_Registered_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_Table_Grid_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are  you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    studentprofileBindingSource.RemoveCurrent();

                }
            }
        }



        private void Relation_DropDown_onItemSelected(object sender, EventArgs e)
        {
            var relation = Relation_DropDown.selectedValue.ToString();
            txt_Relation.Text = relation;
            int x = Relation_DropDown.selectedIndex;
            txt_index_holder.Text = x.ToString();
        }

        private void txt_Relation_TextChanged(object sender, EventArgs e)
        {
              var rel = txt_Relation.Text.ToString();
            if(rel.Count() == 0)
            {
               Relation_DropDown.selectedIndex = 0;
                
            } else if (Relation_DropDown.selectedIndex == 0)
            {
                txt_Relation.Text = "";
            }
            
        }

        private void txt_index_holder_TextChanged(object sender, EventArgs e)
        {
            var insideString = txt_index_holder.Text.ToString();
            if (insideString.Count() != 0)
            {
               int p = int.Parse(insideString);
                    int x  = int.Parse(txt_index_holder.Text);
                    Relation_DropDown.selectedIndex = p;
                
            }
        }

        private void student_Profile_Panel_Enter(object sender, EventArgs e)
        {
           
        }

        private void student_Profile_Panel_EnabledChanged(object sender, EventArgs e)
        {
            if (student_Profile_Panel.Enabled == false)
            {
                txt_Relation.BringToFront();
                txt_Student_Sex.BringToFront();
                txt_Dob.BringToFront();
                txt_Student_Grade.BringToFront();
            }
            else if (student_Profile_Panel.Enabled == true)
            {
                Relation_DropDown.BringToFront();
                drop_down_Sex.BringToFront();
                bunifu_Datepicker.BringToFront();
                grade_DropDown.BringToFront();
            }
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txt_number.Text);
            clone_txt.Text = id.ToString();
            
        }
    }
}
