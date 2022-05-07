using MySql.Data.MySqlClient;
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
    public partial class frmContractCloser : Form
    {
        static string ConnectionString;
        static int ContractId;
        public frmContractCloser(string c, int id)
        {
            ConnectionString = c;
            ContractId = id;    
            InitializeComponent();
            cbFuelLevel.SelectedIndex = 0;
            tbAdditionalFee.Text = "0";
        }

        private void ContractCloser_Load(object sender, EventArgs e)
        {
            SetColor();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseContract_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (tbOdometer.Text.Length == 0 || !Int32.TryParse(tbOdometer.Text, out _)) ErrorMessage += "Hibas a 'Kilometer' mezo kitoltese\n";
          
            if(ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage);
                return;
            }



            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand(
                    "UPDATE szerzodesek " +
                    $"SET visszavet_datum='{dtpDateOfTheEnd.Text}', " +
                    $"visszavet_km={Int32.Parse(tbOdometer.Text)}, " +
                    $"kiadas_uzemanyag='{cbFuelLevel.Text}', " +
                    $"extra_fee={Int32.Parse(tbAdditionalFee.Text)} " +
                    $"WHERE szerzodes_id={ContractId};",conn); 

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Szerzodes lezarva!");
            this.Close();


            
        }
        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnCancel.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCloseContract.BackColor = Properties.Settings.Default.ColorButton;
       
        }
    }
}
