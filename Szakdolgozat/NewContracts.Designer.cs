namespace Szakdolgozat
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbFuelLevelOut = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbOdometerStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSelectCustomer.Location = new System.Drawing.Point(412, 86);
            this.btnSelectCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(174, 81);
            this.btnSelectCustomer.TabIndex = 1;
            this.btnSelectCustomer.Text = "Ügyfél kiválasztása";
            this.btnSelectCustomer.UseVisualStyleBackColor = false;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ügyfél neve";
            // 
            // cbSelectVehicles
            // 
            this.cbSelectVehicles.BackColor = System.Drawing.Color.LightGray;
            this.cbSelectVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSelectVehicles.FormattingEnabled = true;
            this.cbSelectVehicles.Location = new System.Drawing.Point(610, 229);
            this.cbSelectVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectVehicles.Name = "cbSelectVehicles";
            this.cbSelectVehicles.Size = new System.Drawing.Size(392, 24);
            this.cbSelectVehicles.TabIndex = 3;
            this.cbSelectVehicles.SelectedIndexChanged += new System.EventHandler(this.cbSelectVehicles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(608, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szabad gépjármű kiválasztása";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpStart.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.dtpStart.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(611, 156);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.MinDate = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpStart.Size = new System.Drawing.Size(197, 23);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.Value = new System.DateTime(2022, 5, 1, 13, 2, 25, 0);
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(609, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bérleti időszak kezdete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(38, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "KIlométeróra állása kiadáskor";
            // 
            // dtpStop
            // 
            this.dtpStop.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpStop.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.dtpStop.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dtpStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStop.Location = new System.Drawing.Point(610, 86);
            this.dtpStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStop.MinDate = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(197, 23);
            this.dtpStop.TabIndex = 8;
            this.dtpStop.Value = new System.DateTime(2022, 4, 29, 0, 0, 0, 0);
            // 
            // tbDeposit
            // 
            this.tbDeposit.BackColor = System.Drawing.Color.LightGray;
            this.tbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDeposit.Location = new System.Drawing.Point(39, 207);
            this.tbDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(197, 23);
            this.tbDeposit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(37, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kaució";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(39, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bérleti díj";
            // 
            // tbRentalFee
            // 
            this.tbRentalFee.BackColor = System.Drawing.Color.LightGray;
            this.tbRentalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRentalFee.Location = new System.Drawing.Point(41, 445);
            this.tbRentalFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRentalFee.Name = "tbRentalFee";
            this.tbRentalFee.Size = new System.Drawing.Size(224, 23);
            this.tbRentalFee.TabIndex = 12;
            // 
            // rtbNotesOut
            // 
            this.rtbNotesOut.BackColor = System.Drawing.Color.LightGray;
            this.rtbNotesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbNotesOut.Location = new System.Drawing.Point(610, 315);
            this.rtbNotesOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbNotesOut.Name = "rtbNotesOut";
            this.rtbNotesOut.Size = new System.Drawing.Size(392, 171);
            this.rtbNotesOut.TabIndex = 13;
            this.rtbNotesOut.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(608, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sérülések kiadáskor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(39, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Üzemanyag mennyisége kiadáskor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbFuelLevelOut
            // 
            this.cbFuelLevelOut.BackColor = System.Drawing.Color.LightGray;
            this.cbFuelLevelOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelLevelOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFuelLevelOut.FormattingEnabled = true;
            this.cbFuelLevelOut.Items.AddRange(new object[] {
            "0% - 25%",
            "25% - 50%",
            "50% - 75%",
            "75% - 100%"});
            this.cbFuelLevelOut.Location = new System.Drawing.Point(41, 378);
            this.cbFuelLevelOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFuelLevelOut.Name = "cbFuelLevelOut";
            this.cbFuelLevelOut.Size = new System.Drawing.Size(224, 24);
            this.cbFuelLevelOut.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(608, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Bérleti időszak várható lejárata";
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.BackColor = System.Drawing.Color.LightGray;
            this.tbCustomerAddress.Enabled = false;
            this.tbCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCustomerAddress.Location = new System.Drawing.Point(40, 144);
            this.tbCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(346, 23);
            this.tbCustomerAddress.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(38, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ügyfél címe";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(39, 566);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(392, 97);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Rögzítés";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(610, 566);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(392, 97);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Mégsem";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BackColor = System.Drawing.Color.LightGray;
            this.tbCustomerName.Enabled = false;
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCustomerName.Location = new System.Drawing.Point(39, 86);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(346, 23);
            this.tbCustomerName.TabIndex = 27;
            // 
            // tbOdometerStart
            // 
            this.tbOdometerStart.BackColor = System.Drawing.Color.LightGray;
            this.tbOdometerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOdometerStart.Location = new System.Drawing.Point(40, 291);
            this.tbOdometerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOdometerStart.Name = "tbOdometerStart";
            this.tbOdometerStart.Size = new System.Drawing.Size(224, 23);
            this.tbOdometerStart.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(243, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ft";
            // 
            // frmNewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 691);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOdometerStart);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCustomerAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFuelLevelOut);
            this.Controls.Add(this.label9);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFuelLevelOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbOdometerStart;
        private System.Windows.Forms.Label label8;
    }
}