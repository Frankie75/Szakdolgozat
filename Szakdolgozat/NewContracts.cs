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
    public partial class frmNewContract : Form
    {

        static string ConnectionString;
        static int SelectedCar = 0;

        public class Vehicle
        {
            public int Id { get; set; }
            public string Brand { get; set; }
            public string Type { get; set; }
            public string IdentityPlate { get; set; }



        }
     

        public List<Vehicle> Vehicles=new List<Vehicle>();
        public List<int> Busy = new List<int>();
        public List<int> BusyIndex = new List<int>();


        public frmNewContract(string cs)
        {
            InitializeComponent();
            ConnectionString = cs;
         
        }

        private void frmNewContract_Load(object sender, EventArgs e)
        {
            SetColor();

            cbFuelLevelOut.Text = cbFuelLevelOut.Items[0].ToString();
            dtpStart.Value= DateTime.Now;
            dtpStart.MinDate = DateTime.Now;
            dtpStop.Value= DateTime.Now;
            dtpStop.MinDate = DateTime.Now;
            ActualiseFormData();


        }

        private void ActualiseFormData()
        {
            Vehicles.Clear();
            Busy.Clear();
            cbSelectVehicles.Items.Clear();
            BusyIndex.Clear();

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand(
                    "SELECT uf_id, unev, iranyitoszam, helyseg, cim FROM uf_torzs " +
                    $"WHERE uf_id={Properties.Settings.Default.SelectedCustomerId};", conn);

                var sor = command.ExecuteReader();

                while (sor.Read())
                {
                    tbCustomerName.Text = sor[1].ToString();
                    tbCustomerAddress.Text = sor[2].ToString() + " " + sor[3].ToString() + " " + sor[4].ToString();

                }

            }
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand(
                    "SELECT gk_id, gyarto, tipus, rendszam FROM gk_torzs;", conn);

                var sor = command.ExecuteReader();

                while (sor.Read())
                {
                    Vehicle v = new Vehicle();
                    v.Id = (int)sor[0];
                    v.Brand = sor[1].ToString();
                    v.Type = sor[2].ToString();
                    v.IdentityPlate = sor[3].ToString();
                    Vehicles.Add(v);
                }

            }
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand(
                    "SELECT gk_id FROM szerzodesek " +
                    "WHERE visszavet_datum IS NULL;", conn);

                var sor = command.ExecuteReader();

                while (sor.Read())
                {
                    Busy.Add((int)sor[0]);
                }
            }

            foreach (var item  in Vehicles)
            {
                if (!Busy.Contains(item.Id))
                {
                    cbSelectVehicles.Items.Add(item.Brand + " " + item.Type + " (" + item.IdentityPlate + ")");
                    BusyIndex.Add(item.Id);
                }

            }     
       

        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            var f = new frmCustomerAdmin(ConnectionString);
            f.ShowDialog();
            ActualiseFormData();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ErrorString = "";
            if (tbDeposit.Text.Length == 0 || !Int32.TryParse(tbDeposit.Text,out _ )) ErrorString += "Hibas a 'Deposit' mezo kitoltese\n";
            if (tbRentalFee.Text.Length == 0 || !Int32.TryParse(tbRentalFee.Text, out _)) ErrorString += "Hibas a 'Berleti dij' mezo kitoltese\n";
            if (cbSelectVehicles.Text.Length == 0) ErrorString += "Nincs kivalasztott gepjarmu\n";
            if (tbOdometerStart.Text.Length == 0 || !Int32.TryParse(tbOdometerStart.Text, out _)) ErrorString += "Hibas a 'Kilometer allasa' mezo kitoltese\n";

            if (ErrorString != "")
            {
                MessageBox.Show(ErrorString);
                return;
            }

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand(
                   $"INSERT INTO szerzodesek (uf_id, gk_id, kiadas_datum, kaucio, " +
                   $"berleti_dij, kiadas_serules, kiadas_uzemanyag, kiadas_km, " +
                   $"lejarat_datum, visszavet_datum) " +
                   $"VALUES (" +
                   $"{Properties.Settings.Default.SelectedCustomerId}, " +
                   $"{BusyIndex[SelectedCar]}, " +
                   $"'{dtpStart.Text}', " +
                   $"{Int32.Parse(tbDeposit.Text)}, " +
                   $"{Int32.Parse(tbRentalFee.Text)}, " +
                   $"'{rtbNotesOut.Text}', " +
                   $"'{cbFuelLevelOut.Text}', " +
                   $"{Int32.Parse(tbOdometerStart.Text)}, " +
                   $"'{dtpStop.Text}', " +
                   $"NULL " +
                   $");", conn);



                command.ExecuteNonQuery();
                MessageBox.Show("Uj szerzodes elmentve");

            }
            this.Close();


        }

        private void cbSelectVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCar = cbSelectVehicles.SelectedIndex;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if(dtpStop.Value < dtpStart.Value)
            {
                dtpStop.Value = dtpStart.Value;
                dtpStop.MinDate = dtpStart.Value;
            }
            else
                dtpStop.MinDate=dtpStart.Value;
        }

        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnCancel.BackColor = Properties.Settings.Default.ColorButton;
            this.btnSave.BackColor = Properties.Settings.Default.ColorButton;
            this.btnSelectCustomer.BackColor = Properties.Settings.Default.ColorButton;
  
        }
    }
}
