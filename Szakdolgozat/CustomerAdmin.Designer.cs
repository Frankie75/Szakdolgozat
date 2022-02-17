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
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ujUgyfelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelFelveteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelTorleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // 
            // btnCustomerEditor
            // 
            this.btnCustomerEditor.Location = new System.Drawing.Point(108, 210);
            this.btnCustomerEditor.Name = "btnCustomerEditor";
            this.btnCustomerEditor.Size = new System.Drawing.Size(442, 89);
            this.btnCustomerEditor.TabIndex = 1;
            this.btnCustomerEditor.Text = "Szerkesztes";
            this.btnCustomerEditor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(108, 325);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(442, 89);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Ugyfel torlese";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(108, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(442, 89);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Bezar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSearchName);
            this.groupBox1.Controls.Add(this.dgvCustomerList);
            this.groupBox1.Location = new System.Drawing.Point(697, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 486);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ugyfelek Listaja:";
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
            this.Id,
            this.Nev,
            this.ZipCode,
            this.City,
            this.Address});
            this.dgvCustomerList.Location = new System.Drawing.Point(26, 87);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowHeadersWidth = 62;
            this.dgvCustomerList.RowTemplate.Height = 28;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(677, 373);
            this.dgvCustomerList.TabIndex = 0;
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
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.kilepesToolStripMenuItem.Text = "Bezar";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // ujUgyfelFelveteleToolStripMenuItem
            // 
            this.ujUgyfelFelveteleToolStripMenuItem.Name = "ujUgyfelFelveteleToolStripMenuItem";
            this.ujUgyfelFelveteleToolStripMenuItem.Size = new System.Drawing.Size(420, 34);
            this.ujUgyfelFelveteleToolStripMenuItem.Text = "Uj Ugyfel felvetele";
            // 
            // meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem
            // 
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Name = "meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem";
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Size = new System.Drawing.Size(420, 34);
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Text = "Meglevo ugyfel adatainak szerkesztese";
            // 
            // ugyfelTorleseToolStripMenuItem
            // 
            this.ugyfelTorleseToolStripMenuItem.Name = "ugyfelTorleseToolStripMenuItem";
            this.ugyfelTorleseToolStripMenuItem.Size = new System.Drawing.Size(420, 34);
            this.ugyfelTorleseToolStripMenuItem.Text = "Ugyfel torlese";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(447, 31);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(256, 26);
            this.tbSearchName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kereses:";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "Nev";
            this.Nev.MinimumWidth = 8;
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
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
            // frmCustomerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 679);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnCustomerEditor);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCustomerAdmin";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}