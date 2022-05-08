
namespace Szakdolgozat
{
    partial class Setting
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
            this.gbThemeColor = new System.Windows.Forms.GroupBox();
            this.rdPink = new System.Windows.Forms.RadioButton();
            this.rdOranga = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.gbTheme = new System.Windows.Forms.GroupBox();
            this.rdDark = new System.Windows.Forms.RadioButton();
            this.rdLight = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.gbThemeColor.SuspendLayout();
            this.gbTheme.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThemeColor
            // 
            this.gbThemeColor.BackColor = System.Drawing.Color.Transparent;
            this.gbThemeColor.Controls.Add(this.rdPink);
            this.gbThemeColor.Controls.Add(this.rdOranga);
            this.gbThemeColor.Controls.Add(this.rdGreen);
            this.gbThemeColor.Controls.Add(this.rbBlue);
            this.gbThemeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbThemeColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbThemeColor.Location = new System.Drawing.Point(126, 321);
            this.gbThemeColor.Name = "gbThemeColor";
            this.gbThemeColor.Size = new System.Drawing.Size(322, 261);
            this.gbThemeColor.TabIndex = 30;
            this.gbThemeColor.TabStop = false;
            this.gbThemeColor.Text = "Szín";
            // 
            // rdPink
            // 
            this.rdPink.AutoSize = true;
            this.rdPink.Location = new System.Drawing.Point(53, 189);
            this.rdPink.Name = "rdPink";
            this.rdPink.Size = new System.Drawing.Size(91, 21);
            this.rdPink.TabIndex = 1;
            this.rdPink.Text = "Rózsaszín";
            this.rdPink.UseVisualStyleBackColor = true;
            this.rdPink.CheckedChanged += new System.EventHandler(this.rdPink_CheckedChanged);
            // 
            // rdOranga
            // 
            this.rdOranga.AutoSize = true;
            this.rdOranga.Location = new System.Drawing.Point(53, 141);
            this.rdOranga.Name = "rdOranga";
            this.rdOranga.Size = new System.Drawing.Size(79, 21);
            this.rdOranga.TabIndex = 1;
            this.rdOranga.Text = "Narancs";
            this.rdOranga.UseVisualStyleBackColor = true;
            this.rdOranga.CheckedChanged += new System.EventHandler(this.rdOranga_CheckedChanged);
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.Location = new System.Drawing.Point(53, 96);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(54, 21);
            this.rdGreen.TabIndex = 1;
            this.rdGreen.Text = "Zöld";
            this.rdGreen.UseVisualStyleBackColor = true;
            this.rdGreen.CheckedChanged += new System.EventHandler(this.rdGreen_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Checked = true;
            this.rbBlue.Location = new System.Drawing.Point(53, 53);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(50, 21);
            this.rbBlue.TabIndex = 1;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Kék";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // gbTheme
            // 
            this.gbTheme.BackColor = System.Drawing.Color.Transparent;
            this.gbTheme.Controls.Add(this.rdDark);
            this.gbTheme.Controls.Add(this.rdLight);
            this.gbTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTheme.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbTheme.Location = new System.Drawing.Point(126, 105);
            this.gbTheme.Name = "gbTheme";
            this.gbTheme.Size = new System.Drawing.Size(285, 163);
            this.gbTheme.TabIndex = 32;
            this.gbTheme.TabStop = false;
            this.gbTheme.Text = "Mód";
            // 
            // rdDark
            // 
            this.rdDark.AutoSize = true;
            this.rdDark.Location = new System.Drawing.Point(53, 93);
            this.rdDark.Name = "rdDark";
            this.rdDark.Size = new System.Drawing.Size(59, 21);
            this.rdDark.TabIndex = 1;
            this.rdDark.Text = "Sötét";
            this.rdDark.UseVisualStyleBackColor = true;
            this.rdDark.CheckedChanged += new System.EventHandler(this.rdDark_CheckedChanged);
            // 
            // rdLight
            // 
            this.rdLight.AutoSize = true;
            this.rdLight.Checked = true;
            this.rdLight.Location = new System.Drawing.Point(53, 43);
            this.rdLight.Name = "rdLight";
            this.rdLight.Size = new System.Drawing.Size(72, 21);
            this.rdLight.TabIndex = 1;
            this.rdLight.TabStop = true;
            this.rdLight.Text = "Világos";
            this.rdLight.UseVisualStyleBackColor = true;
            this.rdLight.CheckedChanged += new System.EventHandler(this.rdLight_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 28;
            this.label3.Text = "Beállítások";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 71);
            this.panel1.TabIndex = 33;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1093, 708);
            this.pnlBackground.TabIndex = 35;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1049, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTheme);
            this.Controls.Add(this.gbThemeColor);
            this.Controls.Add(this.pnlBackground);
            this.Name = "Setting";
            this.Text = "Beállítások";
            this.gbThemeColor.ResumeLayout(false);
            this.gbThemeColor.PerformLayout();
            this.gbTheme.ResumeLayout(false);
            this.gbTheme.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbThemeColor;
        private System.Windows.Forms.GroupBox gbTheme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rdPink;
        private System.Windows.Forms.RadioButton rdOranga;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdDark;
        private System.Windows.Forms.RadioButton rdLight;
        private System.Windows.Forms.Panel pnlBackground;
    }
}