using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;


namespace _2ndProjectSchoolMGT
{
    public partial class SMSPanel : UserControl
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand command = new MySqlCommand();
        DataTable someTable = new DataTable();
        MySqlDataAdapter adp;
        public static SMSPanel _instance;
        public static SMSPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SMSPanel();
                 }
                return _instance;
            }
        }


        public SMSPanel()
        {
            InitializeComponent();
        }

        private void SMSPanel_Load(object sender, EventArgs e)
        {
           // DataSearch("");
        }
        
        private void SendBtn_Click(object sender, EventArgs e)
        {
            string to, from, mess, pass;
            MailMessage message = new MailMessage();
            to = (txtPhone.Text).ToString() +"@txtlocal.co.uk";
            from = "forsm.sen@gmail.com";                       
            mess = (messegeBody.Text).ToString();
            pass = "zipzapzip";                        
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mess;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("message is sent", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string update = "Message has been sent to " + to;
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

       
        public void DataSearch (string searchValue)
        {
            string x = drop_down_search.selectedValue.ToString();
            Console.WriteLine(x);
            switch (x)
            {
                case "Parents":
                    string query ="SELECT * FROM student_profile WHERE CONCAT (`number`, `sir_name`, `given_name`,`contact_one`, `relation`, `emerg_contact` ) like '%" + searchValue + "%'";
                    command = new MySqlCommand(query, con);
                    adp = new MySqlDataAdapter(command);
                    someTable = new DataTable();
                    adp.Fill(someTable);
                    search_grid_view.DataSource = someTable;
                    string[] col = { "number", "student_id", "post_code", "street", "flatorhouse", "email", "dob", "registered_date", "profile_picture", "picture_path", "index" };
                    search_grid_view.DataSource = someTable;
                    foreach (string colNames in col)
                    {
                        search_grid_view.Columns.Remove(colNames);
                    }
                    Console.WriteLine("Case parents in doing it ");
                    break;

                case "Students":
                    string Squery = "SELECT * FROM student_profile WHERE CONCAT (`sir_name`, `given_name`,`contact_one`, `relation`, `emerg_contact` ) like '%" + searchValue + "%'";
                    command = new MySqlCommand(Squery, con);
                    adp = new MySqlDataAdapter(command);
                    someTable = new DataTable();
                    adp.Fill(someTable);
                    // DataView dtv = new DataView(someTable);
                    // someTable = dtv.ToTable(true, "sir_name");
                    string[] colS = { "number","sex", "student_id", "post_code", "street", "flatorhouse", "email", "dob", "registered_date", "profile_picture", "picture_path", "index" };
                    search_grid_view.DataSource = someTable;
                    foreach (string colNames in colS)
                    {
                       search_grid_view.Columns.Remove(colNames);
                    }
                    Console.WriteLine("Case Students in doing it ");
                    break;
                case "Teachers":
                    string Tquery = "SELECT * FROM teachers_profile_table WHERE CONCAT (`number`, `sir_name`, `given_name`,`phone_no`, `emergency_contact` ) like '%" + searchValue + "%'";
                    command = new MySqlCommand(Tquery, con);
                    adp = new MySqlDataAdapter(command);
                    someTable = new DataTable();
                    adp.Fill(someTable);
                    string[] colT = { "number","teacher_id", "postcode", "street", "flatorhouse", "email", "dob", "qualification","level","levl_index","employment","E_index", "employment_date", "basic_salary", "profile_picture", "payroll_number"};
                    search_grid_view.DataSource = someTable;
                    foreach (string colNames in colT)
                    {
                        search_grid_view.Columns.Remove(colNames);
                    }
                    search_grid_view.DataSource = someTable;
                    Console.WriteLine("Case Teachrs in doing it ");
                    break;
            }
          /*  string xquery = string.Format ("SELECT * FROM student_profile WHERE CONCAT (`number`, `sir_name`, `given_name`,`contact_one`, `relation`, `emerg_contact` ) like '%" + searchValue + "'");
                    command = new MySqlCommand(xquery, con);
                    adp = new MySqlDataAdapter(command);
                    someTable = new DataTable();
                    adp.Fill(someTable);
                    // DataView dtv = new DataView(someTable);
                    // someTable = dtv.ToTable(true, "sir_name");
                    search_grid_view.DataSource = someTable;
              switch (x)

           {
               case "Teachers":
                   string t = "teachers_profile";
                   from = t;
                   request = "`number`, `sir_name`, `given_name`,`phone_no`,`emerg_contact` ";
                   break;
               case "Students":
                   string s = "students_profile";
                   from = s;
                   request = "`number`, `sir_name`, `given_name`,`contact_one`, `relation`, `emerg_contact` ";
                   break;
               case "Parents":
                   string p = "students_profile";
                   from = p;
                   request = "`number`, `sir_name`, `given_name`,`contact_one`, `relation`, `emerg_contact` ";
                   break;
           }
           //  string sql = string.Format("UPDATE `student_timetable` SET `{0}` = '{1}' WHERE id= {2};", col, teacher, Trow);
           //string searchValue = search_txt.text.ToString();
           string que = string.Format("SELECT * FROM '{0}' WHERE CONCAT('{1}') like '%" '{2}';" from,request);
           */

        }
        private void Search_btn_Click(object sender, EventArgs e)
        {   
            
            string searchValue = search_txt.text.ToString();
            DataSearch(searchValue);
        }

    }
}
