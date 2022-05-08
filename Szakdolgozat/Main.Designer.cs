namespace Szakdolgozat
{
    partial class formMain
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujSzerzodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfeltorzsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszkozokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasznaloAdminisztracioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beallitasokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewContract = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCloseContract = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOnline = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnCont = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvMain.Location = new System.Drawing.Point(215, 126);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMain.RowTemplate.Height = 28;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(926, 279);
            this.dgvMain.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Sorszam";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ugyfel neve";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ugyfel cime";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kiberelt eszkoz";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Rendszam";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Kiadas datuma";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Lejarat datuma";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Visszavet datuma";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Minden szerzodes",
            "Aktiv (folyamatban levo)",
            "Lezart",
            "Archivalt"});
            this.cbFilter.Location = new System.Drawing.Point(215, 94);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(369, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.DropDownClosed += new System.EventHandler(this.cbFilter_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szuresi feltetel kivalsztasa";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(893, 94);
            this.tbSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(250, 20);
            this.tbSearchName.TabIndex = 5;
            this.tbSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchName_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kereses";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(48, 512);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilepesToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.beallitasokToolStripMenuItem,
            this.kilepesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1228, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujSzerzodesToolStripMenuItem});
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.kilepesToolStripMenuItem.Text = "Szerződések";
            // 
            // ujSzerzodesToolStripMenuItem
            // 
            this.ujSzerzodesToolStripMenuItem.Name = "ujSzerzodesToolStripMenuItem";
            this.ujSzerzodesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ujSzerzodesToolStripMenuItem.Text = "Új szerződés";
            this.ujSzerzodesToolStripMenuItem.Click += new System.EventHandler(this.ujSzerzodesToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugyfeltorzsToolStripMenuItem,
            this.eszkozokToolStripMenuItem,
            this.felhasznaloAdminisztracioToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.adminToolStripMenuItem.Text = "Adminisztráció";
            // 
            // ugyfeltorzsToolStripMenuItem
            // 
            this.ugyfeltorzsToolStripMenuItem.Name = "ugyfeltorzsToolStripMenuItem";
            this.ugyfeltorzsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ugyfeltorzsToolStripMenuItem.Text = "Ügyfelek";
            this.ugyfeltorzsToolStripMenuItem.Click += new System.EventHandler(this.ugyfeltorzsToolStripMenuItem_Click);
            // 
            // eszkozokToolStripMenuItem
            // 
            this.eszkozokToolStripMenuItem.Name = "eszkozokToolStripMenuItem";
            this.eszkozokToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eszkozokToolStripMenuItem.Text = "Gépjárművek";
            this.eszkozokToolStripMenuItem.Click += new System.EventHandler(this.eszkozokToolStripMenuItem_Click);
            // 
            // felhasznaloAdminisztracioToolStripMenuItem
            // 
            this.felhasznaloAdminisztracioToolStripMenuItem.Name = "felhasznaloAdminisztracioToolStripMenuItem";
            this.felhasznaloAdminisztracioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.felhasznaloAdminisztracioToolStripMenuItem.Text = "Felhasználók";
            this.felhasznaloAdminisztracioToolStripMenuItem.Click += new System.EventHandler(this.felhasznaloAdminisztracioToolStripMenuItem_Click);
            // 
            // beallitasokToolStripMenuItem
            // 
            this.beallitasokToolStripMenuItem.Name = "beallitasokToolStripMenuItem";
            this.beallitasokToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.beallitasokToolStripMenuItem.Text = "Beállítások";
            this.beallitasokToolStripMenuItem.Click += new System.EventHandler(this.btsSettings_Click);
            // 
            // kilepesToolStripMenuItem1
            // 
            this.kilepesToolStripMenuItem1.Name = "kilepesToolStripMenuItem1";
            this.kilepesToolStripMenuItem1.Size = new System.Drawing.Size(56, 22);
            this.kilepesToolStripMenuItem1.Text = "Kilépés";
            this.kilepesToolStripMenuItem1.Click += new System.EventHandler(this.kilepesToolStripMenuItem1_Click);
            // 
            // btnNewContract
            // 
            this.btnNewContract.Location = new System.Drawing.Point(215, 441);
            this.btnNewContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewContract.Name = "btnNewContract";
            this.btnNewContract.Size = new System.Drawing.Size(127, 88);
            this.btnNewContract.TabIndex = 9;
            this.btnNewContract.Text = "Uj szerzodes";
            this.btnNewContract.UseVisualStyleBackColor = true;
            this.btnNewContract.Click += new System.EventHandler(this.ujSzerzodesToolStripMenuItem_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Location = new System.Drawing.Point(48, 330);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(155, 40);
            this.btnVehicles.TabIndex = 11;
            this.btnVehicles.Text = "Gépjárművek listája";
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.eszkozokToolStripMenuItem_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(48, 396);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(155, 40);
            this.btnUsers.TabIndex = 12;
            this.btnUsers.Text = "Felhasználók";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.felhasznaloAdminisztracioToolStripMenuItem_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(48, 440);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(155, 40);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Beállítások";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btsSettings_Click);
            // 
            // btnCloseContract
            // 
            this.btnCloseContract.Location = new System.Drawing.Point(373, 441);
            this.btnCloseContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseContract.Name = "btnCloseContract";
            this.btnCloseContract.Size = new System.Drawing.Size(129, 40);
            this.btnCloseContract.TabIndex = 14;
            this.btnCloseContract.Text = "Szerzodes lezarasa";
            this.btnCloseContract.UseVisualStyleBackColor = true;
            this.btnCloseContract.Click += new System.EventHandler(this.btnCloseContract_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(373, 489);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 40);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Nyomtatas";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnOnline
            // 
            this.btnOnline.Location = new System.Drawing.Point(521, 441);
            this.btnOnline.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(149, 86);
            this.btnOnline.TabIndex = 16;
            this.btnOnline.Text = "Online felulet";
            this.btnOnline.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMenu.Controls.Add(this.label5);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.btnCont);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnVehicles);
            this.pnlMenu.Controls.Add(this.btnUsers);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 24);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(247, 580);
            this.pnlMenu.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 47);
            this.label3.TabIndex = 8;
            this.label3.Text = "Car-RentAll";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Szakdolgozat.Properties.Resources.logo_kis;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 129);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ügyféltörzs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ugyfeltorzsToolStripMenuItem_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(247, 24);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(981, 580);
            this.pnlForm.TabIndex = 17;
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(48, 241);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(155, 40);
            this.btnCont.TabIndex = 14;
            this.btnCont.Text = "Szerződések";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "www.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(210, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = ".net";
            // 
            // formMain
            // 
            this.AcceptButton = this.btnNewContract;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1228, 604);
            this.ControlBox = false;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCloseContract);
            this.Controls.Add(this.btnNewContract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarRent-All Ugyviteli rendszer";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasznaloAdminisztracioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ujSzerzodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfeltorzsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszkozokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beallitasokToolStripMenuItem;
        private System.Windows.Forms.Button btnNewContract;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCloseContract;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

