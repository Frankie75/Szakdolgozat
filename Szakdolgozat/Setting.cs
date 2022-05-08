using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.Panel;

namespace Szakdolgozat
{
    public partial class Setting : Form
    {

        public Setting()
        {
            InitializeComponent();
        }

        private void ThemeColors()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;

            this.btnCloseContract.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCustomers.BackColor = Properties.Settings.Default.ColorButton;
            this.btnExit.BackColor = Properties.Settings.Default.ColorButton;
            this.btnNewContract.BackColor = Properties.Settings.Default.ColorButton;
            this.btnPrint.BackColor = Properties.Settings.Default.ColorButton;
            this.btnUsers.BackColor = Properties.Settings.Default.ColorButton;
            this.btnVehicles.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCloseContract.BackColor = Properties.Settings.Default.ColorButton;
            this.btnSettings.BackColor = Properties.Settings.Default.ColorButton;
        }

        private void rdLight_CheckedChanged(object sender, EventArgs e)
        {
            //WhiteSmoke
            this.BackColor = Color.WhiteSmoke;
        }

        private void rdDark_CheckedChanged(object sender, EventArgs e)
        {
            //Black
            this.BackColor = Color.Black;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            //RoyalBlue
            panel1.BackColor = Color.RoyalBlue;
            gbTheme.ForeColor = Color.RoyalBlue;
            gbThemeColor.ForeColor = Color.RoyalBlue;
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            //SeaGreen;
            panel1.BackColor = Color.SeaGreen;
            gbTheme.ForeColor = Color.SeaGreen;
            gbThemeColor.ForeColor = Color.SeaGreen;
        }

        private void rdOranga_CheckedChanged(object sender, EventArgs e)
        {
            //Orange;
            panel1.BackColor = Color.Orange;
            gbTheme.ForeColor = Color.Orange;
            gbThemeColor.ForeColor = Color.Orange;

        }

        private void rdPink_CheckedChanged(object sender, EventArgs e)
        {
            //Orchid;
            panel1.BackColor = Color.Orchid;
            gbTheme.ForeColor = Color.Orchid;
            gbThemeColor.ForeColor = Color.Orchid;
        }
    }
}
