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

        //public class Customers
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Address { get; set; }

        //}

        public class Contracts
        {

        }
        public class Vehicle
        {
            public int Id { get; set; }
            public string Brand { get; set; }
            public string Type { get; set; }
            public string IdentityPlate { get; set; }



        }
     

        public List<Vehicle> Vehicles=new List<Vehicle>();
        public List<int> Busy = new List<int>();


        public frmNewContract(string cs)
        {
            InitializeComponent();
            ConnectionString = cs;
        }

        private void frmNewContract_Load(object sender, EventArgs e)
        {
            ActualiseFormData();

          
        }

        private void ActualiseFormData()
        {
            Vehicles.Clear();
            Busy.Clear();
            cbSelectVehicles.Items.Clear();

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
    }
}
