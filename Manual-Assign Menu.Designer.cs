namespace NEA
{
    partial class Manual_Assign_Menu
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
            this.filterBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.presentLbl = new System.Windows.Forms.Label();
            this.floor3Lbl = new System.Windows.Forms.Label();
            this.floor2Lbl = new System.Windows.Forms.Label();
            this.floor1Lbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.lastnameLbl = new System.Windows.Forms.Label();
            this.firstnameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.staffList = new System.Windows.Forms.ListBox();
            this.assignTxt = new System.Windows.Forms.TextBox();
            this.floorLbl = new System.Windows.Forms.Label();
            this.assignBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.filterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterBtn.Location = new System.Drawing.Point(478, 470);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(99, 37);
            this.filterBtn.TabIndex = 79;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.sortBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortBtn.Location = new System.Drawing.Point(585, 470);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(99, 37);
            this.sortBtn.TabIndex = 78;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // presentLbl
            // 
            this.presentLbl.AutoSize = true;
            this.presentLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.presentLbl.ForeColor = System.Drawing.Color.Silver;
            this.presentLbl.Location = new System.Drawing.Point(478, 312);
            this.presentLbl.Name = "presentLbl";
            this.presentLbl.Size = new System.Drawing.Size(135, 20);
            this.presentLbl.TabIndex = 72;
            this.presentLbl.Text = "Currently Present:";
            this.presentLbl.Click += new System.EventHandler(this.presentLbl_Click);
            // 
            // floor3Lbl
            // 
            this.floor3Lbl.AutoSize = true;
            this.floor3Lbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.floor3Lbl.ForeColor = System.Drawing.Color.Silver;
            this.floor3Lbl.Location = new System.Drawing.Point(478, 282);
            this.floor3Lbl.Name = "floor3Lbl";
            this.floor3Lbl.Size = new System.Drawing.Size(152, 20);
            this.floor3Lbl.TabIndex = 71;
            this.floor3Lbl.Text = "Qualified for floor 3:";
            this.floor3Lbl.Click += new System.EventHandler(this.floor3Lbl_Click);
            // 
            // floor2Lbl
            // 
            this.floor2Lbl.AutoSize = true;
            this.floor2Lbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.floor2Lbl.ForeColor = System.Drawing.Color.Silver;
            this.floor2Lbl.Location = new System.Drawing.Point(478, 252);
            this.floor2Lbl.Name = "floor2Lbl";
            this.floor2Lbl.Size = new System.Drawing.Size(152, 20);
            this.floor2Lbl.TabIndex = 70;
            this.floor2Lbl.Text = "Qualified for floor 2:";
            this.floor2Lbl.Click += new System.EventHandler(this.floor2Lbl_Click);
            // 
            // floor1Lbl
            // 
            this.floor1Lbl.AutoSize = true;
            this.floor1Lbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.floor1Lbl.ForeColor = System.Drawing.Color.Silver;
            this.floor1Lbl.Location = new System.Drawing.Point(478, 222);
            this.floor1Lbl.Name = "floor1Lbl";
            this.floor1Lbl.Size = new System.Drawing.Size(152, 20);
            this.floor1Lbl.TabIndex = 69;
            this.floor1Lbl.Text = "Qualified for floor 1:";
            this.floor1Lbl.Click += new System.EventHandler(this.floor1Lbl_Click);
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.genderLbl.ForeColor = System.Drawing.Color.Silver;
            this.genderLbl.Location = new System.Drawing.Point(478, 192);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(64, 20);
            this.genderLbl.TabIndex = 68;
            this.genderLbl.Text = "Gender:";
            this.genderLbl.Click += new System.EventHandler(this.genderLbl_Click);
            // 
            // lastnameLbl
            // 
            this.lastnameLbl.AutoSize = true;
            this.lastnameLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lastnameLbl.ForeColor = System.Drawing.Color.Silver;
            this.lastnameLbl.Location = new System.Drawing.Point(478, 162);
            this.lastnameLbl.Name = "lastnameLbl";
            this.lastnameLbl.Size = new System.Drawing.Size(81, 20);
            this.lastnameLbl.TabIndex = 67;
            this.lastnameLbl.Text = "Lastname:";
            this.lastnameLbl.Click += new System.EventHandler(this.lastnameLbl_Click);
            // 
            // firstnameLbl
            // 
            this.firstnameLbl.AutoSize = true;
            this.firstnameLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.firstnameLbl.ForeColor = System.Drawing.Color.Silver;
            this.firstnameLbl.Location = new System.Drawing.Point(478, 132);
            this.firstnameLbl.Name = "firstnameLbl";
            this.firstnameLbl.Size = new System.Drawing.Size(83, 20);
            this.firstnameLbl.TabIndex = 66;
            this.firstnameLbl.Text = "Firstname:";
            this.firstnameLbl.Click += new System.EventHandler(this.firstnameLbl_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.idLbl.ForeColor = System.Drawing.Color.Silver;
            this.idLbl.Location = new System.Drawing.Point(478, 102);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(29, 20);
            this.idLbl.TabIndex = 65;
            this.idLbl.Text = "ID:";
            this.idLbl.Click += new System.EventHandler(this.idLbl_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Leelawadee UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.nameLbl.ForeColor = System.Drawing.Color.Silver;
            this.nameLbl.Location = new System.Drawing.Point(475, 35);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(95, 38);
            this.nameLbl.TabIndex = 64;
            this.nameLbl.Text = "Name";
            this.nameLbl.Click += new System.EventHandler(this.nameLbl_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Silver;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.Location = new System.Drawing.Point(13, 470);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 37);
            this.backBtn.TabIndex = 63;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // staffList
            // 
            this.staffList.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.staffList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.staffList.FormattingEnabled = true;
            this.staffList.ItemHeight = 19;
            this.staffList.Location = new System.Drawing.Point(30, 73);
            this.staffList.Name = "staffList";
            this.staffList.Size = new System.Drawing.Size(422, 251);
            this.staffList.TabIndex = 62;
            this.staffList.SelectedIndexChanged += new System.EventHandler(this.staffList_SelectedIndexChanged);
            // 
            // assignTxt
            // 
            this.assignTxt.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.assignTxt.Location = new System.Drawing.Point(533, 339);
            this.assignTxt.Name = "assignTxt";
            this.assignTxt.Size = new System.Drawing.Size(44, 27);
            this.assignTxt.TabIndex = 81;
            this.assignTxt.TextChanged += new System.EventHandler(this.assignTxt_TextChanged);
            // 
            // floorLbl
            // 
            this.floorLbl.AutoSize = true;
            this.floorLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.floorLbl.ForeColor = System.Drawing.Color.Silver;
            this.floorLbl.Location = new System.Drawing.Point(478, 342);
            this.floorLbl.Name = "floorLbl";
            this.floorLbl.Size = new System.Drawing.Size(49, 20);
            this.floorLbl.TabIndex = 82;
            this.floorLbl.Text = "Floor:";
            this.floorLbl.Click += new System.EventHandler(this.floorLbl_Click);
            // 
            // assignBtn
            // 
            this.assignBtn.BackColor = System.Drawing.Color.Orchid;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.assignBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assignBtn.Location = new System.Drawing.Point(482, 379);
            this.assignBtn.Margin = new System.Windows.Forms.Padding(4);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(99, 37);
            this.assignBtn.TabIndex = 83;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = false;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 20);
            this.textBox1.TabIndex = 84;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Orchid;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBtn.Location = new System.Drawing.Point(30, 379);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 37);
            this.searchBtn.TabIndex = 85;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.searchLbl.ForeColor = System.Drawing.Color.Silver;
            this.searchLbl.Location = new System.Drawing.Point(26, 343);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(59, 20);
            this.searchLbl.TabIndex = 86;
            this.searchLbl.Text = "Search:";
            this.searchLbl.Click += new System.EventHandler(this.searchLbl_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.Orchid;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.generateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateBtn.Location = new System.Drawing.Point(30, 32);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(422, 34);
            this.generateBtn.TabIndex = 87;
            this.generateBtn.Text = "Load Staff";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // Manual_Assign_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(697, 520);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.assignBtn);
            this.Controls.Add(this.floorLbl);
            this.Controls.Add(this.assignTxt);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.presentLbl);
            this.Controls.Add(this.floor3Lbl);
            this.Controls.Add(this.floor2Lbl);
            this.Controls.Add(this.floor1Lbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.lastnameLbl);
            this.Controls.Add(this.firstnameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.staffList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Manual_Assign_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlfaRota";
            this.Load += new System.EventHandler(this.Manual_Assign_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label presentLbl;
        private System.Windows.Forms.Label floor3Lbl;
        private System.Windows.Forms.Label floor2Lbl;
        private System.Windows.Forms.Label floor1Lbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label lastnameLbl;
        private System.Windows.Forms.Label firstnameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListBox staffList;
        private System.Windows.Forms.TextBox assignTxt;
        private System.Windows.Forms.Label floorLbl;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button generateBtn;
    }
}