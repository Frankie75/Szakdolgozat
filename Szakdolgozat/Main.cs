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

        private Form activeForm = null;

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

            frmLogin f = new frmLogin(ConnectionString);
            f.ShowDialog();
        }

    private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(childForm);
            pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            openChildForm(new Setting());
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExit());
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDevicesAdmin(ConnectionString));
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomerAdmin(ConnectionString));
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserAdmin(ConnectionString));
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
           openChildForm(new Contract(ConnectionString));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/");
        }
    }
}
;