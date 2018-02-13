using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;


namespace _2ndProjectSchoolMGT
{
    public partial class AdminPanel : Form
    {
       
       
        StudentsSchedule SC = new StudentsSchedule();
        public AdminPanel()
        {
            InitializeComponent();
         

        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            CommuniationPanel.BringToFront();
            MainPanel.Controls.Add(EmailPanel.ShowOff);
            EmailPanel.ShowOff.Dock = DockStyle.Fill;
            EmailPanel.ShowOff.BringToFront();
            EmailBtnChange.Normalcolor = Color.FromArgb(74, 165, 222);
            BtnComm.Normalcolor = Color.FromArgb(74, 165, 222);
        }

        public void MainPanel_Paint(object sender, PaintEventArgs e)
        {
          /*  CommuniationPanel.BringToFront();
            MainPanel.Controls.Add(EmailPanel.ShowOff);
            EmailPanel.ShowOff.Dock = DockStyle.Fill;
            EmailPanel.ShowOff.BringToFront();
            EmailBtnChange.Normalcolor = Color.FromArgb(74, 165, 222);
            BtnComm.Normalcolor = Color.FromArgb(74, 165, 222);  */
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)   // Send Btn
        {
        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)  // recieve Btn

        {
           
        }
        
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)  // browse 
        {
          
        }

        private void browseBtn(object sender, EventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            
        }

        private void EmailBtnChange_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(EmailPanel.ShowOff))
            {
                MainPanel.Controls.Add(EmailPanel.ShowOff);
                EmailPanel.ShowOff.Dock = DockStyle.Fill;
                EmailPanel.ShowOff.BringToFront();
            }
            else
            { EmailPanel.ShowOff.BringToFront(); }  
          
        }

        private void BtnSMS_Click(object sender, EventArgs e)
        {
            EmailBtnChange.Normalcolor = Color.FromArgb(37, 54, 71);
           if (!MainPanel.Controls.Contains(SMSPanel.Instance))
            {
                MainPanel.Controls.Add(SMSPanel.Instance);
                SMSPanel.Instance.Dock = DockStyle.Fill;
                SMSPanel.Instance.BringToFront();
            }
            else
            { SMSPanel.Instance.BringToFront(); }  
           
        }

        private void BtnPayroll_Click(object sender, EventArgs e)  // payroll panel 
        {
            
            BtnComm.Normalcolor = Color.FromArgb(37, 54, 71);
            //
         //   Changable_panel.Controls.Remove(reports);
            SC.TopLevel = false;
            SC.FormBorderStyle = FormBorderStyle.None;
             SC.WindowState = FormWindowState.Maximized;
            Changable_panel.Controls.Add(SC);
            Changable_panel.BringToFront();
            
            SC.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) // communication panel
        {
         
            MainPanel.Controls.Add(EmailPanel.ShowOff);
            EmailPanel.ShowOff.Dock = DockStyle.Fill;
            EmailPanel.ShowOff.BringToFront();
            CommuniationPanel.BringToFront();



        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)  // Reports Panel 
        {
            BtnComm.Normalcolor = Color.FromArgb(37,54,71);
            Changable_panel.Controls.Remove(SC);
          //  Changable_panel.Controls.Add(reports);
            Changable_panel.BringToFront();
            //reports.Show();
        }

       
    }
}
