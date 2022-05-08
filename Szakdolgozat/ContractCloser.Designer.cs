namespace Szakdolgozat
{
    partial class frmContractCloser
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbFuelLevel = new System.Windows.Forms.ComboBox();
            this.tbOdometer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdditionalFee = new System.Windows.Forms.TextBox();
            this.btnCloseContract = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOfTheEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(449, 76);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(241, 299);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cbFuelLevel
            // 
            this.cbFuelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFuelLevel.FormattingEnabled = true;
            this.cbFuelLevel.Items.AddRange(new object[] {
            "0%-25%",
            "25%-50%",
            "50%-75%",
            "75%-100%"});
            this.cbFuelLevel.Location = new System.Drawing.Point(254, 105);
            this.cbFuelLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cbFuelLevel.Name = "cbFuelLevel";
            this.cbFuelLevel.Size = new System.Drawing.Size(137, 24);
            this.cbFuelLevel.TabIndex = 1;
            // 
            // tbOdometer
            // 
            this.tbOdometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOdometer.Location = new System.Drawing.Point(254, 57);
            this.tbOdometer.Margin = new System.Windows.Forms.Padding(2);
            this.tbOdometer.Name = "tbOdometer";
            this.tbOdometer.Size = new System.Drawing.Size(137, 23);
            this.tbOdometer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kilométeróra állása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üzemanyag mennyiség";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(446, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sérülések leírása, egyéb megjegyzés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(57, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Esetleges pótdíj összege";
            // 
            // tbAdditionalFee
            // 
            this.tbAdditionalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdditionalFee.Location = new System.Drawing.Point(254, 210);
            this.tbAdditionalFee.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdditionalFee.Name = "tbAdditionalFee";
            this.tbAdditionalFee.Size = new System.Drawing.Size(137, 23);
            this.tbAdditionalFee.TabIndex = 8;
            // 
            // btnCloseContract
            // 
            this.btnCloseContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCloseContract.Location = new System.Drawing.Point(60, 292);
            this.btnCloseContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseContract.Name = "btnCloseContract";
            this.btnCloseContract.Size = new System.Drawing.Size(121, 83);
            this.btnCloseContract.TabIndex = 9;
            this.btnCloseContract.Text = "Lezár";
            this.btnCloseContract.UseVisualStyleBackColor = true;
            this.btnCloseContract.Click += new System.EventHandler(this.btnCloseContract_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(270, 292);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 83);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(57, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Visszavétel dátuma";
            // 
            // dtpDateOfTheEnd
            // 
            this.dtpDateOfTheEnd.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dtpDateOfTheEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDateOfTheEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfTheEnd.Location = new System.Drawing.Point(254, 155);
            this.dtpDateOfTheEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfTheEnd.Name = "dtpDateOfTheEnd";
            this.dtpDateOfTheEnd.Size = new System.Drawing.Size(137, 23);
            this.dtpDateOfTheEnd.TabIndex = 12;
            // 
            // frmContractCloser
            // 
            this.AcceptButton = this.btnCloseContract;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(737, 421);
            this.ControlBox = false;
            this.Controls.Add(this.dtpDateOfTheEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCloseContract);
            this.Controls.Add(this.tbAdditionalFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOdometer);
            this.Controls.Add(this.cbFuelLevel);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmContractCloser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szerzodes lezarasa";
            this.Load += new System.EventHandler(this.ContractCloser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbFuelLevel;
        private System.Windows.Forms.TextBox tbOdometer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAdditionalFee;
        private System.Windows.Forms.Button btnCloseContract;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOfTheEnd;
    }
}