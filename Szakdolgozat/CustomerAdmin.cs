using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Szakdolgozat
{
    public partial class frmCustomerAdmin : Form
    {
        static string ConnectionString;
        List<Customer> Customers = new List<Customer>();

        class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public int PostalCode { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }

            public Customer(int id, string name, string phoneNumber, int postalCode, string city, string address, string email)
            {
                CustomerId = id; 
                Name = name;
                PhoneNumber = phoneNumber;
                PostalCode = postalCode;
                City = city;
                Address = address;
                Email = email;
            }
        }
        public frmCustomerAdmin(string c)
        {
            ConnectionString = c;
            InitializeComponent();


            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand("SELECT * from uf_torzs;", conn);
                var sor = command.ExecuteReader();
                while (sor.Read())
                {
                    Customers.Add(new Customer(
                        int.Parse(sor[0].ToString()),
                        sor[1].ToString(), 
                        sor[2].ToString(), 
                        int.Parse(sor[3].ToString()), 
                        sor[4].ToString(), 
                        sor[5].ToString(),
                        sor[6].ToString()));
                    dgvCustomerList.Rows.Add(sor[0],sor[1], sor[3], sor[4], sor[5]);
                }
            }

        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
