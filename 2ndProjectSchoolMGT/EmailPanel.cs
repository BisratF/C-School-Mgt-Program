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
using S22.Imap;
using MySql.Data.MySqlClient;

namespace _2ndProjectSchoolMGT
{
    public partial class EmailPanel : UserControl
    {
        static string conString = "server=localhost;user id=root;password=root;database=schoolmgtdb";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand command = new MySqlCommand();

        public static EmailPanel _instance;
      public  static EmailPanel SomeEmailPanel;
    
        public static EmailPanel ShowOff
        {
            get { 
                if (_instance == null)
                _instance = new EmailPanel();
            return _instance;
            }
        }



        public EmailPanel()
        {
            InitializeComponent();
            SomeEmailPanel = this;
        }

        private void CommunPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            var message = new MailMessage(SenderMailAdd.Text, recieverMailAdd.Text);


            message.Subject = subBox.Text;
            message.Body = messegeBody.Text;
            if (attachBox.Text != "")
            {
                message.Attachments.Add(new Attachment(attachBox.Text));
            }
            using (SmtpClient theMailer = new SmtpClient("smtp.gmail.com", 587))   // check with this code using (ImapClient Client = new ImapClient("imap.gmail.com", 993, true))  
            {
                theMailer.Credentials = new NetworkCredential(SenderMailAdd.Text, senderPassword.Text);
                theMailer.EnableSsl = true;
                theMailer.Send(message);

                MessageBox.Show("Messege sent was successul");
            }

            string update = "Message has been sent to " + message;
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
            
            SenderMailAdd.Text = null;
            // recieverMailAdd.Text = null;
            subBox.Text = null;
            messegeBody.Text = null;
            attachBox.Text = null;
        }

        private void RecieveBtn_Click(object sender, EventArgs e)
        {
            startRecieving();
        }
        //SenderMailAdd.Text
        private void startRecieving()
        {
           
           
            Task.Run(() =>
            {

                using (ImapClient client = new ImapClient("imap.gmail.com", 993, SenderMailAdd.Text, senderPassword.Text, AuthMethod.Login, true))
                {
                    if (client.Supports("Idle") == false)
                    {
                        MessageBox.Show("server error");
                        return;
                    }

                    client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNewMessage);
                    while (true) ;

                }
            
                
            });

           
        } // end of startRecieving class 

        public void newComing ()
        {
            string update = "you have a new email";
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




        static void OnNewMessage(object sender, IdleMessageEventArgs e)
        {
            MessageBox.Show("New message recieved");
            SomeEmailPanel.newComing();
            MailMessage Mmessage = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
            SomeEmailPanel.Invoke((MethodInvoker)delegate

            {
                SomeEmailPanel.inboxPanel.AppendText("From: " + Mmessage.From + "\r\n" +
                                                     "Subject: " + Mmessage.Subject + "\r\n" +
                                                      "Body: " + Mmessage.Body + "\r\n" +
                                                      "Attachment : " + Mmessage.Attachments + "\r\n");
            });

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
           if (openFileDialog2.ShowDialog () == DialogResult.OK)
            {
                attachBox.Text = openFileDialog2.FileName.ToString();
            }  
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
