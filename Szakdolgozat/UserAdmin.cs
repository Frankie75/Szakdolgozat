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
        };

        actions action;


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
                }
            }

            lbFelhasznalokSzama.Text = Users.Count.ToString();
        
        
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            action=actions.newUser;
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
            gbAction.Text = "Felhasznalo torlese";
            tbUserName.Enabled = true;
            tbPassword.Enabled = true;
            tbPasswordAgain.Enabled = false;
            tbPasswordNew.Enabled = false;
            btnAction.Text = "Felhasznalo Torlese";
            btnAction.Enabled = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            action = actions.changePassword;
            gbAction.Text = "Jelszo modositasa";
            tbUserName.Enabled = true;
            tbPassword.Enabled = true;
            tbPasswordAgain.Enabled = false;
            tbPasswordNew.Enabled = true;
            btnAction.Text = "Jelszo modositasa";
            btnAction.Enabled = true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case actions.newUser:
                    break;
                case actions.deleteUser:
                    break;
                case actions.changePassword:
                    break;
                default:
                    break;
            }
        }

  
    }
}
