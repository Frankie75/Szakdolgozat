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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvMain.Location = new System.Drawing.Point(56, 347);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 28;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1407, 429);
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
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(56, 221);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(390, 28);
            this.cbFilter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szuresi feltetel kivalsztasa";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(1028, 223);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(391, 26);
            this.tbSearchName.TabIndex = 5;
            this.tbSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchName_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1024, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kereses";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1295, 57);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 71);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Kilepes";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilepesToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.beallitasokToolStripMenuItem,
            this.kilepesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1699, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujSzerzodesToolStripMenuItem});
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.kilepesToolStripMenuItem.Text = "Szerzodesek";
            // 
            // ujSzerzodesToolStripMenuItem
            // 
            this.ujSzerzodesToolStripMenuItem.Name = "ujSzerzodesToolStripMenuItem";
            this.ujSzerzodesToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.ujSzerzodesToolStripMenuItem.Text = "Uj szerzodes";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugyfeltorzsToolStripMenuItem,
            this.eszkozokToolStripMenuItem,
            this.felhasznaloAdminisztracioToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.adminToolStripMenuItem.Text = "Adminisztracio";
            // 
            // ugyfeltorzsToolStripMenuItem
            // 
            this.ugyfeltorzsToolStripMenuItem.Name = "ugyfeltorzsToolStripMenuItem";
            this.ugyfeltorzsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ugyfeltorzsToolStripMenuItem.Text = "Ugyfelek";
            this.ugyfeltorzsToolStripMenuItem.Click += new System.EventHandler(this.ugyfeltorzsToolStripMenuItem_Click);
            // 
            // eszkozokToolStripMenuItem
            // 
            this.eszkozokToolStripMenuItem.Name = "eszkozokToolStripMenuItem";
            this.eszkozokToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eszkozokToolStripMenuItem.Text = "Gepjarmuvek";
            this.eszkozokToolStripMenuItem.Click += new System.EventHandler(this.eszkozokToolStripMenuItem_Click);
            // 
            // felhasznaloAdminisztracioToolStripMenuItem
            // 
            this.felhasznaloAdminisztracioToolStripMenuItem.Name = "felhasznaloAdminisztracioToolStripMenuItem";
            this.felhasznaloAdminisztracioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.felhasznaloAdminisztracioToolStripMenuItem.Text = "Felhasznalok";
            this.felhasznaloAdminisztracioToolStripMenuItem.Click += new System.EventHandler(this.felhasznaloAdminisztracioToolStripMenuItem_Click);
            // 
            // beallitasokToolStripMenuItem
            // 
            this.beallitasokToolStripMenuItem.Name = "beallitasokToolStripMenuItem";
            this.beallitasokToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.beallitasokToolStripMenuItem.Text = "Beallitasok";
            // 
            // kilepesToolStripMenuItem1
            // 
            this.kilepesToolStripMenuItem1.Name = "kilepesToolStripMenuItem1";
            this.kilepesToolStripMenuItem1.Size = new System.Drawing.Size(83, 29);
            this.kilepesToolStripMenuItem1.Text = "Kilepes";
            this.kilepesToolStripMenuItem1.Click += new System.EventHandler(this.kilepesToolStripMenuItem1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 832);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
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
    }
}

