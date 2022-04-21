
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
            this.databaseBtn = new System.Windows.Forms.Button();
            this.autoassignBtn = new System.Windows.Forms.Button();
            this.manualassignBtn = new System.Windows.Forms.Button();
            this.floorsBtn = new System.Windows.Forms.Button();
            this.SignatureLogo = new System.Windows.Forms.PictureBox();
            this.adminBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SignatureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.Location = new System.Drawing.Point(13, 419);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(99, 37);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // databaseBtn
            // 
            this.databaseBtn.BackColor = System.Drawing.Color.Orchid;
            this.databaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databaseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.databaseBtn.Location = new System.Drawing.Point(13, 161);
            this.databaseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.databaseBtn.Name = "databaseBtn";
            this.databaseBtn.Size = new System.Drawing.Size(332, 99);
            this.databaseBtn.TabIndex = 10;
            this.databaseBtn.Text = "Open Database";
            this.databaseBtn.UseVisualStyleBackColor = false;
            this.databaseBtn.Click += new System.EventHandler(this.CheckDatabaseButton_Click);
            // 
            // autoassignBtn
            // 
            this.autoassignBtn.BackColor = System.Drawing.Color.Orchid;
            this.autoassignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoassignBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoassignBtn.Location = new System.Drawing.Point(13, 283);
            this.autoassignBtn.Margin = new System.Windows.Forms.Padding(4);
            this.autoassignBtn.Name = "autoassignBtn";
            this.autoassignBtn.Size = new System.Drawing.Size(332, 99);
            this.autoassignBtn.TabIndex = 12;
            this.autoassignBtn.Text = "Auto-Assign Carers";
            this.autoassignBtn.UseVisualStyleBackColor = false;
            this.autoassignBtn.Click += new System.EventHandler(this.AutoAssignButton_Click);
            // 
            // manualassignBtn
            // 
            this.manualassignBtn.BackColor = System.Drawing.Color.Orchid;
            this.manualassignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualassignBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manualassignBtn.Location = new System.Drawing.Point(372, 283);
            this.manualassignBtn.Margin = new System.Windows.Forms.Padding(4);
            this.manualassignBtn.Name = "manualassignBtn";
            this.manualassignBtn.Size = new System.Drawing.Size(332, 99);
            this.manualassignBtn.TabIndex = 13;
            this.manualassignBtn.Text = "Manual-Assign Carers";
            this.manualassignBtn.UseVisualStyleBackColor = false;
            this.manualassignBtn.Click += new System.EventHandler(this.SearchStaffButton_Click);
            // 
            // floorsBtn
            // 
            this.floorsBtn.BackColor = System.Drawing.Color.Orchid;
            this.floorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.floorsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.floorsBtn.Location = new System.Drawing.Point(372, 161);
            this.floorsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.floorsBtn.Name = "floorsBtn";
            this.floorsBtn.Size = new System.Drawing.Size(332, 99);
            this.floorsBtn.TabIndex = 14;
            this.floorsBtn.Text = "Check Floors";
            this.floorsBtn.UseVisualStyleBackColor = false;
            this.floorsBtn.Click += new System.EventHandler(this.CheckFloorsButton_Click);
            // 
            // SignatureLogo
            // 
            this.SignatureLogo.BackColor = System.Drawing.Color.Transparent;
            this.SignatureLogo.Image = ((System.Drawing.Image)(resources.GetObject("SignatureLogo.Image")));
            this.SignatureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("SignatureLogo.InitialImage")));
            this.SignatureLogo.Location = new System.Drawing.Point(192, 23);
            this.SignatureLogo.Margin = new System.Windows.Forms.Padding(0);
            this.SignatureLogo.Name = "SignatureLogo";
            this.SignatureLogo.Size = new System.Drawing.Size(332, 114);
            this.SignatureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignatureLogo.TabIndex = 16;
            this.SignatureLogo.TabStop = false;
            this.SignatureLogo.Click += new System.EventHandler(this.SignatureLogo_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Silver;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminBtn.Location = new System.Drawing.Point(372, 419);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(332, 37);
            this.adminBtn.TabIndex = 17;
            this.adminBtn.Text = "Admin Settings";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.AdminSettingsButton_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Silver;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.Location = new System.Drawing.Point(120, 419);
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
            this.ClientSize = new System.Drawing.Size(717, 469);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.SignatureLogo);
            this.Controls.Add(this.floorsBtn);
            this.Controls.Add(this.manualassignBtn);
            this.Controls.Add(this.autoassignBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.databaseBtn);
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
        private System.Windows.Forms.Button databaseBtn;
        private System.Windows.Forms.Button autoassignBtn;
        private System.Windows.Forms.Button manualassignBtn;
        private System.Windows.Forms.Button floorsBtn;
        private System.Windows.Forms.PictureBox SignatureLogo;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}