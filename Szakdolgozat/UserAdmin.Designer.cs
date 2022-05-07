namespace Szakdolgozat
{
    partial class frmUserAdmin
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
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.tbPasswordNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.tbPasswordAgain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Felhasznalok = new System.Windows.Forms.ListBox();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(183, 53);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(292, 65);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Uj felhasznalo hozzaadasa";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(183, 124);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(292, 65);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Felhasznalo torlese";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(183, 195);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(292, 65);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Jelszo modositasa";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(183, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(292, 65);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Bezar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Location = new System.Drawing.Point(10, 53);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(278, 26);
            this.tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(10, 105);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 26);
            this.tbPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Felhasznalonev:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jelszo:";
            // 
            // btnAction
            // 
            this.btnAction.Enabled = false;
            this.btnAction.Location = new System.Drawing.Point(6, 289);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(292, 65);
            this.btnAction.TabIndex = 8;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tbPasswordNew
            // 
            this.tbPasswordNew.Enabled = false;
            this.tbPasswordNew.Location = new System.Drawing.Point(10, 245);
            this.tbPasswordNew.Name = "tbPasswordNew";
            this.tbPasswordNew.PasswordChar = '*';
            this.tbPasswordNew.Size = new System.Drawing.Size(100, 26);
            this.tbPasswordNew.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Uj jelszo:";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.tbPasswordAgain);
            this.gbAction.Controls.Add(this.label4);
            this.gbAction.Controls.Add(this.label1);
            this.gbAction.Controls.Add(this.label3);
            this.gbAction.Controls.Add(this.tbUserName);
            this.gbAction.Controls.Add(this.tbPasswordNew);
            this.gbAction.Controls.Add(this.label2);
            this.gbAction.Controls.Add(this.btnAction);
            this.gbAction.Controls.Add(this.tbPassword);
            this.gbAction.Location = new System.Drawing.Point(567, 23);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(803, 442);
            this.gbAction.TabIndex = 11;
            this.gbAction.TabStop = false;
            // 
            // tbPasswordAgain
            // 
            this.tbPasswordAgain.Enabled = false;
            this.tbPasswordAgain.Location = new System.Drawing.Point(10, 157);
            this.tbPasswordAgain.Name = "tbPasswordAgain";
            this.tbPasswordAgain.PasswordChar = '*';
            this.tbPasswordAgain.Size = new System.Drawing.Size(100, 26);
            this.tbPasswordAgain.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jelszo ujra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1010, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aktiv felhasznalok";
            // 
            // Felhasznalok
            // 
            this.Felhasznalok.Enabled = false;
            this.Felhasznalok.FormattingEnabled = true;
            this.Felhasznalok.ItemHeight = 20;
            this.Felhasznalok.Location = new System.Drawing.Point(1014, 53);
            this.Felhasznalok.Name = "Felhasznalok";
            this.Felhasznalok.Size = new System.Drawing.Size(316, 384);
            this.Felhasznalok.Sorted = true;
            this.Felhasznalok.TabIndex = 14;
            this.Felhasznalok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Felhasznalok_MouseDoubleClick);
            this.Felhasznalok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Felhasznalok_MouseDoubleClick);
            // 
            // frmUserAdmin
            // 
            this.AcceptButton = this.btnAddNewUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1446, 550);
            this.ControlBox = false;
            this.Controls.Add(this.Felhasznalok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUserAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felhasznalo Adminisztracio";
            this.Load += new System.EventHandler(this.frmUserAdmin_Load);
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox tbPasswordNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.TextBox tbPasswordAgain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Felhasznalok;
    }
}