using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Contract : Form
    {
        static public string ConnectionString;
        public Contract(string c)
        {
            InitializeComponent();
            ConnectionString = c;
            refreshDGV("");
        }
        public void refreshDGV(string name_filter)
        {
            dgvMain.Rows.Clear();
            string InsertedString = "";
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
                $"{InsertedString} " +
                $"unev like '{name_filter + '%'}';", conn);
            var rows = command.ExecuteReader();
            while (rows.Read())
            {
                string address = rows[2] + " " + rows[3] + " " + rows[4];
                string car = rows[5] + " " + rows[6];

                dgvMain.Rows.Add(
                    rows[0], rows[1], address, car,
                    rows[7], rows[8], rows[9], rows[10]);
            }
            conn.Close();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PasswordValid == false) Application.Exit();

            else refreshDGV("");
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            refreshDGV(tbSearchName.Text);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDGV("");
        }

        private void btnCloseContract_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows[0].Cells[7].Value.ToString() != "")
            {
                MessageBox.Show("A szerződés már le van zárva!");
                return;
            }
            int ContractId = (int)dgvMain.SelectedRows[0].Cells[0].Value;
            var f = new frmContractCloser(ConnectionString, ContractId);
            f.ShowDialog();
            refreshDGV("");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {
            var f = new frmNewContract(ConnectionString);
                        f.ShowDialog();
                        refreshDGV("");
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            SetColor();
        }
        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnNewContract.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCloseContract.BackColor = Properties.Settings.Default.ColorButton;
            this.btnPrint.BackColor = Properties.Settings.Default.ColorButton;

        }
    }
}
