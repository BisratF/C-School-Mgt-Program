namespace _2ndProjectSchoolMGT
{
    partial class EmailPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailPanel));
            this.CommunPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RecieveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.inboxPanel = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.attachBox = new System.Windows.Forms.TextBox();
            this.subBox = new System.Windows.Forms.TextBox();
            this.recieverMailAdd = new System.Windows.Forms.TextBox();
            this.SenderMailAdd = new System.Windows.Forms.TextBox();
            this.senderPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SendBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.messegeBody = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.CommunPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommunPanel
            // 
            this.CommunPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CommunPanel.Controls.Add(this.groupBox2);
            this.CommunPanel.Controls.Add(this.groupBox1);
            this.CommunPanel.Controls.Add(this.label5);
            this.CommunPanel.Location = new System.Drawing.Point(3, 3);
            this.CommunPanel.Name = "CommunPanel";
            this.CommunPanel.Size = new System.Drawing.Size(948, 649);
            this.CommunPanel.TabIndex = 5;
            this.CommunPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CommunPanel_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RecieveBtn);
            this.groupBox2.Controls.Add(this.inboxPanel);
            this.groupBox2.Location = new System.Drawing.Point(460, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 497);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inbox";
            // 
            // RecieveBtn
            // 
            this.RecieveBtn.ActiveBorderThickness = 1;
            this.RecieveBtn.ActiveCornerRadius = 20;
            this.RecieveBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.RecieveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.RecieveBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.RecieveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecieveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecieveBtn.BackgroundImage")));
            this.RecieveBtn.ButtonText = "Refreash";
            this.RecieveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecieveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecieveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.RecieveBtn.IdleBorderThickness = 1;
            this.RecieveBtn.IdleCornerRadius = 20;
            this.RecieveBtn.IdleFillColor = System.Drawing.Color.White;
            this.RecieveBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.RecieveBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.RecieveBtn.Location = new System.Drawing.Point(124, 447);
            this.RecieveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RecieveBtn.Name = "RecieveBtn";
            this.RecieveBtn.Size = new System.Drawing.Size(110, 35);
            this.RecieveBtn.TabIndex = 13;
            this.RecieveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecieveBtn.Click += new System.EventHandler(this.RecieveBtn_Click);
            // 
            // inboxPanel
            // 
            this.inboxPanel.BorderColor = System.Drawing.Color.SeaGreen;
            this.inboxPanel.Location = new System.Drawing.Point(29, 23);
            this.inboxPanel.Multiline = true;
            this.inboxPanel.Name = "inboxPanel";
            this.inboxPanel.Size = new System.Drawing.Size(343, 401);
            this.inboxPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAttach);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.attachBox);
            this.groupBox1.Controls.Add(this.subBox);
            this.groupBox1.Controls.Add(this.recieverMailAdd);
            this.groupBox1.Controls.Add(this.SenderMailAdd);
            this.groupBox1.Controls.Add(this.senderPassword);
            this.groupBox1.Controls.Add(this.SendBtn);
            this.groupBox1.Controls.Add(this.messegeBody);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 497);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(342, 239);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 20;
            this.btnAttach.Text = "Attach File";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Attach";
            // 
            // attachBox
            // 
            this.attachBox.Location = new System.Drawing.Point(74, 241);
            this.attachBox.Name = "attachBox";
            this.attachBox.Size = new System.Drawing.Size(253, 20);
            this.attachBox.TabIndex = 18;
            // 
            // subBox
            // 
            this.subBox.Location = new System.Drawing.Point(74, 203);
            this.subBox.Name = "subBox";
            this.subBox.Size = new System.Drawing.Size(191, 20);
            this.subBox.TabIndex = 16;
            // 
            // recieverMailAdd
            // 
            this.recieverMailAdd.Location = new System.Drawing.Point(90, 128);
            this.recieverMailAdd.Name = "recieverMailAdd";
            this.recieverMailAdd.Size = new System.Drawing.Size(167, 20);
            this.recieverMailAdd.TabIndex = 15;
            // 
            // SenderMailAdd
            // 
            this.SenderMailAdd.Location = new System.Drawing.Point(90, 35);
            this.SenderMailAdd.Name = "SenderMailAdd";
            this.SenderMailAdd.Size = new System.Drawing.Size(167, 20);
            this.SenderMailAdd.TabIndex = 14;
            this.SenderMailAdd.Text = "habesha45@gmail.com";
            // 
            // senderPassword
            // 
            this.senderPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.senderPassword.Location = new System.Drawing.Point(90, 84);
            this.senderPassword.Name = "senderPassword";
            this.senderPassword.PasswordChar = '*';
            this.senderPassword.Size = new System.Drawing.Size(167, 20);
            this.senderPassword.TabIndex = 13;
            // 
            // SendBtn
            // 
            this.SendBtn.ActiveBorderThickness = 1;
            this.SendBtn.ActiveCornerRadius = 20;
            this.SendBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SendBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendBtn.BackgroundImage")));
            this.SendBtn.ButtonText = "Send";
            this.SendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.IdleBorderThickness = 1;
            this.SendBtn.IdleCornerRadius = 20;
            this.SendBtn.IdleFillColor = System.Drawing.Color.White;
            this.SendBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SendBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SendBtn.Location = new System.Drawing.Point(90, 447);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(110, 35);
            this.SendBtn.TabIndex = 12;
            this.SendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // messegeBody
            // 
            this.messegeBody.BorderColor = System.Drawing.Color.SeaGreen;
            this.messegeBody.Location = new System.Drawing.Point(53, 295);
            this.messegeBody.Multiline = true;
            this.messegeBody.Name = "messegeBody";
            this.messegeBody.Size = new System.Drawing.Size(254, 122);
            this.messegeBody.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sender Email\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Body";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recipient: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // EmailPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CommunPanel);
            this.Name = "EmailPanel";
            this.Size = new System.Drawing.Size(954, 655);
            this.CommunPanel.ResumeLayout(false);
            this.CommunPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CommunPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 RecieveBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox inboxPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox attachBox;
        private System.Windows.Forms.TextBox subBox;
        private System.Windows.Forms.TextBox recieverMailAdd;
        private System.Windows.Forms.TextBox SenderMailAdd;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox senderPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 SendBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox messegeBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
