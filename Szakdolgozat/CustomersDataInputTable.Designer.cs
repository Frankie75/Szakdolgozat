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
            this.btnOK.Location = new System.Drawing.Point(40, 573);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(226, 96);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(337, 573);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(226, 96);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Megse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(203, 54);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(261, 26);
            this.tbName.TabIndex = 2;
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(38, 60);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(40, 20);
            this.lblNev.TabIndex = 3;
            this.lblNev.Text = "Nev:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(38, 130);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(104, 20);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Telefonszam:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(38, 195);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(103, 20);
            this.lblPostCode.TabIndex = 5;
            this.lblPostCode.Text = "Iranyitoszam:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(38, 254);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(70, 20);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Helyseg:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(38, 320);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 20);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Cim:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(38, 383);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(203, 124);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(261, 26);
            this.tbPhoneNumber.TabIndex = 9;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Location = new System.Drawing.Point(203, 189);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(261, 26);
            this.tbPostCode.TabIndex = 10;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(203, 248);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(261, 26);
            this.tbCity.TabIndex = 11;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(203, 314);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(261, 26);
            this.tbAddress.TabIndex = 12;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(203, 377);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(261, 26);
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
            this.gbUsers.Location = new System.Drawing.Point(40, 51);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(523, 463);
            this.gbUsers.TabIndex = 14;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Ugyfel adatai:";
            // 
            // frmCutomerDataInputForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(627, 740);
            this.ControlBox = false;
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCutomerDataInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ugyfeladatok";
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