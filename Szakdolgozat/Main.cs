using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Szakdolgozat
{
    public partial class formMain : Form
    {
        static public string ConnectionString;
//      static public string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=autokolcsonzo";


        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }

        public formMain()
        {
            InitializeComponent();

            frmConnectionPw cpw = new frmConnectionPw();
            cpw.ShowDialog();

            ConnectionString = $"Server = frankie75.hu; Database = frankieh_autokolcsonzo; Uid = {Properties.Settings.Default.ConnectionName}; Pwd = {Properties.Settings.Default.ConnectionPassword}";


            cbFilter.Items.Add("Minden szerzodes");
            cbFilter.Items.Add("Aktiv, folyamatban levo");
            cbFilter.Items.Add("Lezart, visszavett");
            cbFilter.SelectedIndex = 0;

            frmLogin f = new frmLogin(ConnectionString);
            f.ShowDialog();


        }

        private void formMain_Load(object sender, EventArgs e)
        {
            
            if (!Properties.Settings.Default.PasswordValid) Application.Exit();
          
            refresDGV("");
            
        }

        public void refresDGV(string name_filter)
        {

            dgvMain.Rows.Clear();
            string isActive = "not";
            var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            var command = new MySqlCommand(
                "select szerzodes_id, unev, iranyitoszam, helyseg, cim, gyarto, tipus, " +
                "rendszam, kiadas_datum, lejarat_datum, visszavet_datum " +
                "from gk_torzs, uf_torzs, szerzodesek " +
                "where " +
                "szerzodesek.uf_id = uf_torzs.uf_id and " +
                "szerzodesek.gk_id = gk_torzs.gk_id and " +
                $"szerzodesek.visszavet_datum is {isActive} null and " +
                $"unev like '{name_filter + '%'}';",conn);
            var rows = command.ExecuteReader();
            while (rows.Read())
            {
                string address= rows[2] + " "+ rows[3] +  " " + rows[4];
                string car = rows[5] + " " + rows[6];

                dgvMain.Rows.Add(
                    rows[0], rows[1], address, car,
                    rows[7], rows[8], rows[9], rows[10]);
            }

            conn.Close();

        }

        private void formMain_MouseClick(object sender, MouseEventArgs e)
        {
      
        }

        private void tbSearchName_KeyUp(object sender, KeyEventArgs e)
        {
            refresDGV(tbSearchName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           frmExit frmExit = new frmExit();
           frmExit.ShowDialog();

        }

        private void kilepesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExit frmExit = new frmExit();
            frmExit.ShowDialog();
        }

        private void felhasznaloAdminisztracioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserAdmin frmUserAdmin = new frmUserAdmin(ConnectionString);
            frmUserAdmin.ShowDialog();
        }

        private void ugyfeltorzsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCustomerAdmin(ConnectionString);
            f.Show();

        }

        private void eszkozokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDevicesAdmin(ConnectionString);
            f.Show();
        }
    }
}
;