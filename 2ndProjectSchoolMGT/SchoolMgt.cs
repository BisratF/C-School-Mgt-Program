using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _2ndProjectSchoolMGT
{
    public partial class SchoolMgt : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private const int SnapDist = 100;

        Color ButtonColor = Color.FromArgb(74, 156, 222);
        Color TransColor = Color.FromArgb(37, 54, 71);


   

        public SchoolMgt()
        {
            InitializeComponent();
    
        }
        private bool DoSnap(int pos, int edge)
        {
            int delta = pos - edge;
            return delta > 0 && delta <= SnapDist;
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            Screen scn = Screen.FromPoint(this.Location);
            if (DoSnap(this.Left, scn.WorkingArea.Left)) this.Left = scn.WorkingArea.Left;
            if (DoSnap(this.Top, scn.WorkingArea.Top)) this.Top = scn.WorkingArea.Top;
            if (DoSnap(scn.WorkingArea.Right, this.Right)) this.Left = scn.WorkingArea.Right - this.Width;
            if (DoSnap(scn.WorkingArea.Bottom, this.Bottom)) this.Top = scn.WorkingArea.Bottom - this.Height;
        }




        private void Form1_Load(object sender, EventArgs e)
        {


            DashLoad();

        }

         private void DashLoad ()
        {
            DashBoardForm DashForm = new DashBoardForm();
            DashForm.TopLevel = false;
            DashForm.FormBorderStyle = FormBorderStyle.None;
            DashForm.WindowState = FormWindowState.Maximized;
            // DashForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(DashForm);
            DashForm.Show();
        }
     

        private void bunifuFlatButton1_Click(object sender, EventArgs e)   // DashBoard Button
        {

            DashLoad();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)  // Admin  Button 
        {
            AdminPanel DashForm = new AdminPanel();
            DashForm.TopLevel = false;
            DashForm.FormBorderStyle = FormBorderStyle.None;
            DashForm.WindowState = FormWindowState.Maximized;
            //DashForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(DashForm);
            DashForm.Show();
            

        }
        
        private void bunifuFlatButton4_Click(object sender, EventArgs e)   // Teachers Button 
        {
            TeachersProfile tf = new TeachersProfile();
            tf.TopLevel = false;
            tf.FormBorderStyle = FormBorderStyle.None;
            tf.WindowState = FormWindowState.Maximized;
            CenterPanel.Controls.Add(tf);
            tf.Show();
           
         

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)   // mini btn
        {
           if( this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                
            }
           else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)     //Maximize btn 
        {
           

    /*      if (  WindowState == FormWindowState.Normal)
            {
               
               WindowState = FormWindowState.Maximized;
               
            }
          else if (WindowState == FormWindowState.Maximized)
            {

               
                WindowState = FormWindowState.Normal;
            }
*/
        }




        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
       /*     if (_dragging)
                {

                Point P = PointToScreen(e.Location);
                Location = new Point(P.X - this._start_point.X, P.Y - this._start_point.Y);
                  

                 } */
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        /*    _dragging = true;
            _start_point = new Point(e.X, e.Y); */
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)    // Students Button
        {
            StudentsPanel DashForm = new StudentsPanel();
            DashForm.TopLevel = false;
            DashForm.FormBorderStyle = FormBorderStyle.None;
            DashForm.WindowState = FormWindowState.Maximized;
            //DashForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(DashForm);
            DashForm.Show();

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)   // Library Button 
        {
            LibraryPanel DashForm = new LibraryPanel();
            DashForm.TopLevel = false;
            DashForm.FormBorderStyle = FormBorderStyle.None;
            DashForm.WindowState = FormWindowState.Maximized;
            //DashForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(DashForm);
            DashForm.Show();

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)   // Parents Button
        {
            ParentsPanel DashForm = new ParentsPanel();
            DashForm.TopLevel = false;
            DashForm.FormBorderStyle = FormBorderStyle.None;
            DashForm.WindowState = FormWindowState.Maximized;
           // DashForm.Dock = DockStyle.Fill;
            CenterPanel.Controls.Add(DashForm);
            DashForm.Show();

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        /*    if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            } */
        }

        private void panel1_Click(object sender, EventArgs e)
        {
          /*  if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }    */
            
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
    



        }




           }
}
