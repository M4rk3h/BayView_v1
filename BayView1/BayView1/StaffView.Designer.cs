﻿namespace BayView1
{
    partial class StaffView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffView));
            this.btnOldCust = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SysTimeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BJTimeLbl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOldCust
            // 
            this.btnOldCust.Location = new System.Drawing.Point(48, 444);
            this.btnOldCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOldCust.Name = "btnOldCust";
            this.btnOldCust.Size = new System.Drawing.Size(140, 30);
            this.btnOldCust.TabIndex = 2;
            this.btnOldCust.Text = "Customers OLD";
            this.btnOldCust.UseVisualStyleBackColor = true;
            this.btnOldCust.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(303, 71);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(180, 180);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Booking Rooms";
            this.btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(227, 444);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(140, 30);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "welcome label";
            // 
            // SysTimeLbl
            // 
            this.SysTimeLbl.AutoSize = true;
            this.SysTimeLbl.Location = new System.Drawing.Point(185, 304);
            this.SysTimeLbl.Name = "SysTimeLbl";
            this.SysTimeLbl.Size = new System.Drawing.Size(46, 17);
            this.SysTimeLbl.TabIndex = 6;
            this.SysTimeLbl.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Beijing Time:";
            // 
            // BJTimeLbl
            // 
            this.BJTimeLbl.AutoSize = true;
            this.BJTimeLbl.Location = new System.Drawing.Point(185, 338);
            this.BJTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BJTimeLbl.Name = "BJTimeLbl";
            this.BJTimeLbl.Size = new System.Drawing.Size(46, 17);
            this.BJTimeLbl.TabIndex = 8;
            this.BJTimeLbl.Text = "label4";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 444);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(48, 71);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(180, 180);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 485);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BJTimeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SysTimeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnOldCust);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOldCust;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SysTimeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BJTimeLbl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCustomers;
    }
}