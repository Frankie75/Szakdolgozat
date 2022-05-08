namespace Szakdolgozat
{
    partial class frmCutomerDataInputForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.gbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOK.Location = new System.Drawing.Point(481, 118);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(151, 62);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(481, 287);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 62);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(167, 91);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(175, 23);
            this.tbName.TabIndex = 2;
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(57, 95);
            this.lblNev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(37, 17);
            this.lblNev.TabIndex = 3;
            this.lblNev.Text = "Név:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(57, 140);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(93, 17);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Telefonszám:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(57, 183);
            this.lblPostCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(91, 17);
            this.lblPostCode.TabIndex = 5;
            this.lblPostCode.Text = "Iranyítószám:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(57, 221);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(63, 17);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Helység:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(57, 264);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(35, 17);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Cím:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 305);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(167, 137);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(175, 23);
            this.tbPhoneNumber.TabIndex = 9;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Location = new System.Drawing.Point(167, 179);
            this.tbPostCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(175, 23);
            this.tbPostCode.TabIndex = 10;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(167, 217);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(175, 23);
            this.tbCity.TabIndex = 11;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(167, 260);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(175, 23);
            this.tbAddress.TabIndex = 12;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(167, 301);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(175, 23);
            this.tbEmail.TabIndex = 13;
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.tbPostCode);
            this.gbUsers.Controls.Add(this.tbEmail);
            this.gbUsers.Controls.Add(this.tbName);
            this.gbUsers.Controls.Add(this.tbAddress);
            this.gbUsers.Controls.Add(this.lblNev);
            this.gbUsers.Controls.Add(this.tbCity);
            this.gbUsers.Controls.Add(this.lblPhoneNumber);
            this.gbUsers.Controls.Add(this.lblPostCode);
            this.gbUsers.Controls.Add(this.tbPhoneNumber);
            this.gbUsers.Controls.Add(this.lblCity);
            this.gbUsers.Controls.Add(this.lblEmail);
            this.gbUsers.Controls.Add(this.lblAddress);
            this.gbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbUsers.Location = new System.Drawing.Point(36, 27);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(2);
            this.gbUsers.Size = new System.Drawing.Size(395, 409);
            this.gbUsers.TabIndex = 14;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Ügyfél adatai";
            // 
            // frmCutomerDataInputForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(670, 467);
            this.ControlBox = false;
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCutomerDataInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ügyfél adatai";
            this.Load += new System.EventHandler(this.frmCutomerDataInputForm_Load);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox gbUsers;
    }
}