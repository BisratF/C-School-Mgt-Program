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
using System.Data.SqlClient;

namespace _2ndProjectSchoolMGT
{
    public partial class StudentsSchedule : Form
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        SqlConnection conn = new SqlConnection(conString);
        MySqlCommand cmd;
        public StudentsSchedule()
        {
            InitializeComponent();
            add();
        }
        private void add()
        {

            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM teachers_profile_table";

            try
            {
                con.Open();
                MySqlDataReader getter = cmd.ExecuteReader();
                teacher_combo.Items.Clear();

                while (getter.Read())
                {
                    teacher_combo.Items.Add(getter["given_name"]);
                }
                con.Close();
                string[] combo = new string[20];
                int[] index = new int[20];
                teacher_combo.Items.CopyTo(combo, index[0]);

                teacher_Drop_Down.Items = (combo);
            }
            catch
            {

            }

        }  
         
       

        private void updSecondary () // secondary teacher updater 
        {
            int row = int.Parse(secondary_row_txt.Text);
            int x = row;

            if (row % 2 != 0) // if its Odd
            {
                row.ToString();
                x = row + 1;
            }
            else if (row % 2 == 0) // if its Even
            {
                row = row - 1;
                x = row + 1;
            }
            
            string col = this.bunifuDropdown6.selectedValue.ToString();
            if (col == "Pick a Day")
            {
                bunifuDropdown6.Focus();
            }
            else
                col = col.ToLower();

            string Trow = x.ToString();
            string teacher = this.teacher_Drop_Down.selectedValue.ToString();
            string sql = string.Format("UPDATE `student_timetable` SET `{0}` = '{1}' WHERE id= {2};", col, teacher, Trow);
            MySqlCommand cmdDatabase = new MySqlCommand(sql, con);

            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmdDatabase.ExecuteReader();
                con.Close();
                

            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            }
            second();

        }


        public void updTeacher () // primary teacher updater
        {
                    int row = int.Parse(row_no_primary.Text);
                    int x = row;

                    if (row % 2 != 0) // if its Odd
                    {
                        row.ToString();
                        x = row + 1;
                    }
                    else if (row % 2 == 0) // if its Even
                    {
                        row = row - 1;
                        x = row + 1;
                    }
                string Trow = x.ToString();
                string col = this.bunifuDropdown6.selectedValue.ToString();
                if (col == "Pick a Day")
                {
                    bunifuDropdown6.Focus();
                }
                else
                    col = col.ToLower();

                string teacher = this.teacher_Drop_Down.selectedValue.ToString();
                string sql = string.Format("UPDATE `student_timetable` SET `{0}` = '{1}' WHERE id= {2};", col, teacher, Trow);
                MySqlCommand cmdDatabase = new MySqlCommand(sql, con);

                MySqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmdDatabase.ExecuteReader();
                    con.Close();
                    

                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
                primary();

            
        }
        private void StudentsSchedule_Load(object sender, EventArgs e)
        {
            primary();
            second();

        }
        private void primary()
        {
            this.new_primaryTableAdapter.Fill(this.schoolmgt_DataSet.new_primary);
            newprimaryBindingSource.DataSource = (this.schoolmgt_DataSet.new_primary);

        }
        private void second()
        {
            this.secondarystudent_timetableTableAdapter.Fill(this.schoolmgt_DataSet.secondarystudent_timetable);
            secondarystudenttimetableBindingSource.DataSource = (this.schoolmgt_DataSet.secondarystudent_timetable);
        }

        private void Update_primary()
        {
            int row = int.Parse(row_no_primary.Text);
            int x = row;
            if (row % 2 != 0) // if its Odd
            {
                row.ToString();
                x = row + 1;
            }
            else if (row % 2 == 0) // if its Even
            {
                row = row - 1;
                x = row + 1;
            }
            string Trow = x.ToString();
            string id = row.ToString();
            string sub = this.subject_dropDown.selectedValue.ToString();
                string col = this.bunifuDropdown6.selectedValue.ToString();
                if (col == "Pick a Day")
                 {
                bunifuDropdown6.Focus();
                 }
                else
                col = col.ToLower();
            string sql = string.Format("UPDATE `student_timetable` SET `{0}` = '{1}' WHERE id= {2};", col, sub, id);
            MySqlCommand cmdDatabase = new MySqlCommand(sql, con);
            
                MySqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmdDatabase.ExecuteReader();
                    con.Close();
                
               
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            updTeacher();
            
        }
           
        
        private void update_secondary()
        {  
                  

            int row = int.Parse(secondary_row_txt.Text);
            int x = row;
            if (row % 2 != 0) // if its Odd
            {
                row.ToString();
                x = row + 1;
            }
            else if (row % 2 == 0) // if its Even
            {
                row = row - 1;
                x = row + 1;
            }
            string Trow = x.ToString();
            string id = row.ToString();
            string col = this.bunifuDropdown6.selectedValue.ToString();
            if (col == "Pick a Day")
            {
                bunifuDropdown6.Focus();
            }
            else
                col = col.ToLower();
                 string sub = this.subject_dropDown.selectedValue.ToString();
                string sql = string.Format("UPDATE `student_timetable` SET `{0}` = '{1}'WHERE id = {2};",col, sub, id);
                MySqlCommand cmdDatabase = new MySqlCommand(sql, con);
                MySqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmdDatabase.ExecuteReader();
                    con.Close();
                   
                    
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message);
                }
            updSecondary();
            
            }
        


        public void Apply_btn_Click(object sender, EventArgs e)
        {
            if (grade_Drop_Down.selectedIndex == 0)
            {
                Update_primary();
               string update = "Secondary school students Schedule has been updated";
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
            else if (grade_Drop_Down.selectedIndex == 1)
            {
                update_secondary();
                string update = "Primary school students Schedule has been updated";
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

        private void DataGridShower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = new_primary_GridView.CurrentCell.ColumnIndex;
            switch (index)
            {
                case 3:
                    bunifuDropdown6.selectedIndex = 1;
                    break;
                case 4:
                    bunifuDropdown6.selectedIndex = 2;
                    break;
                case 5:
                    bunifuDropdown6.selectedIndex = 3;
                    break;
                case 6:
                    bunifuDropdown6.selectedIndex = 4;
                    break;
                case 7:
                    bunifuDropdown6.selectedIndex = 5;
                    break;
               default:
                    bunifuDropdown6.selectedIndex = 0;
                    break;
            }
        }

        private void value_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown6_onItemSelected(object sender, EventArgs e)
        {
            int index = new_primary_GridView.CurrentCell.ColumnIndex;

        }

        private void grade_Drop_Down_onItemSelected(object sender, EventArgs e)
        {
            if (grade_Drop_Down.selectedIndex == 1)
            {
                secondary_gridView.BringToFront();
            }
            else
                new_primary_GridView.BringToFront(); }

        private void teacher_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void secondary_row_txt_TextChanged(object sender, EventArgs e)
        {

               
        }

        private void row_no_primary_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void teacher_Drop_Down_onItemSelected(object sender, EventArgs e)
        {
            

        }

        private void secondary_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void secondary_gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Sindex = secondary_gridView.CurrentCell.ColumnIndex;
            Console.WriteLine(Sindex);

            switch (Sindex)
            {
                case 3:
                    bunifuDropdown6.selectedIndex = 1;
                    break;
                case 4:
                    bunifuDropdown6.selectedIndex = 2;
                    break;
                case 5:
                    bunifuDropdown6.selectedIndex = 3;
                    break;
                case 6:
                    bunifuDropdown6.selectedIndex = 4;
                    break;
                case 7:
                    bunifuDropdown6.selectedIndex = 5;
                    break;
                default:
                    bunifuDropdown6.selectedIndex = 0;
                    break;
            }
        }
    }
}
