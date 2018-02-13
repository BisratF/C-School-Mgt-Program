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
    public partial class ParentsPanel : Form
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand command = new MySqlCommand();
        DataTable someTable = new DataTable();
        MySqlDataAdapter adp;
        public ParentsPanel()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtParentSearch_OnTextChange(object sender, EventArgs e)
        {
          //  txtParentSearch.Clear();

        }

        private void ParentsPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolmgt_DataSet.student_profile' table. You can move, or remove it, as needed.
            this.student_profileTableAdapter.Fill(this.schoolmgt_DataSet.student_profile);
            studentprofileBindingSource.DataSource = (this.schoolmgt_DataSet.student_profile);
        }
        public void DataSearch(string searchValue)
        {
            string query = "SELECT * FROM student_profile WHERE CONCAT (`number`, `sir_name`, `given_name`,`contact_one`, `relation`, `emerg_contact` ) like '%" + searchValue + "%'";
            command = new MySqlCommand(query, con);
            adp = new MySqlDataAdapter(command);
            someTable = new DataTable();
            adp.Fill(someTable);
            search_grid_view.DataSource = someTable;
        
        }
        public void getNumber ()
        {
            int index = search_grid_view.CurrentCell.RowIndex;
            string q = "SELECT contact_one FROM students_profile WHERE number=" + index +"'";
            command = new MySqlCommand(q, con);
            adp = new MySqlDataAdapter(command);
            MySqlDataReader reader;
            reader = command.ExecuteReader();
            reader.Read();
            
              string phoneNo = reader.ToString();
            
            Console.WriteLine(phoneNo);
        }
        private void search_btn_Click(object sender, EventArgs e)
        {

            string searchValue = Parent_Search_txt.text.ToString();
            DataSearch(searchValue);
            this.student_profileTableAdapter.Fill(this.schoolmgt_DataSet.student_profile);



        }

        private void search_grid_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = search_grid_view.CurrentCell.ColumnIndex;
            string indx = index.ToString();

          
            
            
            
            
            
            
            
            
            
            
            
            /*    string q = "SELECT contact_one FROM student_profile WHERE number = '" + indx + "'";
            command = new MySqlCommand(q, con);
            adp = new MySqlDataAdapter(command);
            MySqlDataReader reader;

            con.Open();
            reader = command.ExecuteReader();
            //reader.Read();
            while (reader.Read())
            {
                justholer.Text = reader.Read(["phone_no"]);
              // Console.WriteLine(phoneNo);
            }
            

            
            con.Close();*/
        }
    }
}
