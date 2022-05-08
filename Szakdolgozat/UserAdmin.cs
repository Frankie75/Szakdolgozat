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
    public partial class frmUserAdmin : Form
    {
        static string ConnectionString;
        List<User> Users = new List<User>();
        class User
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }

            public User (string id, string name, string password)
            {
                Id = id;
                Name = name;
                Password = password;

            }

        }
        enum actions
        {
            newUser,
            deleteUser,
            changePassword
        }

        actions action;


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


        public frmUserAdmin(string c)
        {
            InitializeComponent();
            ConnectionString = c;

            using (var conn = new MySqlConnection(ConnectionString))
            {
                var command = new MySqlCommand("SELECT * from felhasznalok;", conn);
                conn.Open();
                var r = command.ExecuteReader();    
                while (r.Read())
                {

                    Users.Add(new User(r[0].ToString(), r[1].ToString(), r[2].ToString()));
                    Felhasznalok.Items.Add(r[1].ToString());
                }
            }

        
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            action=actions.newUser;
            tbUserName.Text = "";
            Felhasznalok.Enabled = false;
      
            gbAction.Text = "Felhasznalo hozzaadasa";
            tbUserName.Enabled = true;
            tbPassword.Enabled = true;
            tbPasswordAgain.Enabled = true;
            tbPasswordNew.Enabled = false;
            btnAction.Text = "Felhasznalo Hozzaadasa";
            btnAction.Enabled = true;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            action = actions.deleteUser;
            tbUserName.Text = Felhasznalok.Items[0].ToString();
            
            Felhasznalok.Enabled= true;
            gbAction.Text = "Felhasznalo torlese";
            tbUserName.Enabled = false;
            tbPassword.Enabled = true;
            tbPasswordAgain.Enabled = false;
            tbPasswordNew.Enabled = false;
            btnAction.Text = "Felhasznalo Torlese";
            btnAction.Enabled = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            action = actions.changePassword;
            tbUserName.Text = Felhasznalok.Items[0].ToString();

            Felhasznalok.Enabled = true;
            gbAction.Text = "Jelszo modositasa";
            tbUserName.Enabled = false;
            tbPassword.Enabled = true;
            tbPasswordAgain.Enabled = false;
            tbPasswordNew.Enabled = true;
            btnAction.Text = "Jelszo modositasa";
            btnAction.Enabled = true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            bool vanilyenfelhasznalo = false;
            switch (action)
            {
                case actions.newUser:

                    if(Users.Count >= 10)
                    {
                        MessageBox.Show("A felhasznalok maximalis szama: 10 db.");
                        break;
                    }
                    foreach (var item in Users)
                    {
                        if (item.Name == tbUserName.Text)
                        {
                            MessageBox.Show("Van mar ilyen nevu felhasznalo!");
                            vanilyenfelhasznalo = true;
                            break;
                        }

                    }
                    if (vanilyenfelhasznalo) break;

                    if (tbUserName.Text.Length < 4 | tbUserName.Text.Length > 8)
                    {
                        MessageBox.Show("A megadott felhasznalonevnek 4-8 karakter husszunak kell lennie!");
                        break;
                    }

                    if (tbPassword.Text != tbPasswordAgain.Text)
                    {
                        MessageBox.Show("A megadott jelszavak nem egyeznek meg!");
                        break;
                    }
                    if (tbPassword.Text.Length < 4 | tbPassword.Text.Length > 8)
                    {
                        MessageBox.Show("A megadott jelszonak 4-8 karakter hosszunak kell lennie!");
                        break;
                    }

                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        var command = new MySqlCommand("INSERT INTO " +
                            "felhasznalok (fnev,jelszo) VALUES " +
                            $"('{tbUserName.Text}', '{EncryptDecrypt(tbPassword.Text, 1)}');", conn);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Felhasznalo hozzaadva");
                    this.Close();
                    break;

                case actions.deleteUser:
                    if (tbUserName.Text == "admin")
                    {
                        MessageBox.Show("Az 'admin' felhasznalo nem torolhato!");
                        break;
                    }

                    foreach (var item in Users)
                    {

                        if (item.Name == tbUserName.Text)
                        {
                            if (EncryptDecrypt(item.Password, 1) == tbPassword.Text)
                            {
                                using (var conn = new MySqlConnection(ConnectionString))
                                {
                                    conn.Open();
                                    var command = new MySqlCommand("DELETE FROM felhasznalok " +
                                        $"WHERE fnev='{item.Name}';", conn);
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Felhasznalo Torolve");
                                this.Close();

                                break;

                            }

                            else
                            {
                                MessageBox.Show("Hibas jelszo!");
                            }

                        }

                    }
                   
                    break;

                case actions.changePassword:

                    if(tbPasswordNew.Text.Length <4 | tbPasswordNew.Text.Length > 8)
                    {
                        MessageBox.Show("Az uj jelszo hosszana 4-8 karakter!");
                        break;
                    }

                    foreach (var item in Users)
                    {
                        if (item.Name == tbUserName.Text)
                        {
                            if (tbPassword.Text == EncryptDecrypt(item.Password, 1))
                            {
                                using (var conn = new MySqlConnection(ConnectionString))
                                {
                                    conn.Open();
                                    var command = new MySqlCommand("UPDATE felhasznalok " +
                                        $"SET jelszo='{EncryptDecrypt(tbPasswordNew.Text,1)}' " +
                                        $"WHERE fnev = '{item.Name}';",conn);
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Jelszo modositva");
                                this.Close();
                                break;

                            }
                            else
                            {
                                MessageBox.Show("Hibas a jelszo!");
                            }

                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void Felhasznalok_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbUserName.Text = Felhasznalok.Text;
            tbPassword.Text = "";
        }

        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnAction.BackColor = Properties.Settings.Default.ColorButton;
            this.btnAddNewUser.BackColor = Properties.Settings.Default.ColorButton;
            this.btnChangePassword.BackColor = Properties.Settings.Default.ColorButton;
            this.btnClose.BackColor = Properties.Settings.Default.ColorButton;
            this.btnDeleteUser.BackColor = Properties.Settings.Default.ColorButton;
            
        }

        private void frmUserAdmin_Load(object sender, EventArgs e)
        {
            SetColor();
        }
    }
}