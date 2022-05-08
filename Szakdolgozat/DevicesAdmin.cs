using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Szakdolgozat
{
    public partial class frmDevicesAdmin : Form
    {
        static string ConnectionString;
        static bool DgvReady=false;
    
        public frmDevicesAdmin(string c)
        {
            InitializeComponent();
            ConnectionString = c;   
        }

        private void DevicesAdmin_Load(object sender, EventArgs e)
        {
            SetColor();
            cbCategories.Items.Add("Szemelyauto");
            cbCategories.Items.Add("Teherauto");
            cbCategories.Items.Add("Motorkerekpar");
            cbCategories.Items.Add("Egyeb");
            cbCategories.Items.Add("Mindegyik");
            cbCategories.SelectedIndex = 4;
            refreshDgv("", cbCategories.SelectedIndex);
        }
        
        private void refreshDgv(string tipus, int kategoria)
        {
            DgvReady = false;
            dgvDeviceList.Rows.Clear();
            using (var conn = new MySqlConnection(ConnectionString))
            {
       
                conn.Open();
                var command = new MySqlCommand(
                    "SELECT rendszam, gyarto, tipus, alvazszam, kategoria, gk_id, picture " +
                    "FROM gk_torzs " +
                    $"WHERE tipus LIKE '{tipus + '%'}';",conn);
                    
                var sor = command.ExecuteReader();
                
               
                while (sor.Read())
                {
                    if (cbCategories.Text=="Mindegyik")
                        dgvDeviceList.Rows.Add(sor[0], sor[1], sor[2], sor[3], sor[4], sor[5], sor[6]);
                    else
                        if (sor[4].ToString()==cbCategories.Text)
                            dgvDeviceList.Rows.Add(sor[0], sor[1], sor[2], sor[3], sor[4], sor[5], sor[6]);

                }

            }
            if(dgvDeviceList.SelectedRows.Count ==0)
                pbCarPicture.ImageLocation = @"C:\Users\Frankie\source\repos\Szakdolgozat\Szakdolgozat\Resources\No_Photography.png";
            else
            pbCarPicture.ImageLocation = dgvDeviceList.SelectedRows[0].Cells[6].Value.ToString();
            DgvReady = true;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void tbSearchByType_KeyUp(object sender, KeyEventArgs e)
        {
            refreshDgv(tbSearchByType.Text, cbCategories.SelectedIndex);
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            if (dgvDeviceList.Rows.Count < 1) return;

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

            
           
            refreshDgv(tbSearchByType.Text, cbCategories.SelectedIndex);

        }

        private void btnNewDevice_Click(object sender, EventArgs e)
        {
            var f = new frmDevicesDataInputTable(-1,ConnectionString);
            f.ShowDialog();
            refreshDgv("", cbCategories.SelectedIndex);

        }

        private void btnEditDevice_Click(object sender, EventArgs e)
        {
            if (dgvDeviceList.Rows.Count < 1) return;
            var f = new frmDevicesDataInputTable((int)dgvDeviceList.SelectedRows[0].Cells[5].Value, ConnectionString);
            f.ShowDialog();
            refreshDgv("", cbCategories.SelectedIndex);
        }

        private void cbCategories_DropDownClosed(object sender, EventArgs e)
        {
            refreshDgv("", cbCategories.SelectedIndex);

        }

        private void dgvDeviceList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(DgvReady)
            pbCarPicture.ImageLocation = dgvDeviceList.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnCloseWindow.BackColor = Properties.Settings.Default.ColorButton;
            this.btnDeleteDevice.BackColor = Properties.Settings.Default.ColorButton;
            this.btnEditDevice.BackColor = Properties.Settings.Default.ColorButton;
            this.btnNewDevice.BackColor = Properties.Settings.Default.ColorButton;

        }
    }
}
