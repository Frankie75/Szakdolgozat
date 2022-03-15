﻿namespace Szakdolgozat
{
    partial class frmDevicesAdmin
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
            this.btnNewDevice = new System.Windows.Forms.Button();
            this.btnEditDevice = new System.Windows.Forms.Button();
            this.btnDeleteDevice = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.dgvDeviceList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchByType = new System.Windows.Forms.TextBox();
            this.Rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gyartmany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alvaszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewDevice
            // 
            this.btnNewDevice.Location = new System.Drawing.Point(73, 74);
            this.btnNewDevice.Name = "btnNewDevice";
            this.btnNewDevice.Size = new System.Drawing.Size(334, 81);
            this.btnNewDevice.TabIndex = 0;
            this.btnNewDevice.Text = "Uj gepjarmu";
            this.btnNewDevice.UseVisualStyleBackColor = true;
            // 
            // btnEditDevice
            // 
            this.btnEditDevice.Location = new System.Drawing.Point(73, 161);
            this.btnEditDevice.Name = "btnEditDevice";
            this.btnEditDevice.Size = new System.Drawing.Size(334, 81);
            this.btnEditDevice.TabIndex = 1;
            this.btnEditDevice.Text = "Gepjarmu adatainak szerkesztes";
            this.btnEditDevice.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.Location = new System.Drawing.Point(73, 248);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(334, 81);
            this.btnDeleteDevice.TabIndex = 2;
            this.btnDeleteDevice.Text = "Gepjarmu torlese";
            this.btnDeleteDevice.UseVisualStyleBackColor = true;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(73, 385);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(334, 81);
            this.btnCloseWindow.TabIndex = 3;
            this.btnCloseWindow.Text = "Bezar";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // dgvDeviceList
            // 
            this.dgvDeviceList.AllowUserToAddRows = false;
            this.dgvDeviceList.AllowUserToDeleteRows = false;
            this.dgvDeviceList.AllowUserToResizeColumns = false;
            this.dgvDeviceList.AllowUserToResizeRows = false;
            this.dgvDeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rendszam,
            this.Gyartmany,
            this.Tipus,
            this.Alvaszam,
            this.Kategoria,
            this.Id});
            this.dgvDeviceList.Location = new System.Drawing.Point(21, 87);
            this.dgvDeviceList.Name = "dgvDeviceList";
            this.dgvDeviceList.ReadOnly = true;
            this.dgvDeviceList.RowHeadersVisible = false;
            this.dgvDeviceList.RowHeadersWidth = 62;
            this.dgvDeviceList.RowTemplate.Height = 28;
            this.dgvDeviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeviceList.Size = new System.Drawing.Size(780, 305);
            this.dgvDeviceList.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearchByType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvDeviceList);
            this.groupBox1.Location = new System.Drawing.Point(637, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 471);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gepjarmuvek listaja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kereses tipus szerint:";
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(104, 30);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(160, 28);
            this.cbCategories.TabIndex = 7;
            this.cbCategories.SelectionChangeCommitted += new System.EventHandler(this.cbCategories_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategoria:";
            // 
            // tbSearchByType
            // 
            this.tbSearchByType.Location = new System.Drawing.Point(544, 30);
            this.tbSearchByType.Name = "tbSearchByType";
            this.tbSearchByType.Size = new System.Drawing.Size(257, 26);
            this.tbSearchByType.TabIndex = 6;
            this.tbSearchByType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchByType_KeyUp);
            // 
            // Rendszam
            // 
            this.Rendszam.HeaderText = "Rendszam";
            this.Rendszam.MinimumWidth = 8;
            this.Rendszam.Name = "Rendszam";
            this.Rendszam.ReadOnly = true;
            // 
            // Gyartmany
            // 
            this.Gyartmany.HeaderText = "Gyartmany";
            this.Gyartmany.MinimumWidth = 8;
            this.Gyartmany.Name = "Gyartmany";
            this.Gyartmany.ReadOnly = true;
            // 
            // Tipus
            // 
            this.Tipus.HeaderText = "Tipus";
            this.Tipus.MinimumWidth = 8;
            this.Tipus.Name = "Tipus";
            this.Tipus.ReadOnly = true;
            // 
            // Alvaszam
            // 
            this.Alvaszam.HeaderText = "Alvaszam";
            this.Alvaszam.MinimumWidth = 8;
            this.Alvaszam.Name = "Alvaszam";
            this.Alvaszam.ReadOnly = true;
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.MinimumWidth = 8;
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // frmDevicesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnDeleteDevice);
            this.Controls.Add(this.btnEditDevice);
            this.Controls.Add(this.btnNewDevice);
            this.Name = "frmDevicesAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gepjarmuvek listaja";
            this.Load += new System.EventHandler(this.DevicesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewDevice;
        private System.Windows.Forms.Button btnEditDevice;
        private System.Windows.Forms.Button btnDeleteDevice;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TextBox tbSearchByType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gyartmany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alvaszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}