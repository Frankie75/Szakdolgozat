using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Szakdolgozat
{
    public partial class frmDevicesAdmin : Form
    {
        static string ConnectionString;
        static string[] kategoriak = new string[] {"szemelyauto", "teherauto", "motorkerekpar", "egyeb"};
        public frmDevicesAdmin(string c)
        {
            InitializeComponent();
            ConnectionString = c;   
        }

        private void DevicesAdmin_Load(object sender, EventArgs e)
        {
            cbCategories.Items.Add("szemelyauto");
            cbCategories.Items.Add("teherauto");
            cbCategories.Items.Add("motorkerekpar");
            cbCategories.Items.Add("egyeb");
            cbCategories.Items.Add("mindegyik");
            cbCategories.SelectedIndex = 4;
            refreshDgv("", cbCategories.SelectedIndex);
        }
        
        private void refreshDgv(string tipus, int kategoria)
        {
            dgvDeviceList.Rows.Clear();
            using (var conn = new MySqlConnection(ConnectionString))
            {
                
               
                conn.Open();
                var command = new MySqlCommand(
                    "SELECT rendszam, gyarto, tipus, alvazszam, kategoria, gk_id " +
                    "FROM gk_torzs " +
                    $"WHERE tipus LIKE '{tipus + '%'}';",conn);
                    
                var sor = command.ExecuteReader();
                
               
                while (sor.Read())
                {
                    if (kategoria==4)
                        dgvDeviceList.Rows.Add(sor[0], sor[1], sor[2], sor[3], kategoriak[(int)sor[4]], sor[5]);
                    else
                        if ((int)sor[4]==kategoria)
                            dgvDeviceList.Rows.Add(sor[0], sor[1], sor[2], sor[3], kategoriak[(int)sor[4]], sor[5]);

                }


            }


        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void tbSearchByType_KeyUp(object sender, KeyEventArgs e)
        {
            refreshDgv(tbSearchByType.Text, cbCategories.SelectedIndex);
        }

        private void cbCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refreshDgv(tbSearchByType.Text, cbCategories.SelectedIndex);
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
         

            DialogResult dr = MessageBox.Show("Biztos torolni akarod?", "Megerosites", MessageBoxButtons.OKCancel);
            if(dr == DialogResult.Cancel)
                return;
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        "DELETE FROM gk_torzs " +
                        $"WHERE gk_id = {dgvDeviceList.SelectedRows[0].Cells[5].Value};", conn);

                    command.ExecuteNonQuery();

                }

            }

            catch (MySqlException ex )
            {
                if ( ex.Number == 1451)
                {
                    MessageBox.Show("A gepjarmu hasznalatban van (nem torolheto!)");
                    return;

                }
            }

            
            MessageBox.Show("Gepjarmu torolve!");
            refreshDgv(tbSearchByType.Text, cbCategories.SelectedIndex);

        }
    }
}
