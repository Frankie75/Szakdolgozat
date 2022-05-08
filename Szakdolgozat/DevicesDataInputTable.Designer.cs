namespace Szakdolgozat
{
    partial class frmDevicesDataInputTable
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
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewBrand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbNumberPlate = new System.Windows.Forms.ComboBox();
            this.cbColour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewType = new System.Windows.Forms.Button();
            this.btnNewColour = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.pbCarPhoto = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbWarningSuit = new System.Windows.Forms.CheckBox();
            this.chkbNavigation = new System.Windows.Forms.CheckBox();
            this.chkbJack = new System.Windows.Forms.CheckBox();
            this.chkbSpareLightBulb = new System.Windows.Forms.CheckBox();
            this.chkbRadio = new System.Windows.Forms.CheckBox();
            this.chkbAntenna = new System.Windows.Forms.CheckBox();
            this.chkbTriangle = new System.Windows.Forms.CheckBox();
            this.chkbSpareTyre = new System.Windows.Forms.CheckBox();
            this.chkbEmergencyBox = new System.Windows.Forms.CheckBox();
            this.chkbDocuments = new System.Windows.Forms.CheckBox();
            this.btnRemoveBrand = new System.Windows.Forms.Button();
            this.btnRemoveType = new System.Windows.Forms.Button();
            this.btnRemoveColour = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVinNumber = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbGearchangeType = new System.Windows.Forms.ComboBox();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPessengerNumber = new System.Windows.Forms.ComboBox();
            this.cbManufacturingDate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDoorsNumber = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPictureSelect = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBrand
            // 
            this.cbBrand.BackColor = System.Drawing.Color.LightGray;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(160, 25);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(236, 24);
            this.cbBrand.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gyártó";
            // 
            // btnNewBrand
            // 
            this.btnNewBrand.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNewBrand.FlatAppearance.BorderSize = 0;
            this.btnNewBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewBrand.ForeColor = System.Drawing.Color.White;
            this.btnNewBrand.Location = new System.Drawing.Point(420, 25);
            this.btnNewBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewBrand.Name = "btnNewBrand";
            this.btnNewBrand.Size = new System.Drawing.Size(71, 26);
            this.btnNewBrand.TabIndex = 2;
            this.btnNewBrand.Text = "+";
            this.btnNewBrand.UseVisualStyleBackColor = false;
            this.btnNewBrand.Click += new System.EventHandler(this.btnNewBrand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Típus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(23, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Szín";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rendszám";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.LightGray;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(160, 57);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(236, 24);
            this.cbType.TabIndex = 6;
            // 
            // cbNumberPlate
            // 
            this.cbNumberPlate.BackColor = System.Drawing.Color.LightGray;
            this.cbNumberPlate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbNumberPlate.FormattingEnabled = true;
            this.cbNumberPlate.Location = new System.Drawing.Point(160, 89);
            this.cbNumberPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNumberPlate.Name = "cbNumberPlate";
            this.cbNumberPlate.Size = new System.Drawing.Size(236, 24);
            this.cbNumberPlate.TabIndex = 7;
            // 
            // cbColour
            // 
            this.cbColour.BackColor = System.Drawing.Color.LightGray;
            this.cbColour.FormattingEnabled = true;
            this.cbColour.Location = new System.Drawing.Point(160, 153);
            this.cbColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbColour.Name = "cbColour";
            this.cbColour.Size = new System.Drawing.Size(236, 24);
            this.cbColour.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Műszaki érvényesség";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.LightGray;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(836, 27);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(236, 24);
            this.cbCategory.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(698, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kategória";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(656, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Megjegyzés";
            // 
            // btnNewType
            // 
            this.btnNewType.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNewType.FlatAppearance.BorderSize = 0;
            this.btnNewType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewType.ForeColor = System.Drawing.Color.White;
            this.btnNewType.Location = new System.Drawing.Point(420, 59);
            this.btnNewType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(71, 28);
            this.btnNewType.TabIndex = 15;
            this.btnNewType.Text = "+";
            this.btnNewType.UseVisualStyleBackColor = false;
            this.btnNewType.Click += new System.EventHandler(this.btnNewType_Click);
            // 
            // btnNewColour
            // 
            this.btnNewColour.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNewColour.FlatAppearance.BorderSize = 0;
            this.btnNewColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewColour.ForeColor = System.Drawing.Color.White;
            this.btnNewColour.Location = new System.Drawing.Point(420, 149);
            this.btnNewColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewColour.Name = "btnNewColour";
            this.btnNewColour.Size = new System.Drawing.Size(71, 26);
            this.btnNewColour.TabIndex = 16;
            this.btnNewColour.Text = "+";
            this.btnNewColour.UseVisualStyleBackColor = false;
            this.btnNewColour.Click += new System.EventHandler(this.btnNewColour_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.BackColor = System.Drawing.Color.LightGray;
            this.rtbNote.Location = new System.Drawing.Point(660, 286);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(412, 101);
            this.rtbNote.TabIndex = 17;
            this.rtbNote.Text = "";
            // 
            // pbCarPhoto
            // 
            this.pbCarPhoto.InitialImage = null;
            this.pbCarPhoto.Location = new System.Drawing.Point(660, 400);
            this.pbCarPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCarPhoto.Name = "pbCarPhoto";
            this.pbCarPhoto.Size = new System.Drawing.Size(412, 287);
            this.pbCarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarPhoto.TabIndex = 18;
            this.pbCarPhoto.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(26, 613);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 75);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(353, 613);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(213, 75);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Bezár";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbWarningSuit);
            this.groupBox1.Controls.Add(this.chkbNavigation);
            this.groupBox1.Controls.Add(this.chkbJack);
            this.groupBox1.Controls.Add(this.chkbSpareLightBulb);
            this.groupBox1.Controls.Add(this.chkbRadio);
            this.groupBox1.Controls.Add(this.chkbAntenna);
            this.groupBox1.Controls.Add(this.chkbTriangle);
            this.groupBox1.Controls.Add(this.chkbSpareTyre);
            this.groupBox1.Controls.Add(this.chkbEmergencyBox);
            this.groupBox1.Controls.Add(this.chkbDocuments);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(26, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(540, 187);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Felszereltség";
            // 
            // chkbWarningSuit
            // 
            this.chkbWarningSuit.AutoSize = true;
            this.chkbWarningSuit.Location = new System.Drawing.Point(207, 138);
            this.chkbWarningSuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbWarningSuit.Name = "chkbWarningSuit";
            this.chkbWarningSuit.Size = new System.Drawing.Size(153, 21);
            this.chkbWarningSuit.TabIndex = 9;
            this.chkbWarningSuit.Text = "Láthatósági mellény";
            this.chkbWarningSuit.UseVisualStyleBackColor = true;
            // 
            // chkbNavigation
            // 
            this.chkbNavigation.AutoSize = true;
            this.chkbNavigation.Location = new System.Drawing.Point(207, 111);
            this.chkbNavigation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbNavigation.Name = "chkbNavigation";
            this.chkbNavigation.Size = new System.Drawing.Size(89, 21);
            this.chkbNavigation.TabIndex = 8;
            this.chkbNavigation.Text = "Navigació";
            this.chkbNavigation.UseVisualStyleBackColor = true;
            // 
            // chkbJack
            // 
            this.chkbJack.AutoSize = true;
            this.chkbJack.Location = new System.Drawing.Point(207, 84);
            this.chkbJack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbJack.Name = "chkbJack";
            this.chkbJack.Size = new System.Drawing.Size(66, 21);
            this.chkbJack.TabIndex = 7;
            this.chkbJack.Text = "Emelő";
            this.chkbJack.UseVisualStyleBackColor = true;
            // 
            // chkbSpareLightBulb
            // 
            this.chkbSpareLightBulb.AutoSize = true;
            this.chkbSpareLightBulb.Location = new System.Drawing.Point(207, 57);
            this.chkbSpareLightBulb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbSpareLightBulb.Name = "chkbSpareLightBulb";
            this.chkbSpareLightBulb.Size = new System.Drawing.Size(96, 21);
            this.chkbSpareLightBulb.TabIndex = 6;
            this.chkbSpareLightBulb.Text = "Izzókészlet";
            this.chkbSpareLightBulb.UseVisualStyleBackColor = true;
            // 
            // chkbRadio
            // 
            this.chkbRadio.AutoSize = true;
            this.chkbRadio.Location = new System.Drawing.Point(207, 32);
            this.chkbRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbRadio.Name = "chkbRadio";
            this.chkbRadio.Size = new System.Drawing.Size(64, 21);
            this.chkbRadio.TabIndex = 5;
            this.chkbRadio.Text = "Radió";
            this.chkbRadio.UseVisualStyleBackColor = true;
            // 
            // chkbAntenna
            // 
            this.chkbAntenna.AutoSize = true;
            this.chkbAntenna.Location = new System.Drawing.Point(5, 138);
            this.chkbAntenna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbAntenna.Name = "chkbAntenna";
            this.chkbAntenna.Size = new System.Drawing.Size(80, 21);
            this.chkbAntenna.TabIndex = 4;
            this.chkbAntenna.Text = "Antenna";
            this.chkbAntenna.UseVisualStyleBackColor = true;
            // 
            // chkbTriangle
            // 
            this.chkbTriangle.AutoSize = true;
            this.chkbTriangle.Location = new System.Drawing.Point(5, 111);
            this.chkbTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbTriangle.Name = "chkbTriangle";
            this.chkbTriangle.Size = new System.Drawing.Size(114, 21);
            this.chkbTriangle.TabIndex = 3;
            this.chkbTriangle.Text = "Elakadásjelző";
            this.chkbTriangle.UseVisualStyleBackColor = true;
            // 
            // chkbSpareTyre
            // 
            this.chkbSpareTyre.AutoSize = true;
            this.chkbSpareTyre.Location = new System.Drawing.Point(5, 84);
            this.chkbSpareTyre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbSpareTyre.Name = "chkbSpareTyre";
            this.chkbSpareTyre.Size = new System.Drawing.Size(83, 21);
            this.chkbSpareTyre.TabIndex = 2;
            this.chkbSpareTyre.Text = "Pótkerék";
            this.chkbSpareTyre.UseVisualStyleBackColor = true;
            // 
            // chkbEmergencyBox
            // 
            this.chkbEmergencyBox.AutoSize = true;
            this.chkbEmergencyBox.Location = new System.Drawing.Point(5, 57);
            this.chkbEmergencyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbEmergencyBox.Name = "chkbEmergencyBox";
            this.chkbEmergencyBox.Size = new System.Drawing.Size(138, 21);
            this.chkbEmergencyBox.TabIndex = 1;
            this.chkbEmergencyBox.Text = "Elsősegély doboz";
            this.chkbEmergencyBox.UseVisualStyleBackColor = true;
            // 
            // chkbDocuments
            // 
            this.chkbDocuments.AutoSize = true;
            this.chkbDocuments.Location = new System.Drawing.Point(5, 32);
            this.chkbDocuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbDocuments.Name = "chkbDocuments";
            this.chkbDocuments.Size = new System.Drawing.Size(125, 21);
            this.chkbDocuments.TabIndex = 0;
            this.chkbDocuments.Text = "Dokumentumok";
            this.chkbDocuments.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBrand
            // 
            this.btnRemoveBrand.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveBrand.FlatAppearance.BorderSize = 0;
            this.btnRemoveBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveBrand.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBrand.Location = new System.Drawing.Point(495, 25);
            this.btnRemoveBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveBrand.Name = "btnRemoveBrand";
            this.btnRemoveBrand.Size = new System.Drawing.Size(71, 26);
            this.btnRemoveBrand.TabIndex = 23;
            this.btnRemoveBrand.Text = "-";
            this.btnRemoveBrand.UseVisualStyleBackColor = false;
            this.btnRemoveBrand.Click += new System.EventHandler(this.btnRemoveBrand_Click);
            // 
            // btnRemoveType
            // 
            this.btnRemoveType.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveType.FlatAppearance.BorderSize = 0;
            this.btnRemoveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveType.ForeColor = System.Drawing.Color.White;
            this.btnRemoveType.Location = new System.Drawing.Point(495, 62);
            this.btnRemoveType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveType.Name = "btnRemoveType";
            this.btnRemoveType.Size = new System.Drawing.Size(71, 26);
            this.btnRemoveType.TabIndex = 24;
            this.btnRemoveType.Text = "-";
            this.btnRemoveType.UseVisualStyleBackColor = false;
            this.btnRemoveType.Click += new System.EventHandler(this.btnRemoveType_Click);
            // 
            // btnRemoveColour
            // 
            this.btnRemoveColour.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveColour.FlatAppearance.BorderSize = 0;
            this.btnRemoveColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveColour.ForeColor = System.Drawing.Color.White;
            this.btnRemoveColour.Location = new System.Drawing.Point(495, 150);
            this.btnRemoveColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveColour.Name = "btnRemoveColour";
            this.btnRemoveColour.Size = new System.Drawing.Size(71, 26);
            this.btnRemoveColour.TabIndex = 25;
            this.btnRemoveColour.Text = "-";
            this.btnRemoveColour.UseVisualStyleBackColor = false;
            this.btnRemoveColour.Click += new System.EventHandler(this.btnRemoveColour_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(23, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Alvázszám";
            // 
            // cbVinNumber
            // 
            this.cbVinNumber.BackColor = System.Drawing.Color.LightGray;
            this.cbVinNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbVinNumber.FormattingEnabled = true;
            this.cbVinNumber.Location = new System.Drawing.Point(160, 120);
            this.cbVinNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVinNumber.Name = "cbVinNumber";
            this.cbVinNumber.Size = new System.Drawing.Size(236, 24);
            this.cbVinNumber.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 187);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 23);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 9, 0, 0, 0, 0);
            // 
            // cbGearchangeType
            // 
            this.cbGearchangeType.BackColor = System.Drawing.Color.LightGray;
            this.cbGearchangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGearchangeType.FormattingEnabled = true;
            this.cbGearchangeType.Location = new System.Drawing.Point(836, 59);
            this.cbGearchangeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGearchangeType.Name = "cbGearchangeType";
            this.cbGearchangeType.Size = new System.Drawing.Size(236, 24);
            this.cbGearchangeType.TabIndex = 29;
            // 
            // cbFuelType
            // 
            this.cbFuelType.BackColor = System.Drawing.Color.LightGray;
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Location = new System.Drawing.Point(836, 93);
            this.cbFuelType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(236, 24);
            this.cbFuelType.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(698, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Váltó";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(698, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Üzemanyag";
            // 
            // cbPessengerNumber
            // 
            this.cbPessengerNumber.BackColor = System.Drawing.Color.LightGray;
            this.cbPessengerNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbPessengerNumber.FormattingEnabled = true;
            this.cbPessengerNumber.Location = new System.Drawing.Point(836, 123);
            this.cbPessengerNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPessengerNumber.Name = "cbPessengerNumber";
            this.cbPessengerNumber.Size = new System.Drawing.Size(236, 24);
            this.cbPessengerNumber.TabIndex = 33;
            // 
            // cbManufacturingDate
            // 
            this.cbManufacturingDate.BackColor = System.Drawing.Color.LightGray;
            this.cbManufacturingDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbManufacturingDate.FormattingEnabled = true;
            this.cbManufacturingDate.Location = new System.Drawing.Point(836, 153);
            this.cbManufacturingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbManufacturingDate.Name = "cbManufacturingDate";
            this.cbManufacturingDate.Size = new System.Drawing.Size(236, 24);
            this.cbManufacturingDate.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(698, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Személyek száma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(698, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Gyártási év";
            // 
            // cbDoorsNumber
            // 
            this.cbDoorsNumber.BackColor = System.Drawing.Color.LightGray;
            this.cbDoorsNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDoorsNumber.FormattingEnabled = true;
            this.cbDoorsNumber.Location = new System.Drawing.Point(836, 185);
            this.cbDoorsNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDoorsNumber.Name = "cbDoorsNumber";
            this.cbDoorsNumber.Size = new System.Drawing.Size(236, 24);
            this.cbDoorsNumber.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(698, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Ajtók száma";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(23, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "File:";
            // 
            // btnPictureSelect
            // 
            this.btnPictureSelect.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPictureSelect.FlatAppearance.BorderSize = 0;
            this.btnPictureSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPictureSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPictureSelect.ForeColor = System.Drawing.Color.White;
            this.btnPictureSelect.Location = new System.Drawing.Point(78, 274);
            this.btnPictureSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPictureSelect.Name = "btnPictureSelect";
            this.btnPictureSelect.Size = new System.Drawing.Size(369, 44);
            this.btnPictureSelect.TabIndex = 40;
            this.btnPictureSelect.Text = "Kép kiválasztása";
            this.btnPictureSelect.UseVisualStyleBackColor = false;
            this.btnPictureSelect.Click += new System.EventHandler(this.btnPictureSelect_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFileName.Location = new System.Drawing.Point(75, 239);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(589, 17);
            this.lblFileName.TabIndex = 41;
            this.lblFileName.Text = "C:\\Users\\Frankie\\source\\repos\\Szakdolgozat\\Szakdolgozat\\Resources\\No_Photography." +
    "png";
            // 
            // frmDevicesDataInputTable
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1120, 699);
            this.ControlBox = false;
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnPictureSelect);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbDoorsNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbManufacturingDate);
            this.Controls.Add(this.cbPessengerNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.cbGearchangeType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbVinNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRemoveColour);
            this.Controls.Add(this.btnRemoveType);
            this.Controls.Add(this.btnRemoveBrand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbCarPhoto);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.btnNewColour);
            this.Controls.Add(this.btnNewType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbColour);
            this.Controls.Add(this.cbNumberPlate);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBrand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDevicesDataInputTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevicesDataInputTable";
            this.Load += new System.EventHandler(this.frmDevicesDataInputTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbNumberPlate;
        private System.Windows.Forms.ComboBox cbColour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.Button btnNewColour;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.PictureBox pbCarPhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkbWarningSuit;
        private System.Windows.Forms.CheckBox chkbNavigation;
        private System.Windows.Forms.CheckBox chkbJack;
        private System.Windows.Forms.CheckBox chkbSpareLightBulb;
        private System.Windows.Forms.CheckBox chkbRadio;
        private System.Windows.Forms.CheckBox chkbAntenna;
        private System.Windows.Forms.CheckBox chkbTriangle;
        private System.Windows.Forms.CheckBox chkbSpareTyre;
        private System.Windows.Forms.CheckBox chkbEmergencyBox;
        private System.Windows.Forms.CheckBox chkbDocuments;
        private System.Windows.Forms.Button btnRemoveBrand;
        private System.Windows.Forms.Button btnRemoveType;
        private System.Windows.Forms.Button btnRemoveColour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVinNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbGearchangeType;
        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbPessengerNumber;
        private System.Windows.Forms.ComboBox cbManufacturingDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbDoorsNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPictureSelect;
        private System.Windows.Forms.Label lblFileName;
    }
}