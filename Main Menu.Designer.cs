
namespace NEA
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.exitBtn = new System.Windows.Forms.Button();
            this.CheckDatabaseButton = new System.Windows.Forms.Button();
            this.AutoAssignButton = new System.Windows.Forms.Button();
            this.SearchStaffButton = new System.Windows.Forms.Button();
            this.CheckFloorsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.SignatureLogo = new System.Windows.Forms.PictureBox();
            this.AdminSettingsButton = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SignatureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.Location = new System.Drawing.Point(16, 536);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(99, 37);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CheckDatabaseButton
            // 
            this.CheckDatabaseButton.BackColor = System.Drawing.Color.Orchid;
            this.CheckDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDatabaseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckDatabaseButton.Location = new System.Drawing.Point(373, 41);
            this.CheckDatabaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckDatabaseButton.Name = "CheckDatabaseButton";
            this.CheckDatabaseButton.Size = new System.Drawing.Size(419, 99);
            this.CheckDatabaseButton.TabIndex = 10;
            this.CheckDatabaseButton.Text = "Open Database";
            this.CheckDatabaseButton.UseVisualStyleBackColor = false;
            this.CheckDatabaseButton.Click += new System.EventHandler(this.CheckDatabaseButton_Click);
            // 
            // AutoAssignButton
            // 
            this.AutoAssignButton.BackColor = System.Drawing.Color.Orchid;
            this.AutoAssignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoAssignButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AutoAssignButton.Location = new System.Drawing.Point(373, 161);
            this.AutoAssignButton.Margin = new System.Windows.Forms.Padding(4);
            this.AutoAssignButton.Name = "AutoAssignButton";
            this.AutoAssignButton.Size = new System.Drawing.Size(419, 99);
            this.AutoAssignButton.TabIndex = 12;
            this.AutoAssignButton.Text = "Auto-Assign Carers";
            this.AutoAssignButton.UseVisualStyleBackColor = false;
            this.AutoAssignButton.Click += new System.EventHandler(this.AutoAssignButton_Click);
            // 
            // SearchStaffButton
            // 
            this.SearchStaffButton.BackColor = System.Drawing.Color.Orchid;
            this.SearchStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchStaffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchStaffButton.Location = new System.Drawing.Point(373, 281);
            this.SearchStaffButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchStaffButton.Name = "SearchStaffButton";
            this.SearchStaffButton.Size = new System.Drawing.Size(419, 99);
            this.SearchStaffButton.TabIndex = 13;
            this.SearchStaffButton.Text = "Search Staff";
            this.SearchStaffButton.UseVisualStyleBackColor = false;
            this.SearchStaffButton.Click += new System.EventHandler(this.SearchStaffButton_Click);
            // 
            // CheckFloorsButton
            // 
            this.CheckFloorsButton.BackColor = System.Drawing.Color.Orchid;
            this.CheckFloorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckFloorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckFloorsButton.Location = new System.Drawing.Point(373, 401);
            this.CheckFloorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckFloorsButton.Name = "CheckFloorsButton";
            this.CheckFloorsButton.Size = new System.Drawing.Size(419, 99);
            this.CheckFloorsButton.TabIndex = 14;
            this.CheckFloorsButton.Text = "Check Floors";
            this.CheckFloorsButton.UseVisualStyleBackColor = false;
            this.CheckFloorsButton.Click += new System.EventHandler(this.CheckFloorsButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Orchid;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProfileButton.Location = new System.Drawing.Point(39, 161);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(295, 340);
            this.ProfileButton.TabIndex = 15;
            this.ProfileButton.Text = "My Info";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // SignatureLogo
            // 
            this.SignatureLogo.BackColor = System.Drawing.Color.Transparent;
            this.SignatureLogo.Image = ((System.Drawing.Image)(resources.GetObject("SignatureLogo.Image")));
            this.SignatureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("SignatureLogo.InitialImage")));
            this.SignatureLogo.Location = new System.Drawing.Point(16, 26);
            this.SignatureLogo.Margin = new System.Windows.Forms.Padding(0);
            this.SignatureLogo.Name = "SignatureLogo";
            this.SignatureLogo.Size = new System.Drawing.Size(332, 114);
            this.SignatureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignatureLogo.TabIndex = 16;
            this.SignatureLogo.TabStop = false;
            this.SignatureLogo.Click += new System.EventHandler(this.SignatureLogo_Click);
            // 
            // AdminSettingsButton
            // 
            this.AdminSettingsButton.BackColor = System.Drawing.Color.Silver;
            this.AdminSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminSettingsButton.Location = new System.Drawing.Point(373, 536);
            this.AdminSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdminSettingsButton.Name = "AdminSettingsButton";
            this.AdminSettingsButton.Size = new System.Drawing.Size(419, 37);
            this.AdminSettingsButton.TabIndex = 17;
            this.AdminSettingsButton.Text = "Admin Settings";
            this.AdminSettingsButton.UseVisualStyleBackColor = false;
            this.AdminSettingsButton.Click += new System.EventHandler(this.AdminSettingsButton_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Silver;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.Location = new System.Drawing.Point(123, 536);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(99, 37);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(832, 588);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.AdminSettingsButton);
            this.Controls.Add(this.SignatureLogo);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.CheckFloorsButton);
            this.Controls.Add(this.SearchStaffButton);
            this.Controls.Add(this.AutoAssignButton);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.CheckDatabaseButton);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlfaRota";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SignatureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button CheckDatabaseButton;
        private System.Windows.Forms.Button AutoAssignButton;
        private System.Windows.Forms.Button SearchStaffButton;
        private System.Windows.Forms.Button CheckFloorsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.PictureBox SignatureLogo;
        private System.Windows.Forms.Button AdminSettingsButton;
        private System.Windows.Forms.Button logoutBtn;
    }
}