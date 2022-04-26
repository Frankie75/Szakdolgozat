﻿namespace Szakdolgozat
{
    partial class frmNewContract
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
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectVehicles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRentalFee = new System.Windows.Forms.TextBox();
            this.rtbNotesOut = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbNotesIn = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFuelLevelOut = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFuelLevelIn = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEndOfPeriod = new System.Windows.Forms.TextBox();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(386, 40);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(310, 102);
            this.btnSelectCustomer.TabIndex = 1;
            this.btnSelectCustomer.Text = "Ugyfel kivalasztasa";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ugyfel neve";
            // 
            // cbSelectVehicles
            // 
            this.cbSelectVehicles.FormattingEnabled = true;
            this.cbSelectVehicles.Location = new System.Drawing.Point(746, 53);
            this.cbSelectVehicles.Name = "cbSelectVehicles";
            this.cbSelectVehicles.Size = new System.Drawing.Size(440, 28);
            this.cbSelectVehicles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szabad gepjarmu kivalasztasa";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(26, 194);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(221, 26);
            this.dtpStart.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Berleti idoszak kezdete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Berleti idoszak vege";
            // 
            // dtpStop
            // 
            this.dtpStop.Location = new System.Drawing.Point(26, 283);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(221, 26);
            this.dtpStop.TabIndex = 8;
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(26, 348);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(184, 26);
            this.tbDeposit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kaucio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Berleti dij";
            // 
            // tbRentalFee
            // 
            this.tbRentalFee.Location = new System.Drawing.Point(26, 413);
            this.tbRentalFee.Name = "tbRentalFee";
            this.tbRentalFee.Size = new System.Drawing.Size(177, 26);
            this.tbRentalFee.TabIndex = 12;
            // 
            // rtbNotesOut
            // 
            this.rtbNotesOut.Location = new System.Drawing.Point(746, 137);
            this.rtbNotesOut.Name = "rtbNotesOut";
            this.rtbNotesOut.Size = new System.Drawing.Size(440, 214);
            this.rtbNotesOut.TabIndex = 13;
            this.rtbNotesOut.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Serulesek leirasa kiadaskor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Serulesek leirasa visszavetelkor";
            // 
            // rtbNotesIn
            // 
            this.rtbNotesIn.Location = new System.Drawing.Point(746, 447);
            this.rtbNotesIn.Name = "rtbNotesIn";
            this.rtbNotesIn.Size = new System.Drawing.Size(440, 214);
            this.rtbNotesIn.TabIndex = 16;
            this.rtbNotesIn.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Uzemanyag mennyisege kiadaskor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbFuelLevelOut
            // 
            this.cbFuelLevelOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelLevelOut.FormattingEnabled = true;
            this.cbFuelLevelOut.Items.AddRange(new object[] {
            "0% - 25%",
            "25% - 50%",
            "50% - 75%",
            "75% - 100%"});
            this.cbFuelLevelOut.Location = new System.Drawing.Point(323, 263);
            this.cbFuelLevelOut.Name = "cbFuelLevelOut";
            this.cbFuelLevelOut.Size = new System.Drawing.Size(251, 28);
            this.cbFuelLevelOut.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Uzemanyag mennyisege atvetelkor";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbFuelLevelIn
            // 
            this.cbFuelLevelIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelLevelIn.FormattingEnabled = true;
            this.cbFuelLevelIn.Location = new System.Drawing.Point(323, 346);
            this.cbFuelLevelIn.Name = "cbFuelLevelIn";
            this.cbFuelLevelIn.Size = new System.Drawing.Size(251, 28);
            this.cbFuelLevelIn.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Berleti idoszak varhato lejarata";
            // 
            // tbEndOfPeriod
            // 
            this.tbEndOfPeriod.Enabled = false;
            this.tbEndOfPeriod.Location = new System.Drawing.Point(323, 196);
            this.tbEndOfPeriod.Name = "tbEndOfPeriod";
            this.tbEndOfPeriod.Size = new System.Drawing.Size(251, 26);
            this.tbEndOfPeriod.TabIndex = 22;
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Enabled = false;
            this.tbCustomerAddress.Location = new System.Drawing.Point(26, 116);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(325, 26);
            this.tbCustomerAddress.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ugyfel cime";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 705);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(566, 121);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Rogzites";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(620, 705);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(566, 121);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Megsem";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Enabled = false;
            this.tbCustomerName.Location = new System.Drawing.Point(26, 53);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(325, 26);
            this.tbCustomerName.TabIndex = 27;
            // 
            // frmNewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 877);
            this.ControlBox = false;
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCustomerAddress);
            this.Controls.Add(this.tbEndOfPeriod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFuelLevelIn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFuelLevelOut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbNotesIn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbNotesOut);
            this.Controls.Add(this.tbRentalFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelectVehicles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmNewContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uj szerzodes keszitese";
            this.Load += new System.EventHandler(this.frmNewContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectVehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRentalFee;
        private System.Windows.Forms.RichTextBox rtbNotesOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbNotesIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFuelLevelOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFuelLevelIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEndOfPeriod;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbCustomerName;
    }
}