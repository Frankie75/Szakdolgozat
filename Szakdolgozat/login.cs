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
    public partial class frmLogin : Form
    {
        static public string ConnectionString;
        public bool passed = false;
        public frmLogin(string c)
        {
            InitializeComponent();
            ConnectionString = c;

            //delete!!!
            tbUsername.Text = "admin";
            tbPassword.Text = "admin";
            //delete!!!
        }

        public class user
        {
            public string user_id { get; set; } 
            public string username { get; set; }
            public string password { get; set; }

        }

        private List<user> Users = new List<user>();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
      
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                var conn = new MySqlConnection(ConnectionString);
                conn.Open();
                var command = new MySqlCommand("select * from felhasznalok;", conn);
                var r = command.ExecuteReader();
                while (r.Read())
                {

                    var u = new user();
                    u.user_id = r[0].ToString();
                    u.username = r[1].ToString();
                    u.password = r[2].ToString();
                    Users.Add(u);
                }
                r.Close();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Adatbazis elerese sikertelen, a program kilep!", "Hibauzenet");
                Properties.Settings.Default.PasswordValid = false;
                Application.Exit();
                
            }



            foreach (user u in Users)
            {
                if(u.username == tbUsername.Text)
                {
                    if (EncryptDecrypt(tbPassword.Text, 1) == u.password)
                    {
                        Properties.Settings.Default.UserName=u.username;
                        Properties.Settings.Default.PasswordValid = true;
                    }
                        
                }
            }
            if (Properties.Settings.Default.PasswordValid)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Hibas felhasznalo nev, vagy jelszo");
            }
        
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
                  
        }
    }
}
