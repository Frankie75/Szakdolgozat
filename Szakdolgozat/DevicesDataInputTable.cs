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
    public partial class frmDevicesDataInputTable : Form
    {
        static string ConnectionString;
        public int Id;

        public List<string> Brands = new List<string>();
        public List<string> Types = new List<string>();
        public List<string> Colours = new List<string>();

        
        public frmDevicesDataInputTable(int id, string c)
        {
            ConnectionString = c;   
            Id = id;
            InitializeComponent();

            cbCategory.Items.Add("Szemelyauto");
            cbCategory.Items.Add("Teherauto");
            cbCategory.Items.Add("Motorkerekpar");
            cbCategory.Items.Add("Egyeb");
            cbCategory.Text = cbCategory.Items[0].ToString();

            cbGearchangeType.Items.Add("Kezi");
            cbGearchangeType.Items.Add("Automata");
            cbGearchangeType.Items.Add("Egyeb");
            cbGearchangeType.Text = cbGearchangeType.Items[0].ToString();

            cbFuelType.Items.Add("Benzin");
            cbFuelType.Items.Add("Gazolaj");
            cbFuelType.Items.Add("Elektromos");
            cbFuelType.Items.Add("Egyeb");
            cbFuelType.Text = cbFuelType.Items[0].ToString();


            InitiateForm(Id);
        }

        private void frmDevicesDataInputTable_Load(object sender, EventArgs e)
        {
            SetColor();

        }

        private void InitiateForm(int id)
        {
            // MessageBox.Show(id.ToString());
            cbBrand.Items.Clear();
            cbType.Items.Clear();
            cbColour.Items.Clear(); 
            Brands.Clear();
            Types.Clear();
            Colours.Clear();

            chkbDocuments.Checked = false;
            chkbEmergencyBox.Checked = false;
            chkbSpareTyre.Checked = false;
            chkbTriangle.Checked = false;
            chkbAntenna.Checked = false;
            chkbRadio.Checked = false;
            chkbSpareLightBulb.Checked = false;
            chkbJack.Checked = false;
            chkbNavigation.Checked = false;
            chkbWarningSuit.Checked = false;

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand("SELECT * from gyarto;", conn);
                var sor = command.ExecuteReader();

                while (sor.Read())
                {
                    cbBrand.Items.Add(sor[1].ToString());
                    Brands.Add(sor[1].ToString());
                }
            }
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand("SELECT * from tipus;", conn);
                var sor = command.ExecuteReader();

                while (sor.Read())
                {
                    cbType.Items.Add(sor[1].ToString());
                    Types.Add(sor[1].ToString());
                }
            }
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var command = new MySqlCommand("SELECT * from szin;", conn);
                var sor = command.ExecuteReader();

                while (sor.Read())
                {
                    cbColour.Items.Add(sor[1].ToString());
                    Colours.Add(sor[1].ToString());
                }
            }
            if (id > 0)
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand($"SELECT * from gk_torzs WHERE gk_id={id};", conn);
                    var sor = command.ExecuteReader();

                    while (sor.Read())
                    {
                        
                        cbBrand.Text =sor[1].ToString();
                        cbType.Text = sor[2].ToString();
                        cbColour.Text = sor[3].ToString();
                        cbNumberPlate.Text = sor[5].ToString();
                        cbVinNumber.Text = sor[4].ToString();
                        dateTimePicker1.Text = sor[17].ToString();
                        cbCategory.Text = sor[18].ToString();
                        cbGearchangeType.Text = sor[19].ToString();
                        cbFuelType.Text = sor[20].ToString();
                        cbPessengerNumber.Text = sor[21].ToString();
                        cbManufacturingDate.Text = sor[22].ToString();
                        cbDoorsNumber.Text = sor[23].ToString();

                        rtbNote.Text = sor[16].ToString();
                        pbCarPhoto.ImageLocation= sor[24].ToString();
                        lblFileName.Text = sor[24].ToString();

         
                        if (int.Parse(sor[6].ToString()) == 1) chkbDocuments.Checked = true;
                        if (int.Parse(sor[7].ToString()) == 1) chkbEmergencyBox.Checked = true;
                        if (int.Parse(sor[8].ToString()) == 1) chkbSpareTyre.Checked = true;
                        if (int.Parse(sor[9].ToString()) == 1) chkbTriangle.Checked = true;
                        if (int.Parse(sor[10].ToString()) == 1) chkbAntenna.Checked = true;
                        if (int.Parse(sor[11].ToString()) == 1) chkbRadio.Checked = true;
                        if (int.Parse(sor[12].ToString()) == 1) chkbSpareLightBulb.Checked = true;
                        if (int.Parse(sor[13].ToString()) == 1) chkbJack.Checked = true;
                        if (int.Parse(sor[14].ToString()) == 1) chkbNavigation.Checked = true;
                        if (int.Parse(sor[15].ToString()) == 1) chkbWarningSuit.Checked = true;

                    }
                }

            }
            else
            {
                pbCarPhoto.ImageLocation = @"C:\Users\Frankie\source\repos\Szakdolgozat\Szakdolgozat\Resources\No_Photography.png";
                lblFileName.Text = @"C:\Users\Frankie\source\repos\Szakdolgozat\Szakdolgozat\Resources\No_Photography.png";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewBrand_Click(object sender, EventArgs e)
        {
            if (cbBrand.Text =="" || Brands.Contains(cbBrand.Text)) return;
            else
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        $"INSERT INTO gyarto (gyarto) " +
                        $"VALUES ('{cbBrand.Text}');", conn);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "" || Types.Contains(cbType.Text)) return;
            else
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        $"INSERT INTO tipus (tipus) " +
                        $"VALUES ('{cbType.Text}');", conn);
                    command.ExecuteNonQuery();
                }
            }
            //InitiateForm(Id);

        }

        private void btnNewColour_Click(object sender, EventArgs e)
        {
            if (cbColour.Text == "" || Colours.Contains(cbColour.Text)) return;
            else
            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        $"INSERT INTO szin (szin) " +
                        $"VALUES ('{cbColour.Text}');", conn);
                    command.ExecuteNonQuery();
                }
            }
            //InitiateForm(Id);

        }

        private void btnRemoveBrand_Click(object sender, EventArgs e)
        {
            if (Brands.Contains(cbBrand.Text)) 
            
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        var command = new MySqlCommand(
                            $"DELETE FROM gyarto " +
                            $"WHERE gyarto= '{cbBrand.Text}';", conn);
                        command.ExecuteNonQuery();
                    }
                }
            cbBrand.Text = "";
            //InitiateForm(Id);
        }

        private void btnRemoveType_Click(object sender, EventArgs e)
        {
            if (Types.Contains(cbType.Text))

            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        $"DELETE FROM tipus " +
                        $"WHERE tipus= '{cbType.Text}';", conn);
                    command.ExecuteNonQuery();
                }
            }
            cbType.Text = "";
        }

        private void btnRemoveColour_Click(object sender, EventArgs e)
        {
            if (Colours.Contains(cbColour.Text))

            {
                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        $"DELETE FROM szin " +
                        $"WHERE szin= '{cbColour.Text}';", conn);
                    command.ExecuteNonQuery();
                }
            }
            cbColour.Text = "";
            //InitiateForm(Id);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (cbBrand.Text == "") ErrorMessage += "A 'Gyarto' mezo ures\n";
            if (cbType.Text == "") ErrorMessage += "A 'Tipus' mezo ures\n";
            if (cbNumberPlate.Text == "") ErrorMessage += "A 'Rendszam' mezo ures\n";
            if (cbVinNumber.Text == "") ErrorMessage += "A 'Rendszam' mezo ures\n";
            if (cbColour.Text == "") ErrorMessage += "A 'Szin' mezo ures\n";
            if (cbPessengerNumber.Text == "" || int.TryParse(cbPessengerNumber.Text,out _) ==false) ErrorMessage += "A 'Szemelyek szama' mezo hibas\n";
            if (cbManufacturingDate.Text == "" || int.TryParse(cbManufacturingDate.Text, out _) == false) ErrorMessage += "A 'Gyartasi ev' mezo hibas\n";
            if (cbDoorsNumber.Text == "" || int.TryParse(cbDoorsNumber.Text, out _) == false) ErrorMessage += "Az 'Ajtok Szama' mezo hibas\n";
            
            if(ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage);
                return;
            }
            
            int [] b = new int[10];

            b[0] = chkbDocuments.Checked ? 1 : 0;
            b[1] = chkbEmergencyBox.Checked ? 1 : 0;
            b[2] = chkbSpareTyre.Checked ? 1 : 0;
            b[3] = chkbTriangle.Checked ? 1 : 0;
            b[4] = chkbAntenna.Checked ? 1 : 0;
            b[5] = chkbRadio.Checked ? 1 : 0;
            b[6] = chkbSpareLightBulb.Checked ? 1 : 0;
            b[7] = chkbJack.Checked ? 1 : 0;
            b[8] = chkbNavigation.Checked ? 1 : 0;
            b[9] = chkbWarningSuit.Checked ? 1 : 0;

            string ds = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() +
                "-" + dateTimePicker1.Value.Day.ToString();

            if (Id > 0)
            {
                string path = lblFileName.Text;
                path=path.Replace(@"\","/");

                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        $"UPDATE gk_torzs " +
                        $"SET " +
                        $"gyarto='{cbBrand.Text}', " +
                        $"tipus='{cbType.Text}', " +
                        $"szin='{cbColour.Text}', " +
                        $"alvazszam='{cbVinNumber.Text}', " +
                        $"rendszam='{cbNumberPlate.Text}', " +
                        $"dokumentum_b={b[0]}, " +
                        $"elsosegely_b={b[1]}, " +
                        $"potkerek_b={b[2]}, " +
                        $"elakadasj_b={b[3]}, " +
                        $"antenna_b={b[4]}, " +
                        $"radio_b={b[5]}, " +
                        $"izzokeszlet_b={b[6]}, " +
                        $"emelo_b={b[7]}, " +
                        $"navigacio_b={b[8]}, " +
                        $"melleny_b={b[9]}, " +
                        $"megjegyzes='{rtbNote.Text}', " +
                        $"muszaki_ervenyes='{ds}', " +
                        $"kategoria='{cbCategory.Text}', " +
                        $"valto_tipus='{cbGearchangeType.Text}', " +
                        $"uzemanyag='{cbFuelType.Text}', " +
                        $"szemelyek_szama={int.Parse(cbPessengerNumber.Text)}, " +
                        $"gyartasi_ev={int.Parse(cbManufacturingDate.Text)}, " +
                        $"ajtok_szama={int.Parse(cbDoorsNumber.Text)}, " +
                        $"picture='{path}' " +
                        $"WHERE gk_id={Id};", conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Adatok frissitve!");
                    this.Close();
                }

            }
            else
            {
                string path = lblFileName.Text;
                path = path.Replace(@"\", "/");

                using (var conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    var command = new MySqlCommand(
                        $"INSERT INTO gk_torzs (gyarto, tipus, szin, alvazszam, rendszam, " +
                        $"dokumentum_b, elsosegely_b, potkerek_b, elakadasj_b, antenna_b, radio_b, izzokeszlet_b, " +
                        $"emelo_b, navigacio_b, melleny_b, megjegyzes, muszaki_ervenyes, kategoria, valto_tipus, " +
                        $"uzemanyag, szemelyek_szama, gyartasi_ev, ajtok_szama, picture) " +
                        $"VALUES (" +
                        $"'{cbBrand.Text}', " +
                        $"'{cbType.Text}', " +
                        $"'{cbColour.Text}', " +
                        $"'{cbVinNumber.Text}', " +
                        $"'{cbNumberPlate.Text}', " +
                        $"{b[0]}, " +
                        $"{b[1]}, " +
                        $"{b[2]}, " +
                        $"{b[3]}, " +
                        $"{b[4]}, " +
                        $"{b[5]}, " +
                        $"{b[6]}, " +
                        $"{b[7]}, " +
                        $"{b[8]}, " +
                        $"{b[9]}, " +
                        $"'{rtbNote.Text}', " +
                        $"'{ds}', " +
                        $"'{cbCategory.Text}', " +
                        $"'{cbGearchangeType.Text}', " +
                        $"'{cbFuelType.Text}', " +
                        $"{int.Parse(cbPessengerNumber.Text)}, " +
                        $"{int.Parse(cbManufacturingDate.Text)}, " +
                        $"{int.Parse(cbDoorsNumber.Text)}, " +
                        $"'{path}' " +
                        $");", conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uj gepjarmu elmentve");
                    this.Close();
                }

            }


        }

        private void btnPictureSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Valaszd ki a kepet";
            fileDialog.Filter = "Minden file (*.*)|*.*|PNG (*.png)|*.png";
            fileDialog.FilterIndex = 1;
            fileDialog.InitialDirectory = @"C:\Users\Frankie\source\repos\Szakdolgozat\Szakdolgozat\Resources\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = fileDialog.FileName;
                pbCarPhoto.ImageLocation = fileDialog.FileName;
            }
        }

        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnClose.BackColor = Properties.Settings.Default.ColorButton;
            this.btnNewBrand.BackColor = Properties.Settings.Default.ColorButton;
            this.btnNewColour.BackColor = Properties.Settings.Default.ColorButton;
            this.btnNewType.BackColor = Properties.Settings.Default.ColorButton;
            this.btnPictureSelect.BackColor = Properties.Settings.Default.ColorButton;
            this.btnRemoveBrand.BackColor = Properties.Settings.Default.ColorButton;
            this.btnRemoveColour.BackColor = Properties.Settings.Default.ColorButton;
            this.btnRemoveType.BackColor = Properties.Settings.Default.ColorButton;
            this.btnSave.BackColor = Properties.Settings.Default.ColorButton;
        }
    }
}
