namespace NEA
{
    partial class View_Database_Menu_Medicine
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
            this.okBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.databaseList = new System.Windows.Forms.ListBox();
            this.ammountTxt = new System.Windows.Forms.TextBox();
            this.medicationTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.ammountLbl = new System.Windows.Forms.Label();
            this.medicationLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.Orchid;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.okBtn.Location = new System.Drawing.Point(192, 445);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(151, 37);
            this.okBtn.TabIndex = 144;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchTxt.Location = new System.Drawing.Point(136, 508);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(207, 25);
            this.searchTxt.TabIndex = 125;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBtn.Location = new System.Drawing.Point(30, 508);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 25);
            this.searchBtn.TabIndex = 124;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.filterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterBtn.Location = new System.Drawing.Point(447, 573);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(99, 37);
            this.filterBtn.TabIndex = 123;
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
            this.sortBtn.Location = new System.Drawing.Point(554, 573);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(99, 37);
            this.sortBtn.TabIndex = 122;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Orchid;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshBtn.Location = new System.Drawing.Point(30, 445);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(151, 37);
            this.refreshBtn.TabIndex = 119;
            this.refreshBtn.Text = "Refresh Data";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Silver;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.Location = new System.Drawing.Point(13, 573);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 37);
            this.backBtn.TabIndex = 118;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.databaseList.TabIndex = 117;
            this.databaseList.SelectedIndexChanged += new System.EventHandler(this.databaseList_SelectedIndexChanged);
            // 
            // ammountTxt
            // 
            this.ammountTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ammountTxt.Location = new System.Drawing.Point(478, 272);
            this.ammountTxt.Name = "ammountTxt";
            this.ammountTxt.Size = new System.Drawing.Size(148, 25);
            this.ammountTxt.TabIndex = 150;
            this.ammountTxt.TextChanged += new System.EventHandler(this.ammountTxt_TextChanged);
            // 
            // medicationTxt
            // 
            this.medicationTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.medicationTxt.Location = new System.Drawing.Point(478, 241);
            this.medicationTxt.Name = "medicationTxt";
            this.medicationTxt.Size = new System.Drawing.Size(148, 25);
            this.medicationTxt.TabIndex = 149;
            this.medicationTxt.TextChanged += new System.EventHandler(this.medicationTxt_TextChanged);
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.idTxt.Location = new System.Drawing.Point(478, 209);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(148, 25);
            this.idTxt.TabIndex = 148;
            this.idTxt.TextChanged += new System.EventHandler(this.idTxt_TextChanged);
            // 
            // ammountLbl
            // 
            this.ammountLbl.AutoSize = true;
            this.ammountLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.ammountLbl.ForeColor = System.Drawing.Color.Silver;
            this.ammountLbl.Location = new System.Drawing.Point(378, 274);
            this.ammountLbl.Name = "ammountLbl";
            this.ammountLbl.Size = new System.Drawing.Size(85, 20);
            this.ammountLbl.TabIndex = 147;
            this.ammountLbl.Text = "Ammount:";
            this.ammountLbl.Click += new System.EventHandler(this.ammountLbl_Click);
            // 
            // medicationLbl
            // 
            this.medicationLbl.AutoSize = true;
            this.medicationLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.medicationLbl.ForeColor = System.Drawing.Color.Silver;
            this.medicationLbl.Location = new System.Drawing.Point(378, 243);
            this.medicationLbl.Name = "medicationLbl";
            this.medicationLbl.Size = new System.Drawing.Size(55, 20);
            this.medicationLbl.TabIndex = 146;
            this.medicationLbl.Text = "Name:";
            this.medicationLbl.Click += new System.EventHandler(this.medicationLbl_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.idLbl.ForeColor = System.Drawing.Color.Silver;
            this.idLbl.Location = new System.Drawing.Point(378, 211);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(29, 20);
            this.idLbl.TabIndex = 145;
            this.idLbl.Text = "ID:";
            this.idLbl.Click += new System.EventHandler(this.idLbl_Click);
            // 
            // View_Database_Menu_Medicine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(666, 623);
            this.Controls.Add(this.ammountTxt);
            this.Controls.Add(this.medicationTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.ammountLbl);
            this.Controls.Add(this.medicationLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.databaseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "View_Database_Menu_Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Database_Menu_Medicine";
            this.Load += new System.EventHandler(this.View_Database_Menu_Medicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListBox databaseList;
        private System.Windows.Forms.TextBox ammountTxt;
        private System.Windows.Forms.TextBox medicationTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label ammountLbl;
        private System.Windows.Forms.Label medicationLbl;
        private System.Windows.Forms.Label idLbl;
    }
}