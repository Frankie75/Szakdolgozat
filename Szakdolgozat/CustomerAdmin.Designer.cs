namespace Szakdolgozat
{
    partial class frmCustomerAdmin
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
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnCustomerEditor = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ujUgyfelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelFelveteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelTorleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(108, 93);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(442, 89);
            this.btnAddNewCustomer.TabIndex = 0;
            this.btnAddNewCustomer.Text = "Uj ugyfel felvetele";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnCustomerEditor
            // 
            this.btnCustomerEditor.Location = new System.Drawing.Point(108, 210);
            this.btnCustomerEditor.Name = "btnCustomerEditor";
            this.btnCustomerEditor.Size = new System.Drawing.Size(442, 89);
            this.btnCustomerEditor.TabIndex = 1;
            this.btnCustomerEditor.Text = "Szerkesztes";
            this.btnCustomerEditor.UseVisualStyleBackColor = true;
            this.btnCustomerEditor.Click += new System.EventHandler(this.btnCustomerEditor_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(108, 325);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(442, 89);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Ugyfel torlese";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(108, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(442, 89);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Bezar / Kivalaszt";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.tbSearchName);
            this.groupBox1.Controls.Add(this.dgvCustomerList);
            this.groupBox1.Location = new System.Drawing.Point(697, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 486);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ugyfelek Listaja:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(268, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(154, 20);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Nev szerinti kereses:";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(447, 31);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(256, 26);
            this.tbSearchName.TabIndex = 6;
            this.tbSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchName_KeyUp);
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.AllowUserToResizeColumns = false;
            this.dgvCustomerList.AllowUserToResizeRows = false;
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.ZipCode,
            this.City,
            this.Address,
            this.Id,
            this.Telefon,
            this.Email});
            this.dgvCustomerList.Location = new System.Drawing.Point(26, 87);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowHeadersWidth = 62;
            this.dgvCustomerList.RowTemplate.Height = 28;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(677, 373);
            this.dgvCustomerList.TabIndex = 0;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "Nev";
            this.Nev.MinimumWidth = 8;
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            this.Nev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ZipCode
            // 
            this.ZipCode.HeaderText = "Iranyitoszam";
            this.ZipCode.MinimumWidth = 8;
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "Helyseg";
            this.City.MinimumWidth = 8;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Cim";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 8;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Visible = false;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujUgyfelToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ujUgyfelToolStripMenuItem
            // 
            this.ujUgyfelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujUgyfelFelveteleToolStripMenuItem,
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem,
            this.ugyfelTorleseToolStripMenuItem});
            this.ujUgyfelToolStripMenuItem.Name = "ujUgyfelToolStripMenuItem";
            this.ujUgyfelToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.ujUgyfelToolStripMenuItem.Text = "Opciok";
            // 
            // ujUgyfelFelveteleToolStripMenuItem
            // 
            this.ujUgyfelFelveteleToolStripMenuItem.Name = "ujUgyfelFelveteleToolStripMenuItem";
            this.ujUgyfelFelveteleToolStripMenuItem.Size = new System.Drawing.Size(420, 34);
            this.ujUgyfelFelveteleToolStripMenuItem.Text = "Uj Ugyfel felvetele";
            this.ujUgyfelFelveteleToolStripMenuItem.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem
            // 
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Name = "meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem";
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Size = new System.Drawing.Size(420, 34);
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Text = "Meglevo ugyfel adatainak szerkesztese";
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Click += new System.EventHandler(this.btnCustomerEditor_Click);
            // 
            // ugyfelTorleseToolStripMenuItem
            // 
            this.ugyfelTorleseToolStripMenuItem.Name = "ugyfelTorleseToolStripMenuItem";
            this.ugyfelTorleseToolStripMenuItem.Size = new System.Drawing.Size(420, 34);
            this.ugyfelTorleseToolStripMenuItem.Text = "Ugyfel torlese";
            this.ugyfelTorleseToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.kilepesToolStripMenuItem.Text = "Bezar";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // frmCustomerAdmin
            // 
            this.AcceptButton = this.btnAddNewCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1477, 679);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnCustomerEditor);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ugyfeladatok kezelese";
            this.Load += new System.EventHandler(this.frmCustomerAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnCustomerEditor;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelFelveteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfelTorleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}