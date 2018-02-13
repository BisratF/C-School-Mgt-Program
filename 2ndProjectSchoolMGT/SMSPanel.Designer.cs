namespace _2ndProjectSchoolMGT
{
    partial class SMSPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SMSINsidePanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Search_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.search_grid_view = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.search_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SendBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.messegeBody = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drop_down_search = new Bunifu.Framework.UI.BunifuDropdown();
            this.SMSINsidePanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_grid_view)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SMSINsidePanel
            // 
            this.SMSINsidePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SMSINsidePanel.Controls.Add(this.groupBox2);
            this.SMSINsidePanel.Controls.Add(this.groupBox1);
            this.SMSINsidePanel.Controls.Add(this.label5);
            this.SMSINsidePanel.Location = new System.Drawing.Point(0, 0);
            this.SMSINsidePanel.Name = "SMSINsidePanel";
            this.SMSINsidePanel.Size = new System.Drawing.Size(857, 601);
            this.SMSINsidePanel.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drop_down_search);
            this.groupBox2.Controls.Add(this.Search_btn);
            this.groupBox2.Controls.Add(this.search_grid_view);
            this.groupBox2.Controls.Add(this.search_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(397, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 496);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search ";
            // 
            // Search_btn
            // 
            this.Search_btn.ActiveBorderThickness = 1;
            this.Search_btn.ActiveCornerRadius = 20;
            this.Search_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Search_btn.ActiveForecolor = System.Drawing.Color.White;
            this.Search_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Search_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_btn.BackgroundImage")));
            this.Search_btn.ButtonText = "Search";
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Search_btn.IdleBorderThickness = 1;
            this.Search_btn.IdleCornerRadius = 20;
            this.Search_btn.IdleFillColor = System.Drawing.Color.White;
            this.Search_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Search_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Search_btn.Location = new System.Drawing.Point(260, 91);
            this.Search_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(110, 35);
            this.Search_btn.TabIndex = 20;
            this.Search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // search_grid_view
            // 
            this.search_grid_view.AllowUserToAddRows = false;
            this.search_grid_view.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_grid_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.search_grid_view.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.search_grid_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_grid_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.search_grid_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.search_grid_view.ColumnHeadersHeight = 36;
            this.search_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.search_grid_view.DoubleBuffered = true;
            this.search_grid_view.EnableHeadersVisualStyles = false;
            this.search_grid_view.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.search_grid_view.HeaderForeColor = System.Drawing.Color.White;
            this.search_grid_view.Location = new System.Drawing.Point(0, 154);
            this.search_grid_view.Name = "search_grid_view";
            this.search_grid_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.search_grid_view.RowHeadersVisible = false;
            this.search_grid_view.Size = new System.Drawing.Size(445, 342);
            this.search_grid_view.TabIndex = 19;
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.search_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_txt.BackgroundImage")));
            this.search_txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.search_txt.Icon = ((System.Drawing.Image)(resources.GetObject("search_txt.Icon")));
            this.search_txt.Location = new System.Drawing.Point(72, 91);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(167, 30);
            this.search_txt.TabIndex = 18;
            this.search_txt.text = "Search ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.SendBtn);
            this.groupBox1.Controls.Add(this.messegeBody);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(13, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 497);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(98, 35);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 20);
            this.txtPhone.TabIndex = 14;
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
            this.SendBtn.Location = new System.Drawing.Point(153, 243);
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
            this.messegeBody.Location = new System.Drawing.Point(98, 92);
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
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Send SMS";
            // 
            // drop_down_search
            // 
            this.drop_down_search.BackColor = System.Drawing.Color.Transparent;
            this.drop_down_search.BorderRadius = 3;
            this.drop_down_search.DisabledColor = System.Drawing.Color.Gray;
            this.drop_down_search.ForeColor = System.Drawing.Color.White;
            this.drop_down_search.Items = new string[] {
        "Choose..",
        "Parents ",
        "Teachers",
        "Students"};
            this.drop_down_search.Location = new System.Drawing.Point(72, 34);
            this.drop_down_search.Name = "drop_down_search";
            this.drop_down_search.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.drop_down_search.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(165)))), ((int)(((byte)(222)))));
            this.drop_down_search.selectedIndex = 0;
            this.drop_down_search.Size = new System.Drawing.Size(167, 31);
            this.drop_down_search.TabIndex = 21;
            // 
            // SMSPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SMSINsidePanel);
            this.Name = "SMSPanel";
            this.Size = new System.Drawing.Size(857, 601);
            this.Load += new System.EventHandler(this.SMSPanel_Load);
            this.SMSINsidePanel.ResumeLayout(false);
            this.SMSINsidePanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_grid_view)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SMSINsidePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private Bunifu.Framework.UI.BunifuThinButton2 SendBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox messegeBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid search_grid_view;
        private Bunifu.Framework.UI.BunifuTextbox search_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 Search_btn;
        private Bunifu.Framework.UI.BunifuDropdown drop_down_search;
    }
}
