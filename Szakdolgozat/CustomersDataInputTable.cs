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
        public int Id;

        public frmCutomerDataInputForm(string c, int id)
        {
            InitializeComponent();
            ConnectionString = c;
            Id= id;

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
            SetColor();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!Int32.TryParse(tbPostCode.Text, out _))
            {
                MessageBox.Show("Hibas 'Iranyitoszam' mezo kitoltes", "Hiba");
                return;
            }

            using(var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                if ( Id>0)
                {
                    var command = new MySqlCommand(
                        "UPDATE  uf_torzs " +
                        "SET " +
                        $"unev='{tbName.Text}'," +
                        $"telefon='{tbPhoneNumber.Text}'," +
                        $"iranyitoszam={int.Parse(tbPostCode.Text)}," +
                        $"helyseg='{tbCity.Text}'," +
                        $"cim='{tbAddress.Text}'," +
                        $"email='{tbEmail.Text}' " +
                        $"WHERE uf_id={Id};", conn);
                    command.ExecuteNonQuery();

                }
                else
                {
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


            }
            MessageBox.Show("Uj ugyfel elmentve!");
            this.Close();
        }

        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnCancel.BackColor = Properties.Settings.Default.ColorButton;
            this.btnOK.BackColor = Properties.Settings.Default.ColorButton;

        }
    }
}
