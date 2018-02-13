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
using Tulpep.NotificationWindow;

namespace _2ndProjectSchoolMGT
{
    public partial class DashBoardForm : Form
    {
       
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        
        DataTable table = new DataTable();
       // DateTime today = new DateTime();

        public DashBoardForm()
        {
            InitializeComponent();
            teachers();
            library();
            primary();
            Secondary();
            Absents();
            Filler(); 
        }
        private void Filler ()
        {
        /*    today = DateTime.Now;
            string day = today.ToString("yyyy-MM-dd");
            string hour = today.ToString("HH:mm");


          //  string request = "SELECT FROM event_table Where 'reminder_date'='" + hour + "';";
            MySqlCommand cmd = new MySqlCommand(request, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                con.Close();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            } */



        }
        
        private void notifier ()
        {   


            PopupNotifier notice = new PopupNotifier();
           // notice.ContentText = 
        }


        private void DashBoardForm_LOad(object sender, EventArgs e)
        {
           
        }
        private void new_btn_Click(object sender, EventArgs e)
        {
            


        }

        private void save_btn_Click(object sender, EventArgs e)
        {
          //  table.Rows.Add(event_titile.Text, message_txt.Text);
            //event_titile.Clear();
          //  message_txt.Clear();

        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            //int index = GridView.CurrentCell.RowIndex;
          //  if (index > -1)
            {
             //   event_titile.Text = table.Rows[index].ItemArray[0].ToString();
               // message_txt.Text = table.Rows[index].ItemArray[1].ToString();
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //int index = GridView.CurrentCell.RowIndex;
          //  table.Rows[index].Delete();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            RichTextBox rich = new RichTextBox();
        }

        private void DashBoardForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolmgt_DataSet.notice_table' table. You can move, or remove it, as needed.
            this.notice_tableTableAdapter.Fill(this.schoolmgt_DataSet.notice_table);
            noticetableBindingSource.DataSource = (this.schoolmgt_DataSet.notice_table);
            // TODO: This line of code loads data into the 'schoolmgt_DataSet.event_table' table. You can move, or remove it, as needed.
            this.event_tableTableAdapter.Fill(this.schoolmgt_DataSet.event_table);
            eventtableBindingSource.DataSource = (this.schoolmgt_DataSet.event_table);
        }
        private void teachers()
        {

            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM teachers_profile_table", con))
                try
                {
                    con.Open();
                    // MySqlDataReader getter = cmd.ExecuteReader();
                    long count = (long)cmd.ExecuteScalar();
                    string some = count.ToString();
                    teachers_lable.Text = some;
                    con.Close();
                }
                catch
                {
                }
        }
        private void library()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM library_table", con))
                try
                {
                    con.Open();
                    // MySqlDataReader getter = cmd.ExecuteReader();
                    long count = (long)cmd.ExecuteScalar();
                    string some = count.ToString();
                    Library_link.Text = some;
                    con.Close();
                }
                catch
                {
                }
        }
        private void primary()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM student_profile WHERE grade = 'Primary'", con))
                try
                {
                    con.Open();
                    // MySqlDataReader getter = cmd.ExecuteReader();
                    long count = (long)cmd.ExecuteScalar();
                    string some = count.ToString();
                    primary_lable.Text = some;
                    con.Close();
                }
                catch
                {
                }
        }

        private void Secondary()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM student_profile WHERE grade = 'Secondary'", con))
                try
                {
                    con.Open();
                    // MySqlDataReader getter = cmd.ExecuteReader();
                    long count = (long)cmd.ExecuteScalar();
                    string some = count.ToString();
                    secondary_lable.Text = some;
                    con.Close();
                }
                catch
                {
                }
        }
        private void Absents()
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM dayly_attendance WHERE present = 'Absent'", con))
                try
                {
                    con.Open();
                    // MySqlDataReader getter = cmd.ExecuteReader();
                    long count = (long)cmd.ExecuteScalar();
                    string some = count.ToString();
                    absent_lable.Text = some;
                    con.Close();
                }
                catch
                {
                }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void richBox_MouseMove(object sender, MouseEventArgs e)
        {
         /*   if (_dragging)
            {

                Point P = PointToScreen(e.Location);
                Location = new Point(P.X - this._start_point.X, P.Y - this._start_point.Y);

            }*/
        }

        private void richBox_MouseDown(object sender, MouseEventArgs e)
        {
          /*  _dragging = true;
            _start_point = new Point(e.X, e.Y); */
        }

        private void richBox_MouseUp(object sender, MouseEventArgs e)
        {
            //_dragging = false;
        }

        private void event_titile_MouseEnter(object sender, EventArgs e)
        {

           // saver();
            /*  if ((event_titile.Text == "Add Event here....") || (event_titile.Text == "Add Event "))
            {
                event_titile.ResetText();
            }*/
        }

        private void event_titile_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            event_titile.ResetText();
            event_titile.Text = "Add Event here....";
            message_txt.Clear();
         
            this.schoolmgt_DataSet.event_table.Addevent_tableRow(this.schoolmgt_DataSet.event_table.Newevent_tableRow());
            eventtableBindingSource.MoveLast();
            int x = Event_table.Height;
            Event_table.Height = x + 10;
        }

        private void Event_table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // saver();
        }
        private void saver()
        {
            eventtableBindingSource.EndEdit();
            event_tableTableAdapter.Update(this.schoolmgt_DataSet.event_table);
        }
        
        private void save_event_Click(object sender, EventArgs e)
        {

            saver();
            // eventtableBindingSource.EndEdit();
            //event_tableTableAdapter.Update(this.schoolmgt_DataSet.event_table);
        }
        private void refresh ()
        {
            
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 300000;
            timer1.Tick += new System.EventHandler(timer1_Tick);
        }
        private void timer1_Tick (Object sender,EventArgs e)
        {
            refresh();
            this.notice_tableTableAdapter.Fill(this.schoolmgt_DataSet.notice_table);
        }

        private void Event_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             string mirror = this.mirror_txt.Text.ToString();
             event_titile.Text = mirror.ToUpper();
        }

        private void event_titile_OnValueChanged(object sender, EventArgs e)
        {
            string mirror = this.event_titile.Text.ToString();
            mirror_txt.Text = mirror.ToUpper();
        }

        private void mirror_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void even_date_picker_onValueChanged(object sender, EventArgs e)
        {
            string day = even_date_picker.Value.ToString("dd-MMM-yyyy");
            string format = even_date_picker.Value.ToString("yyyy-MM-dd");
            //date_adder_txt.Text = day;
            format_txt.Text = format;
            string eventName = event_titile.Text;
            message_txt.Text = eventName +" "+ "is scheduled for " + day;
        }

        private void delet_event_btn_Click(object sender, EventArgs e)
        {
            eventtableBindingSource.RemoveCurrent();
            int x = Event_table.Height;
            Event_table.Height = x-10;
        }

        private void format_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void message_txt_TextChanged(object sender, EventArgs e)
        {
           // saver();
        }

        private void date_adder_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reminder_datePicker_onValueChanged(object sender, EventArgs e)
        {
          //  date_adder_txt.Text = reminder_datePicker.Value.ToString("dd-MMM-yyyy");
          //  time_format_txt.Text = reminder_datePicker.Value.ToString("yyyy-MM-dd");
        }

        private void drop_down_hr_onItemSelected(object sender, EventArgs e)
        {
          //  var x = drop_down_hr.selectedValue.ToString();
           // time_picker_txt.Text = x.ToString();
        }

        private void event_titile_MouseLeave(object sender, EventArgs e)
        {
          //  saver();
        }
    }
}
