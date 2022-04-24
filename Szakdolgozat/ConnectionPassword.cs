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
    public partial class frmConnectionPw : Form
    {
        public frmConnectionPw()
        {
            InitializeComponent();
        }

        private void ConnectionPassword_Load(object sender, EventArgs e)
        {
            tbUserName.Text = "frankieh_frankie";
        }

     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionName = tbUserName.Text;
            Properties.Settings.Default.ConnectionPassword = tbPassword.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }
    }
}
