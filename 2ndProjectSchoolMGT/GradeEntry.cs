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
    public partial class GradeEntry : Form
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        private bool dragg = false;
        //  private Point _offset;
        private Point start_point = new Point(0, 0);

        public GradeEntry()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragg)
            {

                Point P = PointToScreen(e.Location);
                Location = new Point(P.X - this.start_point.X, P.Y - this.start_point.Y);


            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragg = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragg = true;
            start_point = new Point(e.X, e.Y);

        }

        private void GradeEntry_Load(object sender, EventArgs e)
        {
            
            caller();
       
        }
        private void caller ()
        {

            var opt = txt_Student_Grade.Text.ToString();
            int x = opt.Count();
            switch (x)
            {
                case 3:
                    all();
                    Primary_groupbox.Enabled = false;
                    Primary_groupbox.Show();
                    Primary_groupbox.BringToFront();
                    update_primary.Hide();
                    update_secondary.Hide();
                    break;
                case 7:
                    primary();
                   // Secondary_groupBox.Hide();
                    Primary_groupbox.Enabled = true;
                    Primary_groupbox.BringToFront();
                  //  update_secondary.Hide();
                    update_primary.Show();
                    update_primary.BringToFront();
                    break;
                case 9:
                    secondaryGrade();
                    Primary_groupbox.Hide();
                    Secondary_groupBox.Show();
                    Secondary_groupBox.BringToFront();
                    update_primary.Hide();
                    update_secondary.Show();
                    update_secondary.BringToFront();
                    break;
                default :
                    all();
                    Primary_groupbox.Enabled = false;
                    Primary_groupbox.Show();
                    Primary_groupbox.BringToFront();
                    update_primary.Hide();
                    update_secondary.Hide();
                    break;
            }

        }  
         private void all()
        {
            this.mistoTableAdapter.Fill(this.schoolmgt_DataSet.Misto);
            mistoBindingSource.DataSource = (this.schoolmgt_DataSet.Misto);
            Misto_GridView.BringToFront();
        }

        private void primary()
        {
            this.gradeprimarytableTableAdapter.Fill(this.schoolmgt_DataSet.grade_primary_table);
            gradeprimarytableBindingSource.DataSource = (this.schoolmgt_DataSet.grade_primary_table);
            primary_DataGrid.BringToFront();
        }
        private void secondaryGrade()
        {
            this.secondary.Fill(this.schoolmgt_DataSet.secondary_table);
            secondarytableBindingSource.DataSource = (this.schoolmgt_DataSet.secondary_table);
            Secondary_DataGrid.BringToFront();
        }
        private void Apply_btn_Click(object sender, EventArgs e)
        {

            //caller();

        }

        private void grade_drodown_onItemSelected(object sender, EventArgs e)
        {
           
        }

        private void txt_Student_Grade_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txt_Student_Grade_TextChanged_1(object sender, EventArgs e)
        {
            var grade = txt_Student_Grade.Text.ToString();
            int x = grade.Count();
            switch (x)
            {
                case 0:
                    bunifuDropdown1.selectedIndex = 2;
                    break;
                case 7:
                    bunifuDropdown1.selectedIndex = 0;
                    break;
                case 9:
                    bunifuDropdown1.selectedIndex = 1;
                    break;
            }
        }
        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            var grade = bunifuDropdown1.selectedValue.ToString();
            txt_Student_Grade.Text = grade;
            
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            caller();
        }

        private void Assingment_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mid_term_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void final_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void over_all_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_primary_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Assingment_txt.Text);
            double y = double.Parse(mid_term_txt.Text);
            double z = double.Parse(final_txt.Text);
            double result = x + y + z;
            over_all_txt.Text = result.ToString();
        }

        private void calculate_secondary_Click(object sender, EventArgs e)
        {
            double x = double.Parse(assignment_secondary_txt.Text);
            double y = double.Parse(mid_term_secondary_txt.Text);
            double z = double.Parse(final_secondary_txt.Text);
            double result = x + y + z;
            overall_secondary_txt.Text = result.ToString();
        }

        private void loader ()
        {

        }
        private void update_primary_Click(object sender, EventArgs e)
        {
            string UpdateQuery = "UPDATE schoolmgtdb.grade_entry SET assignment = '" + this.Assingment_txt.Text + "',mid_term='" + this.mid_term_txt.Text + "',final='" + this.final_txt.Text + "',over_all='"+this.over_all_txt.Text+ "'WHERE grade_number='" + this.row_txt_box.Text + "';";

            MySqlCommand cmdDatabase = new MySqlCommand(UpdateQuery, con);
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

        private void update_secondary_Click(object sender, EventArgs e)
        {
            string UpdateQuery = "UPDATE schoolmgtdb.grade_entry SET assignment = '" + this.assignment_secondary_txt.Text + "',mid_term='" + this.mid_term_secondary_txt.Text + "',final='" + this.final_secondary_txt.Text + "',over_all='" + this.overall_secondary_txt.Text + "'WHERE grade_number='" + this.row_txt_secondary.Text + "';";

            MySqlCommand cmdDatabase = new MySqlCommand(UpdateQuery, con);
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
            secondaryGrade();

        }
    }
}
