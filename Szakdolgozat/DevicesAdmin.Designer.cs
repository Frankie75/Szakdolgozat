namespace Szakdolgozat
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
            this.dgvDeviceList = new System.Windows.Forms.DataGridView();
            this.Rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gyartmany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alvaszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSearchByType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCarPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opciokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujGepjarmuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivalastottTorleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewDevice
            // 
            this.btnNewDevice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNewDevice.FlatAppearance.BorderSize = 0;
            this.btnNewDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewDevice.ForeColor = System.Drawing.Color.White;
            this.btnNewDevice.Location = new System.Drawing.Point(49, 172);
            this.btnNewDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewDevice.Name = "btnNewDevice";
            this.btnNewDevice.Size = new System.Drawing.Size(223, 53);
            this.btnNewDevice.TabIndex = 0;
            this.btnNewDevice.Text = "Új gépjármű";
            this.btnNewDevice.UseVisualStyleBackColor = false;
            this.btnNewDevice.Click += new System.EventHandler(this.btnNewDevice_Click);
            // 
            // btnEditDevice
            // 
            this.btnEditDevice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditDevice.FlatAppearance.BorderSize = 0;
            this.btnEditDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditDevice.ForeColor = System.Drawing.Color.White;
            this.btnEditDevice.Location = new System.Drawing.Point(49, 241);
            this.btnEditDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditDevice.Name = "btnEditDevice";
            this.btnEditDevice.Size = new System.Drawing.Size(223, 53);
            this.btnEditDevice.TabIndex = 1;
            this.btnEditDevice.Text = "Gépjármű adatainak szerkesztése";
            this.btnEditDevice.UseVisualStyleBackColor = false;
            this.btnEditDevice.Click += new System.EventHandler(this.btnEditDevice_Click);
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteDevice.FlatAppearance.BorderSize = 0;
            this.btnDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteDevice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDevice.Location = new System.Drawing.Point(49, 311);
            this.btnDeleteDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(223, 53);
            this.btnDeleteDevice.TabIndex = 2;
            this.btnDeleteDevice.Text = "Gépjármű törlése";
            this.btnDeleteDevice.UseVisualStyleBackColor = false;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // dgvDeviceList
            // 
            this.dgvDeviceList.AllowUserToAddRows = false;
            this.dgvDeviceList.AllowUserToDeleteRows = false;
            this.dgvDeviceList.AllowUserToResizeColumns = false;
            this.dgvDeviceList.AllowUserToResizeRows = false;
            this.dgvDeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeviceList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDeviceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rendszam,
            this.Gyartmany,
            this.Tipus,
            this.Alvaszam,
            this.Kategoria,
            this.Id,
            this.Picture});
            this.dgvDeviceList.Location = new System.Drawing.Point(14, 103);
            this.dgvDeviceList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeviceList.Name = "dgvDeviceList";
            this.dgvDeviceList.ReadOnly = true;
            this.dgvDeviceList.RowHeadersVisible = false;
            this.dgvDeviceList.RowHeadersWidth = 62;
            this.dgvDeviceList.RowTemplate.Height = 28;
            this.dgvDeviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeviceList.Size = new System.Drawing.Size(520, 393);
            this.dgvDeviceList.TabIndex = 4;
            this.dgvDeviceList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeviceList_RowEnter);
            // 
            // Rendszam
            // 
            this.Rendszam.HeaderText = "Rendszám";
            this.Rendszam.MinimumWidth = 8;
            this.Rendszam.Name = "Rendszam";
            this.Rendszam.ReadOnly = true;
            // 
            // Gyartmany
            // 
            this.Gyartmany.HeaderText = "Gyártmány";
            this.Gyartmany.MinimumWidth = 8;
            this.Gyartmany.Name = "Gyartmany";
            this.Gyartmany.ReadOnly = true;
            // 
            // Tipus
            // 
            this.Tipus.HeaderText = "Típus";
            this.Tipus.MinimumWidth = 8;
            this.Tipus.Name = "Tipus";
            this.Tipus.ReadOnly = true;
            // 
            // Alvaszam
            // 
            this.Alvaszam.HeaderText = "Alvázszám";
            this.Alvaszam.MinimumWidth = 8;
            this.Alvaszam.Name = "Alvaszam";
            this.Alvaszam.ReadOnly = true;
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "Kategória";
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
            // Picture
            // 
            this.Picture.HeaderText = "Column1";
            this.Picture.MinimumWidth = 8;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearchByType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvDeviceList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(387, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(591, 500);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gépjárművek listája";
            // 
            // tbSearchByType
            // 
            this.tbSearchByType.BackColor = System.Drawing.Color.LightGray;
            this.tbSearchByType.Location = new System.Drawing.Point(361, 47);
            this.tbSearchByType.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchByType.Name = "tbSearchByType";
            this.tbSearchByType.Size = new System.Drawing.Size(173, 23);
            this.tbSearchByType.TabIndex = 6;
            this.tbSearchByType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchByType_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategória:";
            // 
            // cbCategories
            // 
            this.cbCategories.BackColor = System.Drawing.Color.LightGray;
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(88, 50);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(108, 24);
            this.cbCategories.TabIndex = 7;
            this.cbCategories.DropDownClosed += new System.EventHandler(this.cbCategories_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Keresés típus szerint:";
            // 
            // pbCarPicture
            // 
            this.pbCarPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCarPicture.Location = new System.Drawing.Point(49, 442);
            this.pbCarPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbCarPicture.Name = "pbCarPicture";
            this.pbCarPicture.Size = new System.Drawing.Size(224, 142);
            this.pbCarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarPicture.TabIndex = 6;
            this.pbCarPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opciokToolStripMenuItem,
            this.bezarasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // opciokToolStripMenuItem
            // 
            this.opciokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujGepjarmuToolStripMenuItem,
            this.szerkesztesToolStripMenuItem,
            this.kivalastottTorleseToolStripMenuItem});
            this.opciokToolStripMenuItem.Name = "opciokToolStripMenuItem";
            this.opciokToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.opciokToolStripMenuItem.Text = "Opciok";
            // 
            // ujGepjarmuToolStripMenuItem
            // 
            this.ujGepjarmuToolStripMenuItem.Name = "ujGepjarmuToolStripMenuItem";
            this.ujGepjarmuToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ujGepjarmuToolStripMenuItem.Text = "Uj gepjarmu";
            this.ujGepjarmuToolStripMenuItem.Click += new System.EventHandler(this.btnNewDevice_Click);
            // 
            // szerkesztesToolStripMenuItem
            // 
            this.szerkesztesToolStripMenuItem.Name = "szerkesztesToolStripMenuItem";
            this.szerkesztesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.szerkesztesToolStripMenuItem.Text = "Szerkesztes";
            this.szerkesztesToolStripMenuItem.Click += new System.EventHandler(this.btnEditDevice_Click);
            // 
            // kivalastottTorleseToolStripMenuItem
            // 
            this.kivalastottTorleseToolStripMenuItem.Name = "kivalastottTorleseToolStripMenuItem";
            this.kivalastottTorleseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kivalastottTorleseToolStripMenuItem.Text = "Kivalastott torlese";
            this.kivalastottTorleseToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // bezarasToolStripMenuItem
            // 
            this.bezarasToolStripMenuItem.Name = "bezarasToolStripMenuItem";
            this.bezarasToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.bezarasToolStripMenuItem.Text = "Bezaras";
            this.bezarasToolStripMenuItem.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 71);
            this.panel1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gépjárművek listája";
            // 
            // pnlBackground
            // 
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1093, 708);
            this.pnlBackground.TabIndex = 36;
            // 
            // frmDevicesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1049, 691);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbCarPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteDevice);
            this.Controls.Add(this.btnEditDevice);
            this.Controls.Add(this.btnNewDevice);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDevicesAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.DevicesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewDevice;
        private System.Windows.Forms.Button btnEditDevice;
        private System.Windows.Forms.Button btnDeleteDevice;
        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TextBox tbSearchByType;
        private System.Windows.Forms.PictureBox pbCarPicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opciokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujGepjarmuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivalastottTorleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezarasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gyartmany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alvaszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBackground;
    }
}