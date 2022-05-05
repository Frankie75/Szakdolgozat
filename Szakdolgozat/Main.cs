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

            Properties.Settings.Default.ConnectionName = "frankieh_frankie";
            Properties.Settings.Default.ConnectionPassword = "ml1510domain";
            ConnectionString = $"Server = frankie75.hu; Database = frankieh_autokolcsonzo; Uid = {Properties.Settings.Default.ConnectionName}; Pwd = {Properties.Settings.Default.ConnectionPassword}; convert zero datetime=True";

            cbFilter.SelectedIndex = 0;

            frmLogin f = new frmLogin(ConnectionString);
            f.ShowDialog();


        }

        private void formMain_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.PasswordValid==false) Application.Exit();
          
            else refreshDGV("");
            
        }

        public void refreshDGV(string name_filter)
        {

            dgvMain.Rows.Clear();
            string InsertedString="";
            if (cbFilter.SelectedIndex == 0) InsertedString = "";
            else if (cbFilter.SelectedIndex == 1) InsertedString = "szerzodesek.visszavet_datum is NULL and ";
            else if (cbFilter.SelectedIndex == 2) InsertedString = "szerzodesek.visszavet_datum is not NULL and ";


            var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            var command = new MySqlCommand(
                "select szerzodes_id, unev, iranyitoszam, helyseg, cim, gyarto, tipus, " +
                "rendszam, kiadas_datum, lejarat_datum, visszavet_datum " +
                "from gk_torzs, uf_torzs, szerzodesek " +
                "where " +
                "szerzodesek.uf_id = uf_torzs.uf_id and " +
                "szerzodesek.gk_id = gk_torzs.gk_id and " +
                $"{InsertedString} "+
     //         $"szerzodesek.visszavet_datum is {isActive} null and " +
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
            refreshDGV(tbSearchName.Text);
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
            f.ShowDialog();

        }

        private void eszkozokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDevicesAdmin(ConnectionString);
            f.ShowDialog();
        }

        private void ujSzerzodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmNewContract(ConnectionString);
            f.ShowDialog();
            refreshDGV("");
           

        }

        private void cbFilter_DropDownClosed(object sender, EventArgs e)
        {
            refreshDGV("");
        }

        private void btnCloseContract_Click(object sender, EventArgs e)
        {
            if(dgvMain.SelectedRows[0].Cells[7].Value.ToString() != "")
            {
                MessageBox.Show("A szerzodes mar le van zarva!");
                return;
            }
            int ContractId = (int)dgvMain.SelectedRows[0].Cells[0].Value;
            var f= new frmContractCloser(ConnectionString, ContractId);
            f.ShowDialog();
            refreshDGV("");


        }
    }
}
;