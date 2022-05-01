namespace NEA
{
    partial class Database_Details_Menu_Medication
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
            this.infoLbl3 = new System.Windows.Forms.Label();
            this.infoLbl2 = new System.Windows.Forms.Label();
            this.infoLbl1 = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLbl3
            // 
            this.infoLbl3.AutoSize = true;
            this.infoLbl3.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.infoLbl3.ForeColor = System.Drawing.Color.Silver;
            this.infoLbl3.Location = new System.Drawing.Point(42, 161);
            this.infoLbl3.Name = "infoLbl3";
            this.infoLbl3.Size = new System.Drawing.Size(47, 20);
            this.infoLbl3.TabIndex = 80;
            this.infoLbl3.Text = "Info3";
            this.infoLbl3.Click += new System.EventHandler(this.infoLbl3_Click);
            // 
            // infoLbl2
            // 
            this.infoLbl2.AutoSize = true;
            this.infoLbl2.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.infoLbl2.ForeColor = System.Drawing.Color.Silver;
            this.infoLbl2.Location = new System.Drawing.Point(42, 131);
            this.infoLbl2.Name = "infoLbl2";
            this.infoLbl2.Size = new System.Drawing.Size(47, 20);
            this.infoLbl2.TabIndex = 79;
            this.infoLbl2.Text = "Info2";
            this.infoLbl2.Click += new System.EventHandler(this.infoLbl2_Click);
            // 
            // infoLbl1
            // 
            this.infoLbl1.AutoSize = true;
            this.infoLbl1.Font = new System.Drawing.Font("Leelawadee UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.infoLbl1.ForeColor = System.Drawing.Color.Silver;
            this.infoLbl1.Location = new System.Drawing.Point(42, 101);
            this.infoLbl1.Name = "infoLbl1";
            this.infoLbl1.Size = new System.Drawing.Size(47, 20);
            this.infoLbl1.TabIndex = 78;
            this.infoLbl1.Text = "Info1";
            this.infoLbl1.Click += new System.EventHandler(this.infoLbl1_Click);
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Font = new System.Drawing.Font("Leelawadee UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.itemLbl.ForeColor = System.Drawing.Color.Silver;
            this.itemLbl.Location = new System.Drawing.Point(39, 34);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(78, 38);
            this.itemLbl.TabIndex = 77;
            this.itemLbl.Text = "Item";
            this.itemLbl.Click += new System.EventHandler(this.itemLbl_Click);
            // 
            // Database_Details_Menu_Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 221);
            this.Controls.Add(this.infoLbl3);
            this.Controls.Add(this.infoLbl2);
            this.Controls.Add(this.infoLbl1);
            this.Controls.Add(this.itemLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Database_Details_Menu_Medication";
            this.Text = "AlfaRota";
            this.Load += new System.EventHandler(this.Database_Details_Menu_Medication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label infoLbl3;
        private System.Windows.Forms.Label infoLbl2;
        private System.Windows.Forms.Label infoLbl1;
        private System.Windows.Forms.Label itemLbl;
    }
}