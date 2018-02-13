using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ndProjectSchoolMGT
{
    public partial class StudentsPanel : Form
    {
        StudentProfile stupro = new StudentProfile();
        public StudentsPanel()
        {
            InitializeComponent();
        }
        private void CenterStudentPanel_Paint(object sender, PaintEventArgs e)
        {
           
                
        }
        private void StudentsPanel_Load(object sender, EventArgs e)
        {
            BtnStudentProfile.Normalcolor = Color.FromArgb(74, 165, 222);
            stupro.TopLevel = false;
            stupro.FormBorderStyle = FormBorderStyle.None;
            stupro.WindowState = FormWindowState.Maximized;
            CenterStudentPanel.Controls.Add(stupro);
            stupro.Show();
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)  // time table btn
        {
           
        }

        private void BtnStudentProfile_Click(object sender, EventArgs e)
        {
            stupro.BringToFront();
        }

        private void BtnAttendance_Click(object sender, EventArgs e)
        {
            BtnStudentProfile.Normalcolor = Color.FromArgb(37,54,71);

            AttendanceForm Attendance = new AttendanceForm();
            Attendance.TopLevel = false;
            Attendance.FormBorderStyle = FormBorderStyle.None;
            Attendance.WindowState = FormWindowState.Maximized;
            CenterStudentPanel.Controls.Add(Attendance);
            Attendance.Show();

        }

        private void BtnGradeEntry_Click(object sender, EventArgs e)
        {
            BtnStudentProfile.Normalcolor = Color.FromArgb(37, 54, 71);
            GradeEntry gradeentry = new GradeEntry();
            gradeentry.TopLevel = false;
            gradeentry.FormBorderStyle = FormBorderStyle.None;
            gradeentry.WindowState = FormWindowState.Maximized;
            CenterStudentPanel.Controls.Add(gradeentry);
            gradeentry.Show();
        }

       

        private void BtnIDCard_Click(object sender, EventArgs e)
        {
           


        }

       
    }
}
