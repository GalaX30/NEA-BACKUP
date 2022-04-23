namespace NEA
{
    partial class View_Database_Options_Menu
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
            this.staffdataBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.residentdataBtn = new System.Windows.Forms.Button();
            this.medicationdataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staffdataBtn
            // 
            this.staffdataBtn.BackColor = System.Drawing.Color.Orchid;
            this.staffdataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffdataBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.staffdataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.staffdataBtn.Location = new System.Drawing.Point(13, 13);
            this.staffdataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.staffdataBtn.Name = "staffdataBtn";
            this.staffdataBtn.Size = new System.Drawing.Size(332, 99);
            this.staffdataBtn.TabIndex = 19;
            this.staffdataBtn.Text = "Staff Database";
            this.staffdataBtn.UseVisualStyleBackColor = false;
            this.staffdataBtn.Click += new System.EventHandler(this.staffdataBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Silver;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.Location = new System.Drawing.Point(13, 380);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 37);
            this.backBtn.TabIndex = 43;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // residentdataBtn
            // 
            this.residentdataBtn.BackColor = System.Drawing.Color.Orchid;
            this.residentdataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.residentdataBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.residentdataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.residentdataBtn.Location = new System.Drawing.Point(13, 135);
            this.residentdataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.residentdataBtn.Name = "residentdataBtn";
            this.residentdataBtn.Size = new System.Drawing.Size(332, 99);
            this.residentdataBtn.TabIndex = 44;
            this.residentdataBtn.Text = "Resident Database";
            this.residentdataBtn.UseVisualStyleBackColor = false;
            this.residentdataBtn.Click += new System.EventHandler(this.residentdataBtn_Click);
            // 
            // medicationdataBtn
            // 
            this.medicationdataBtn.BackColor = System.Drawing.Color.Orchid;
            this.medicationdataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicationdataBtn.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.medicationdataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medicationdataBtn.Location = new System.Drawing.Point(13, 257);
            this.medicationdataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.medicationdataBtn.Name = "medicationdataBtn";
            this.medicationdataBtn.Size = new System.Drawing.Size(332, 99);
            this.medicationdataBtn.TabIndex = 45;
            this.medicationdataBtn.Text = "Medication Database";
            this.medicationdataBtn.UseVisualStyleBackColor = false;
            this.medicationdataBtn.Click += new System.EventHandler(this.medicationdataBtn_Click);
            // 
            // View_Database_Options_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(357, 430);
            this.Controls.Add(this.medicationdataBtn);
            this.Controls.Add(this.residentdataBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.staffdataBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "View_Database_Options_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlfaRota";
            this.Load += new System.EventHandler(this.View_Database_Options_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button staffdataBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button residentdataBtn;
        private System.Windows.Forms.Button medicationdataBtn;
    }
}