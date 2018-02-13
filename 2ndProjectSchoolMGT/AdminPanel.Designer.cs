namespace _2ndProjectSchoolMGT
{
    partial class AdminPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.CommuniationPanel = new System.Windows.Forms.Panel();
            this.Changable_panel = new System.Windows.Forms.Panel();
            this.BtnPayroll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnComm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EmailBtnChange = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnSMS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reports_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CommuniationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Location = new System.Drawing.Point(3, 34);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(869, 628);
            this.MainPanel.TabIndex = 6;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 94);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(872, 10);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // CommuniationPanel
            // 
            this.CommuniationPanel.Controls.Add(this.EmailBtnChange);
            this.CommuniationPanel.Controls.Add(this.BtnSMS);
            this.CommuniationPanel.Controls.Add(this.MainPanel);
            this.CommuniationPanel.Controls.Add(this.reports_btn);
            this.CommuniationPanel.Location = new System.Drawing.Point(-1, 107);
            this.CommuniationPanel.Name = "CommuniationPanel";
            this.CommuniationPanel.Size = new System.Drawing.Size(872, 657);
            this.CommuniationPanel.TabIndex = 16;
            // 
            // Changable_panel
            // 
            this.Changable_panel.Location = new System.Drawing.Point(2, 107);
            this.Changable_panel.Name = "Changable_panel";
            this.Changable_panel.Size = new System.Drawing.Size(869, 654);
            this.Changable_panel.TabIndex = 17;
            // 
            // BtnPayroll
            // 
            this.BtnPayroll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnPayroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPayroll.BorderRadius = 0;
            this.BtnPayroll.ButtonText = "Time Table";
            this.BtnPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPayroll.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPayroll.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPayroll.Iconimage = global::_2ndProjectSchoolMGT.Properties.Resources.attendance;
            this.BtnPayroll.Iconimage_right = null;
            this.BtnPayroll.Iconimage_right_Selected = null;
            this.BtnPayroll.Iconimage_Selected = null;
            this.BtnPayroll.IconMarginLeft = 0;
            this.BtnPayroll.IconMarginRight = 0;
            this.BtnPayroll.IconRightVisible = true;
            this.BtnPayroll.IconRightZoom = 0D;
            this.BtnPayroll.IconVisible = true;
            this.BtnPayroll.IconZoom = 75D;
            this.BtnPayroll.IsTab = true;
            this.BtnPayroll.Location = new System.Drawing.Point(713, 60);
            this.BtnPayroll.Name = "BtnPayroll";
            this.BtnPayroll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnPayroll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnPayroll.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPayroll.selected = false;
            this.BtnPayroll.Size = new System.Drawing.Size(158, 41);
            this.BtnPayroll.TabIndex = 12;
            this.BtnPayroll.Text = "Time Table";
            this.BtnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPayroll.Textcolor = System.Drawing.Color.White;
            this.BtnPayroll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayroll.Click += new System.EventHandler(this.BtnPayroll_Click);
            // 
            // BtnComm
            // 
            this.BtnComm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnComm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnComm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnComm.BorderRadius = 0;
            this.BtnComm.ButtonText = "Communication";
            this.BtnComm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComm.DisabledColor = System.Drawing.Color.Gray;
            this.BtnComm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnComm.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnComm.Iconimage = global::_2ndProjectSchoolMGT.Properties.Resources.icons8_Collaboration_96px;
            this.BtnComm.Iconimage_right = null;
            this.BtnComm.Iconimage_right_Selected = null;
            this.BtnComm.Iconimage_Selected = null;
            this.BtnComm.IconMarginLeft = 0;
            this.BtnComm.IconMarginRight = 0;
            this.BtnComm.IconRightVisible = true;
            this.BtnComm.IconRightZoom = 0D;
            this.BtnComm.IconVisible = true;
            this.BtnComm.IconZoom = 70D;
            this.BtnComm.IsTab = true;
            this.BtnComm.Location = new System.Drawing.Point(564, 60);
            this.BtnComm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.BtnComm.Name = "BtnComm";
            this.BtnComm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnComm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnComm.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnComm.selected = false;
            this.BtnComm.Size = new System.Drawing.Size(158, 41);
            this.BtnComm.TabIndex = 9;
            this.BtnComm.Text = "Communication";
            this.BtnComm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComm.Textcolor = System.Drawing.Color.White;
            this.BtnComm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComm.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // EmailBtnChange
            // 
            this.EmailBtnChange.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.EmailBtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.EmailBtnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmailBtnChange.BorderRadius = 0;
            this.EmailBtnChange.ButtonText = "Email";
            this.EmailBtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailBtnChange.DisabledColor = System.Drawing.Color.Gray;
            this.EmailBtnChange.Iconcolor = System.Drawing.Color.Transparent;
            this.EmailBtnChange.Iconimage = global::_2ndProjectSchoolMGT.Properties.Resources.Gmail_96px;
            this.EmailBtnChange.Iconimage_right = null;
            this.EmailBtnChange.Iconimage_right_Selected = null;
            this.EmailBtnChange.Iconimage_Selected = null;
            this.EmailBtnChange.IconMarginLeft = 0;
            this.EmailBtnChange.IconMarginRight = 0;
            this.EmailBtnChange.IconRightVisible = true;
            this.EmailBtnChange.IconRightZoom = 0D;
            this.EmailBtnChange.IconVisible = true;
            this.EmailBtnChange.IconZoom = 65D;
            this.EmailBtnChange.IsTab = true;
            this.EmailBtnChange.Location = new System.Drawing.Point(3, 5);
            this.EmailBtnChange.Name = "EmailBtnChange";
            this.EmailBtnChange.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.EmailBtnChange.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.EmailBtnChange.OnHoverTextColor = System.Drawing.Color.White;
            this.EmailBtnChange.selected = false;
            this.EmailBtnChange.Size = new System.Drawing.Size(104, 31);
            this.EmailBtnChange.TabIndex = 13;
            this.EmailBtnChange.Text = "Email";
            this.EmailBtnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmailBtnChange.Textcolor = System.Drawing.Color.White;
            this.EmailBtnChange.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBtnChange.Click += new System.EventHandler(this.EmailBtnChange_Click);
            // 
            // BtnSMS
            // 
            this.BtnSMS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnSMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSMS.BorderRadius = 0;
            this.BtnSMS.ButtonText = "SMS";
            this.BtnSMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSMS.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSMS.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSMS.Iconimage = global::_2ndProjectSchoolMGT.Properties.Resources.SMS_96px;
            this.BtnSMS.Iconimage_right = null;
            this.BtnSMS.Iconimage_right_Selected = null;
            this.BtnSMS.Iconimage_Selected = null;
            this.BtnSMS.IconMarginLeft = 0;
            this.BtnSMS.IconMarginRight = 0;
            this.BtnSMS.IconRightVisible = true;
            this.BtnSMS.IconRightZoom = 0D;
            this.BtnSMS.IconVisible = true;
            this.BtnSMS.IconZoom = 65D;
            this.BtnSMS.IsTab = true;
            this.BtnSMS.Location = new System.Drawing.Point(106, 5);
            this.BtnSMS.Name = "BtnSMS";
            this.BtnSMS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.BtnSMS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.BtnSMS.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSMS.selected = false;
            this.BtnSMS.Size = new System.Drawing.Size(88, 31);
            this.BtnSMS.TabIndex = 14;
            this.BtnSMS.Text = "SMS";
            this.BtnSMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSMS.Textcolor = System.Drawing.Color.White;
            this.BtnSMS.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSMS.Click += new System.EventHandler(this.BtnSMS_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.reports_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.reports_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reports_btn.BorderRadius = 0;
            this.reports_btn.ButtonText = "Report";
            this.reports_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports_btn.DisabledColor = System.Drawing.Color.Gray;
            this.reports_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.reports_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reports_btn.Iconimage")));
            this.reports_btn.Iconimage_right = null;
            this.reports_btn.Iconimage_right_Selected = null;
            this.reports_btn.Iconimage_Selected = null;
            this.reports_btn.IconMarginLeft = 0;
            this.reports_btn.IconMarginRight = 0;
            this.reports_btn.IconRightVisible = true;
            this.reports_btn.IconRightZoom = 0D;
            this.reports_btn.IconVisible = true;
            this.reports_btn.IconZoom = 75D;
            this.reports_btn.IsTab = true;
            this.reports_btn.Location = new System.Drawing.Point(184, 18);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.reports_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.reports_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reports_btn.selected = false;
            this.reports_btn.Size = new System.Drawing.Size(10, 10);
            this.reports_btn.TabIndex = 10;
            this.reports_btn.Text = "Report";
            this.reports_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports_btn.Textcolor = System.Drawing.Color.White;
            this.reports_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_btn.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 768);
            this.Controls.Add(this.BtnPayroll);
            this.Controls.Add(this.BtnComm);
            this.Controls.Add(this.CommuniationPanel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Changable_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.Text = "pa";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.CommuniationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuFlatButton BtnComm;
        private Bunifu.Framework.UI.BunifuFlatButton reports_btn;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPayroll;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton EmailBtnChange;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSMS;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel CommuniationPanel;
        private System.Windows.Forms.Panel Changable_panel;
    }
}