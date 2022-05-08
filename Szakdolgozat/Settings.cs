using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColorFore=Color.Brown;
            Properties.Settings.Default.ColorBack = Color.IndianRed;
            Properties.Settings.Default.ColorButton = Color.DarkGray;
            this.Close();
        }

        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnDefault.BackColor = Properties.Settings.Default.ColorButton;
            this.btnGreen.BackColor = Properties.Settings.Default.ColorButton;  
            this.btnRed.BackColor = Properties.Settings.Default.ColorButton;

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            SetColor();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColorFore = default;
            Properties.Settings.Default.ColorBack = default;
            Properties.Settings.Default.ColorButton = default;
            this.Close();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColorFore = Color.DarkGreen;
            Properties.Settings.Default.ColorBack = Color.LightGreen;
            Properties.Settings.Default.ColorButton = Color.GreenYellow;
            this.Close();
        }
    }
}
