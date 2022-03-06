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
    public partial class frmCutomerDataInputForm : Form
    {
        static string ConnectionString;

        public frmCutomerDataInputForm(string c, int id)
        {
            InitializeComponent();
            ConnectionString = c;

            if (id>0)
            {
                btnOK.Text = "Mentes";
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        "SELECT * from uf_torzs " +
                        $"WHERE uf_id={id}", conn);

                    var sor = command.ExecuteReader();

                    while (sor.Read())
                    {
                        tbName.Text = sor[1].ToString();
                        tbPhoneNumber.Text = sor[2].ToString();
                        tbPostCode.Text = sor[3].ToString();
                        tbCity.Text = sor[4].ToString();
                        tbAddress.Text = sor[5].ToString();
                        tbEmail.Text = sor[6].ToString();
                        

                    }


                }
    
            }

            else
            {
                btnOK.Text = "Uj letrehozasa";
            }


         
        }
        private void frmCutomerDataInputForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using(var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand(
                    "INSERT INTO uf_torzs " +
                    "(unev, telefon, iranyitoszam, helyseg, cim, email) " +
                    $"VALUES (" +
                    $"'{tbName.Text}'," +
                    $"'{tbPhoneNumber.Text}'," +
                    $"{int.Parse(tbPostCode.Text)}," +
                    $"'{tbCity.Text}'," +
                    $"'{tbAddress.Text}'," +
                    $"'{tbEmail.Text}');", conn);

                command.ExecuteNonQuery();

            }
            MessageBox.Show("Uj ugyfel elmentve!");
            this.Close();
        }
    }
}
