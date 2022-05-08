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

        }


        public void refreshDGV(string Filter)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand("SELECT * from uf_torzs;", conn);
                var sor = command.ExecuteReader();
                Customers.Clear();
                dgvCustomerList.Rows.Clear();

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

                    if (sor[1].ToString().Contains(Filter))
                    {
                        dgvCustomerList.Rows.Add(sor[1], sor[3], sor[4], sor[5], sor[0], sor[2], sor[6]);

                    }
                }
            }

        }
        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCustomerList.SelectedRows[0].Cells[4].Value.ToString());
            Properties.Settings.Default.SelectedCustomerId = id;
            this.Close();
           
            
        }

        private void frmCustomerAdmin_Load(object sender, EventArgs e)
        {
            SetColor();
            refreshDGV("");

        }

        private void btnCustomerEditor_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dgvCustomerList.SelectedRows[0].Cells[4].Value.ToString());
            var f = new frmCutomerDataInputForm(ConnectionString, id);
            f.ShowDialog();
            refreshDGV("");

        }

        private void tbSearchName_KeyUp(object sender, KeyEventArgs e)
        {
            refreshDGV(tbSearchName.Text);
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {

            var f = new frmCutomerDataInputForm(ConnectionString, -1);
            f.ShowDialog();
            refreshDGV("");

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCustomerList.SelectedRows[0].Cells[4].Value.ToString());

            DialogResult dr = MessageBox.Show("Biztosan toroli az Ugyfelet az adatbazisbol?", "Nem", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();

                        var command = new MySqlCommand(
                            "DELETE FROM uf_torzs " +
                            $"WHERE uf_id={id};", conn);
                        command.ExecuteNonQuery();
                    }

                }

                catch (MySqlException ex)
                {
                    if (ex.Number == 1451)
                    {
                        MessageBox.Show("Az Ugyfel hasznalatban van (nem torolheto!)");
                        return;

                    }

                }


                MessageBox.Show("Ugyfel torolve!");
                refreshDGV("");

            }

        }

        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnAddNewCustomer.BackColor = Properties.Settings.Default.ColorButton;
            this.btnClose.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCustomerEditor.BackColor = Properties.Settings.Default.ColorButton;
            this.btnDeleteCustomer.BackColor = Properties.Settings.Default.ColorButton;

        }

    }
}
