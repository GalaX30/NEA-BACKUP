namespace NEA
{
    partial class View_Database_Menu_Staff
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
            this.databaseList = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.lastnameLbl = new System.Windows.Forms.Label();
            this.firstnameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.genderLbl = new System.Windows.Forms.Label();
            this.presentLbl = new System.Windows.Forms.Label();
            this.floor1Lbl = new System.Windows.Forms.Label();
            this.floor2Lbl = new System.Windows.Forms.Label();
            this.floor3Lbl = new System.Windows.Forms.Label();
            this.onfloorLbl = new System.Windows.Forms.Label();
            this.onfloorTxt = new System.Windows.Forms.TextBox();
            this.presentTxt = new System.Windows.Forms.TextBox();
            this.floor1Txt = new System.Windows.Forms.TextBox();
            this.floor2Txt = new System.Windows.Forms.TextBox();
            this.floor3Txt = new System.Windows.Forms.TextBox();
            this.genderTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // databaseList
            // 
            this.databaseList.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.databaseList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.databaseList.FormattingEnabled = true;
            this.databaseList.ItemHeight = 19;
            this.databaseList.Location = new System.Drawing.Point(30, 30);
            this.databaseList.Name = "databaseList";
            this.databaseList.Size = new System.Drawing.Size(313, 403);
            this.databaseList.TabIndex = 41;
            this.databaseList.SelectedIndexChanged += new System.EventHandler(this.databaseList_SelectedIndexChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Silver;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.Location = new System.Drawing.Point(13, 573);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 37);
            this.backBtn.TabIndex = 42;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Orchid;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshBtn.Location = new System.Drawing.Point(30, 445);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(151, 37);
            this.refreshBtn.TabIndex = 55;
            this.refreshBtn.Text = "Refresh Data";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortBtn.Location = new System.Drawing.Point(554, 573);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(99, 37);
            this.sortBtn.TabIndex = 59;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterBtn.Location = new System.Drawing.Point(447, 573);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(99, 37);
            this.filterBtn.TabIndex = 60;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBtn.Location = new System.Drawing.Point(30, 508);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 25);
            this.searchBtn.TabIndex = 61;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 25);
            this.textBox1.TabIndex = 71;
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lastnameTxt.Location = new System.Drawing.Point(478, 171);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(148, 25);
            this.lastnameTxt.TabIndex = 109;
            this.lastnameTxt.TextChanged += new System.EventHandler(this.lastnameTxt_TextChanged);
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.firstnameTxt.Location = new System.Drawing.Point(478, 140);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(148, 25);
            this.firstnameTxt.TabIndex = 108;
            this.firstnameTxt.TextChanged += new System.EventHandler(this.firstnameTxt_TextChanged);
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.idTxt.Location = new System.Drawing.Point(478, 108);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(148, 25);
            this.idTxt.TabIndex = 107;
            this.idTxt.TextChanged += new System.EventHandler(this.idTxt_TextChanged_1);
            // 
            // lastnameLbl
            // 
            this.lastnameLbl.AutoSize = true;
            this.lastnameLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lastnameLbl.ForeColor = System.Drawing.Color.Silver;
            this.lastnameLbl.Location = new System.Drawing.Point(378, 173);
            this.lastnameLbl.Name = "lastnameLbl";
            this.lastnameLbl.Size = new System.Drawing.Size(81, 20);
            this.lastnameLbl.TabIndex = 100;
            this.lastnameLbl.Text = "Lastname:";
            this.lastnameLbl.Click += new System.EventHandler(this.lastnameLbl_Click);
            // 
            // firstnameLbl
            // 
            this.firstnameLbl.AutoSize = true;
            this.firstnameLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.firstnameLbl.ForeColor = System.Drawing.Color.Silver;
            this.firstnameLbl.Location = new System.Drawing.Point(378, 142);
            this.firstnameLbl.Name = "firstnameLbl";
            this.firstnameLbl.Size = new System.Drawing.Size(83, 20);
            this.firstnameLbl.TabIndex = 99;
            this.firstnameLbl.Text = "Firstname:";
            this.firstnameLbl.Click += new System.EventHandler(this.firstnameLbl_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.idLbl.ForeColor = System.Drawing.Color.Silver;
            this.idLbl.Location = new System.Drawing.Point(378, 110);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(29, 20);
            this.idLbl.TabIndex = 98;
            this.idLbl.Text = "ID:";
            this.idLbl.Click += new System.EventHandler(this.idLbl_Click_1);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Orchid;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.okBtn.Location = new System.Drawing.Point(192, 445);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(151, 37);
            this.okBtn.TabIndex = 116;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.genderLbl.ForeColor = System.Drawing.Color.Silver;
            this.genderLbl.Location = new System.Drawing.Point(378, 204);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(64, 20);
            this.genderLbl.TabIndex = 101;
            this.genderLbl.Text = "Gender:";
            this.genderLbl.Click += new System.EventHandler(this.genderLbl_Click);
            // 
            // presentLbl
            // 
            this.presentLbl.AutoSize = true;
            this.presentLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.presentLbl.ForeColor = System.Drawing.Color.Silver;
            this.presentLbl.Location = new System.Drawing.Point(378, 235);
            this.presentLbl.Name = "presentLbl";
            this.presentLbl.Size = new System.Drawing.Size(66, 20);
            this.presentLbl.TabIndex = 102;
            this.presentLbl.Text = "Present:";
            this.presentLbl.Click += new System.EventHandler(this.presentLbl_Click);
            // 
            // floor1Lbl
            // 
            this.floor1Lbl.AutoSize = true;
            this.floor1Lbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.floor1Lbl.ForeColor = System.Drawing.Color.Silver;
            this.floor1Lbl.Location = new System.Drawing.Point(378, 266);
            this.floor1Lbl.Name = "floor1Lbl";
            this.floor1Lbl.Size = new System.Drawing.Size(62, 20);
            this.floor1Lbl.TabIndex = 103;
            this.floor1Lbl.Text = "Floor 1:";
            this.floor1Lbl.Click += new System.EventHandler(this.floor1Lbl_Click);
            // 
            // floor2Lbl
            // 
            this.floor2Lbl.AutoSize = true;
            this.floor2Lbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.floor2Lbl.ForeColor = System.Drawing.Color.Silver;
            this.floor2Lbl.Location = new System.Drawing.Point(378, 297);
            this.floor2Lbl.Name = "floor2Lbl";
            this.floor2Lbl.Size = new System.Drawing.Size(62, 20);
            this.floor2Lbl.TabIndex = 104;
            this.floor2Lbl.Text = "Floor 2:";
            this.floor2Lbl.Click += new System.EventHandler(this.floor2Lbl_Click);
            // 
            // floor3Lbl
            // 
            this.floor3Lbl.AutoSize = true;
            this.floor3Lbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.floor3Lbl.ForeColor = System.Drawing.Color.Silver;
            this.floor3Lbl.Location = new System.Drawing.Point(378, 328);
            this.floor3Lbl.Name = "floor3Lbl";
            this.floor3Lbl.Size = new System.Drawing.Size(62, 20);
            this.floor3Lbl.TabIndex = 105;
            this.floor3Lbl.Text = "Floor 3:";
            this.floor3Lbl.Click += new System.EventHandler(this.floor3Lbl_Click);
            // 
            // onfloorLbl
            // 
            this.onfloorLbl.AutoSize = true;
            this.onfloorLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.onfloorLbl.ForeColor = System.Drawing.Color.Silver;
            this.onfloorLbl.Location = new System.Drawing.Point(378, 359);
            this.onfloorLbl.Name = "onfloorLbl";
            this.onfloorLbl.Size = new System.Drawing.Size(73, 20);
            this.onfloorLbl.TabIndex = 106;
            this.onfloorLbl.Text = "On Floor:";
            this.onfloorLbl.Click += new System.EventHandler(this.onfloorLbl_Click);
            // 
            // onfloorTxt
            // 
            this.onfloorTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.onfloorTxt.Location = new System.Drawing.Point(478, 357);
            this.onfloorTxt.Name = "onfloorTxt";
            this.onfloorTxt.Size = new System.Drawing.Size(148, 25);
            this.onfloorTxt.TabIndex = 115;
            this.onfloorTxt.TextChanged += new System.EventHandler(this.onfloorTxt_TextChanged);
            // 
            // presentTxt
            // 
            this.presentTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.presentTxt.Location = new System.Drawing.Point(478, 233);
            this.presentTxt.Name = "presentTxt";
            this.presentTxt.Size = new System.Drawing.Size(148, 25);
            this.presentTxt.TabIndex = 111;
            this.presentTxt.TextChanged += new System.EventHandler(this.presentTxt_TextChanged);
            // 
            // floor1Txt
            // 
            this.floor1Txt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.floor1Txt.Location = new System.Drawing.Point(478, 264);
            this.floor1Txt.Name = "floor1Txt";
            this.floor1Txt.Size = new System.Drawing.Size(148, 25);
            this.floor1Txt.TabIndex = 112;
            this.floor1Txt.TextChanged += new System.EventHandler(this.floor1Txt_TextChanged);
            // 
            // floor2Txt
            // 
            this.floor2Txt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.floor2Txt.Location = new System.Drawing.Point(478, 295);
            this.floor2Txt.Name = "floor2Txt";
            this.floor2Txt.Size = new System.Drawing.Size(148, 25);
            this.floor2Txt.TabIndex = 113;
            this.floor2Txt.TextChanged += new System.EventHandler(this.floor2Txt_TextChanged);
            // 
            // floor3Txt
            // 
            this.floor3Txt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.floor3Txt.Location = new System.Drawing.Point(478, 326);
            this.floor3Txt.Name = "floor3Txt";
            this.floor3Txt.Size = new System.Drawing.Size(148, 25);
            this.floor3Txt.TabIndex = 114;
            this.floor3Txt.TextChanged += new System.EventHandler(this.floor3Txt_TextChanged);
            // 
            // genderTxt
            // 
            this.genderTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.genderTxt.Location = new System.Drawing.Point(478, 202);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(148, 25);
            this.genderTxt.TabIndex = 110;
            this.genderTxt.TextChanged += new System.EventHandler(this.genderTxt_TextChanged);
            // 
            // View_Database_Menu_Staff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(666, 623);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.onfloorTxt);
            this.Controls.Add(this.floor3Txt);
            this.Controls.Add(this.floor2Txt);
            this.Controls.Add(this.floor1Txt);
            this.Controls.Add(this.presentTxt);
            this.Controls.Add(this.genderTxt);
            this.Controls.Add(this.lastnameTxt);
            this.Controls.Add(this.firstnameTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.onfloorLbl);
            this.Controls.Add(this.floor3Lbl);
            this.Controls.Add(this.floor2Lbl);
            this.Controls.Add(this.floor1Lbl);
            this.Controls.Add(this.presentLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.lastnameLbl);
            this.Controls.Add(this.firstnameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.databaseList);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Database_Menu_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlfaRota";
            this.Load += new System.EventHandler(this.View_Database_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox databaseList;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label lastnameLbl;
        private System.Windows.Forms.Label firstnameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label presentLbl;
        private System.Windows.Forms.Label floor1Lbl;
        private System.Windows.Forms.Label floor2Lbl;
        private System.Windows.Forms.Label floor3Lbl;
        private System.Windows.Forms.Label onfloorLbl;
        private System.Windows.Forms.TextBox onfloorTxt;
        private System.Windows.Forms.TextBox presentTxt;
        private System.Windows.Forms.TextBox floor1Txt;
        private System.Windows.Forms.TextBox floor2Txt;
        private System.Windows.Forms.TextBox floor3Txt;
        private System.Windows.Forms.TextBox genderTxt;
    }
}