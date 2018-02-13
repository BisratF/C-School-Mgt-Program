using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2ndProjectSchoolMGT
{
    public partial class AttendanceForm : Form
    {
       static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        private Point start_point = new Point(0, 0);
        
        public AttendanceForm()
        {
            InitializeComponent();
            today();
           
        }
        public void filler()
        {
            try
            {
                con.Open();
               // string SelectQuery = "SELECT  dayly_attendance.id_att, student_profile.sir_name, student_profile.given_name, student_profile.student_id, dayly_attendance.day, dayly_attendance.class, dayly_attendance.present, dayly_attendance.late, dayly_attendance.absent,dayly_attendance.remarks FROM dayly_attendance INNER JOIN student_profile ON dayly_attendance.id_att = student_profile.number";

                string q = "SELECT  student_profile.sir_name, student_profile.given_name, student_profile.student_id, dayly_attendance.id_att, dayly_attendance.day, dayly_attendance.class, dayly_attendance.present, dayly_attendance.late, dayly_attendance.absent, dayly_attendance.remarks, student_profile.number FROM student_profile INNER JOIN dayly_attendance ON student_profile.number = dayly_attendance.id_att";

                MySqlCommand cmdSelectDatabase = new MySqlCommand(q, con);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmdSelectDatabase);

                adap.Fill(this.schoolmgt_DataSet.dayly_attendance);
                
                GridView.DataSource = this.schoolmgt_DataSet.dayly_attendance;
               // MessageBox.Show("lets see");
                con.Close();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            }
        }

        public void refresh()
        {
            this.student_attendanceTableAdapter.Fill(this.schoolmgt_DataSet.student_attendance);
            studentattendanceBindingSource.DataSource = (this.schoolmgt_DataSet.student_attendance);

        }



        private void AttendaneCenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            this.student_attendanceTableAdapter.Fill(this.schoolmgt_DataSet.student_attendance);
            studentattendanceBindingSource.DataSource = (this.schoolmgt_DataSet.student_attendance);

           
        }

        private void amClicked(object sender, EventArgs e)
        {
            P.Checked = true;
            A.Checked = false;
            L.Checked = false;
            attendance_txt.Text = "Present";today();
            
        }
        private void A_Clicked(object sender, EventArgs e)
        {
            P.Checked = false;
            A.Checked = true;
            L.Checked = false;
            attendance_txt.Text = "Absent"; today();
        }
        private void L_cliked(object sender, EventArgs e)
        {
            P.Checked = false;
            A.Checked = false;
            L.Checked = true;
            attendance_txt.Text = "Late"; today();
        }
        private void today ()
        {
          
            today_dropdown.Value = DateTime.Now;
            var today = DateTime.Now.ToString("yyyy-MM-dd");
            date_txt.Text = today;
        } 
        private void apply_btn_Click(object sender, EventArgs e)
        {

                string UpdateQuery = "UPDATE schoolmgtdb.dayly_attendance SET remarks = '" + this.remarks_txt.Text + "',day='"+this.date_txt.Text+"',present='"+this.attendance_txt.Text+ "'WHERE id_att='" + this.row_txt.Text + "';";
                                   
                MySqlCommand cmdDatabase = new MySqlCommand(UpdateQuery, con);
                MySqlDataReader reader;
               try
                {
                    con.Open();
                    today();
                    reader = cmdDatabase.ExecuteReader();
                    con.Close();
                                          
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }

            refresh();
        }

        private void row_txt_TextChanged(object sender, EventArgs e)
        {
            P.Checked = false; A.Checked = false; L.Checked = false;
        }

        private void attendance_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void date_txt_TextChanged(object sender, EventArgs e)
        {
          if(date_txt.Text.Count() < 0)
            {
                var today = today_dropdown.Value.ToString("dd-MMM-yyyy");
                date_txt.Text = today.ToString();
            }

        }

        private void today_dropdown_onValueChanged(object sender, EventArgs e)
        {
          //  date_txt.Text = today.ToString();

        }
    }
}
