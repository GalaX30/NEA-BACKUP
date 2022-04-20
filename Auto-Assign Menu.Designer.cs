namespace NEA
{
    partial class Auto_Assign_Menu
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
            this.GenerateCarersButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Floor1CheckBox = new System.Windows.Forms.CheckBox();
            this.Floor2CheckBox = new System.Windows.Forms.CheckBox();
            this.Floor3CheckBox = new System.Windows.Forms.CheckBox();
            this.OnlyAvailableStaffCheckBox = new System.Windows.Forms.CheckBox();
            this.Floor1StaffListBox = new System.Windows.Forms.ListBox();
            this.Floor2StaffListBox = new System.Windows.Forms.ListBox();
            this.Floor3StaffListBox = new System.Windows.Forms.ListBox();
            this.Floor1Label = new System.Windows.Forms.Label();
            this.Floor2Label = new System.Windows.Forms.Label();
            this.Floor3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateCarersButton
            // 
            this.GenerateCarersButton.BackColor = System.Drawing.Color.Orchid;
            this.GenerateCarersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateCarersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenerateCarersButton.Location = new System.Drawing.Point(558, 313);
            this.GenerateCarersButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateCarersButton.Name = "GenerateCarersButton";
            this.GenerateCarersButton.Size = new System.Drawing.Size(283, 48);
            this.GenerateCarersButton.TabIndex = 33;
            this.GenerateCarersButton.Text = "Generate";
            this.GenerateCarersButton.UseVisualStyleBackColor = false;
            this.GenerateCarersButton.Click += new System.EventHandler(this.GenerateCarersButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackButton.Location = new System.Drawing.Point(13, 324);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 37);
            this.BackButton.TabIndex = 29;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Floor1CheckBox
            // 
            this.Floor1CheckBox.AutoSize = true;
            this.Floor1CheckBox.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Floor1CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Floor1CheckBox.Location = new System.Drawing.Point(27, 40);
            this.Floor1CheckBox.Name = "Floor1CheckBox";
            this.Floor1CheckBox.Size = new System.Drawing.Size(101, 34);
            this.Floor1CheckBox.TabIndex = 36;
            this.Floor1CheckBox.Text = "Floor 1";
            this.Floor1CheckBox.UseVisualStyleBackColor = true;
            this.Floor1CheckBox.CheckedChanged += new System.EventHandler(this.Floor1CheckBox_CheckedChanged);
            // 
            // Floor2CheckBox
            // 
            this.Floor2CheckBox.AutoSize = true;
            this.Floor2CheckBox.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Floor2CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Floor2CheckBox.Location = new System.Drawing.Point(27, 90);
            this.Floor2CheckBox.Name = "Floor2CheckBox";
            this.Floor2CheckBox.Size = new System.Drawing.Size(101, 34);
            this.Floor2CheckBox.TabIndex = 37;
            this.Floor2CheckBox.Text = "Floor 2";
            this.Floor2CheckBox.UseVisualStyleBackColor = true;
            this.Floor2CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Floor3CheckBox
            // 
            this.Floor3CheckBox.AutoSize = true;
            this.Floor3CheckBox.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.Floor3CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Floor3CheckBox.Location = new System.Drawing.Point(27, 140);
            this.Floor3CheckBox.Name = "Floor3CheckBox";
            this.Floor3CheckBox.Size = new System.Drawing.Size(101, 34);
            this.Floor3CheckBox.TabIndex = 38;
            this.Floor3CheckBox.Text = "Floor 3";
            this.Floor3CheckBox.UseVisualStyleBackColor = true;
            this.Floor3CheckBox.CheckedChanged += new System.EventHandler(this.Floor3CheckBox_CheckedChanged);
            // 
            // OnlyAvailableStaffCheckBox
            // 
            this.OnlyAvailableStaffCheckBox.AutoSize = true;
            this.OnlyAvailableStaffCheckBox.Font = new System.Drawing.Font("Leelawadee UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.OnlyAvailableStaffCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OnlyAvailableStaffCheckBox.Location = new System.Drawing.Point(27, 228);
            this.OnlyAvailableStaffCheckBox.Name = "OnlyAvailableStaffCheckBox";
            this.OnlyAvailableStaffCheckBox.Size = new System.Drawing.Size(161, 19);
            this.OnlyAvailableStaffCheckBox.TabIndex = 39;
            this.OnlyAvailableStaffCheckBox.Text = "Only use available carers";
            this.OnlyAvailableStaffCheckBox.UseVisualStyleBackColor = true;
            this.OnlyAvailableStaffCheckBox.CheckedChanged += new System.EventHandler(this.OnlyAvailableStaffCheckBox_CheckedChanged);
            // 
            // Floor1StaffListBox
            // 
            this.Floor1StaffListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Floor1StaffListBox.FormattingEnabled = true;
            this.Floor1StaffListBox.ItemHeight = 17;
            this.Floor1StaffListBox.Location = new System.Drawing.Point(215, 48);
            this.Floor1StaffListBox.Name = "Floor1StaffListBox";
            this.Floor1StaffListBox.Size = new System.Drawing.Size(192, 242);
            this.Floor1StaffListBox.TabIndex = 40;
            this.Floor1StaffListBox.SelectedIndexChanged += new System.EventHandler(this.Floor1StaffListBox_SelectedIndexChanged);
            // 
            // Floor2StaffListBox
            // 
            this.Floor2StaffListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Floor2StaffListBox.FormattingEnabled = true;
            this.Floor2StaffListBox.ItemHeight = 17;
            this.Floor2StaffListBox.Location = new System.Drawing.Point(428, 48);
            this.Floor2StaffListBox.Name = "Floor2StaffListBox";
            this.Floor2StaffListBox.Size = new System.Drawing.Size(192, 242);
            this.Floor2StaffListBox.TabIndex = 41;
            this.Floor2StaffListBox.SelectedIndexChanged += new System.EventHandler(this.Floor2StaffListBox_SelectedIndexChanged);
            // 
            // Floor3StaffListBox
            // 
            this.Floor3StaffListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Floor3StaffListBox.FormattingEnabled = true;
            this.Floor3StaffListBox.ItemHeight = 17;
            this.Floor3StaffListBox.Location = new System.Drawing.Point(641, 48);
            this.Floor3StaffListBox.Name = "Floor3StaffListBox";
            this.Floor3StaffListBox.Size = new System.Drawing.Size(192, 242);
            this.Floor3StaffListBox.TabIndex = 42;
            this.Floor3StaffListBox.SelectedIndexChanged += new System.EventHandler(this.Floor3StaffListBox_SelectedIndexChanged);
            // 
            // Floor1Label
            // 
            this.Floor1Label.AutoSize = true;
            this.Floor1Label.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.Floor1Label.ForeColor = System.Drawing.Color.Silver;
            this.Floor1Label.Location = new System.Drawing.Point(212, 23);
            this.Floor1Label.Name = "Floor1Label";
            this.Floor1Label.Size = new System.Drawing.Size(58, 20);
            this.Floor1Label.TabIndex = 43;
            this.Floor1Label.Text = "Floor 1";
            this.Floor1Label.Click += new System.EventHandler(this.Floor1Label_Click);
            // 
            // Floor2Label
            // 
            this.Floor2Label.AutoSize = true;
            this.Floor2Label.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.Floor2Label.ForeColor = System.Drawing.Color.Silver;
            this.Floor2Label.Location = new System.Drawing.Point(424, 23);
            this.Floor2Label.Name = "Floor2Label";
            this.Floor2Label.Size = new System.Drawing.Size(58, 20);
            this.Floor2Label.TabIndex = 44;
            this.Floor2Label.Text = "Floor 2";
            this.Floor2Label.Click += new System.EventHandler(this.Floor2Label_Click);
            // 
            // Floor3Label
            // 
            this.Floor3Label.AutoSize = true;
            this.Floor3Label.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.Floor3Label.ForeColor = System.Drawing.Color.Silver;
            this.Floor3Label.Location = new System.Drawing.Point(637, 23);
            this.Floor3Label.Name = "Floor3Label";
            this.Floor3Label.Size = new System.Drawing.Size(58, 20);
            this.Floor3Label.TabIndex = 45;
            this.Floor3Label.Text = "Floor 3";
            this.Floor3Label.Click += new System.EventHandler(this.Floor3Label_Click);
            // 
            // Auto_Assign_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(854, 374);
            this.Controls.Add(this.Floor3Label);
            this.Controls.Add(this.Floor2Label);
            this.Controls.Add(this.Floor1Label);
            this.Controls.Add(this.Floor3StaffListBox);
            this.Controls.Add(this.Floor2StaffListBox);
            this.Controls.Add(this.Floor1StaffListBox);
            this.Controls.Add(this.OnlyAvailableStaffCheckBox);
            this.Controls.Add(this.Floor3CheckBox);
            this.Controls.Add(this.Floor2CheckBox);
            this.Controls.Add(this.Floor1CheckBox);
            this.Controls.Add(this.GenerateCarersButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Auto_Assign_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlfaRota";
            this.Load += new System.EventHandler(this.Auto_Assign_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GenerateCarersButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.CheckBox Floor1CheckBox;
        private System.Windows.Forms.CheckBox Floor2CheckBox;
        private System.Windows.Forms.CheckBox Floor3CheckBox;
        private System.Windows.Forms.CheckBox OnlyAvailableStaffCheckBox;
        private System.Windows.Forms.ListBox Floor1StaffListBox;
        private System.Windows.Forms.ListBox Floor2StaffListBox;
        private System.Windows.Forms.ListBox Floor3StaffListBox;
        private System.Windows.Forms.Label Floor1Label;
        private System.Windows.Forms.Label Floor2Label;
        private System.Windows.Forms.Label Floor3Label;
    }
}