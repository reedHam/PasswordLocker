using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using BCr = BCrypt.Net.BCrypt;

namespace PasswordLocker {
    public partial class PasswordLocker : Form {
        public PasswordLocker() {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(450, 250);
            if (File.Exists("Passwords.sqlite") || File.Exists("user.pl")) {
                pnlLogin.Visible = true;
                pnlLogin.Dock = DockStyle.Fill;
            } else {
                pnlSetup.Visible = true;
                pnlSetup.Dock = DockStyle.Fill;
            }

        }

        string DBpass;

        private void setup() {
            
        }

        private void createDB() {
            SQLiteConnection.CreateFile("Passwords.sqlite");

            SQLiteConnection dbConnection;

            dbConnection = new SQLiteConnection("Data Source=Passwords.sqlite;Version=3;Password="+ DBpass + ";");

            dbConnection.Open();
            string site = "CREATE TABLE Site (S_ID INTEGER, Name VARCHAR(50), Url VARCHAR(75));";
            string account = "CREATE TABLE Account (SiteUrl VARCHAR(75), UserName VARCHAR(30), Email VARCHAR(75), Password VARCHAR(50), 'Two-Step' BOOLEAN);";
            string sql = site + account;

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

            command.ExecuteNonQuery();

        }

        // pressing enter on the textboxes submits the passwords
        
        //Top textbox
        private void txtSetupPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                passSubmit.PerformClick();
            }
        }

        private void txtSetupPassword_TextChanged(object sender, EventArgs e) {
            lbMisMatch.Visible = false;
            txtSetupPassword.BackColor = SystemColors.Window;
            txtSetupPasswordCon.BackColor = SystemColors.Window;
        }

        //bottom textbox
        private void setupPasswordCon_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                passSubmit.PerformClick();
            }
        }

        private void txtSetupPasswordCon_TextChanged(object sender, EventArgs e) {
            lbMisMatch.Visible = false;
            txtSetupPassword.BackColor = SystemColors.Window;
            txtSetupPasswordCon.BackColor = SystemColors.Window;
        }

        // logon textbox
        private void txtLogin_TextChanged(object sender, EventArgs e) {
            lbPassInc.Visible = false;
            txtLogin.BackColor = SystemColors.Window;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                login.PerformClick();
            }
        }

        //submit button for the setup pannle
        private void passSubmit_Click(object sender, EventArgs e) {
            if (txtSetupPassword.Text == txtSetupPasswordCon.Text) {
                DBpass = txtSetupPassword.Text;

                string hash = BCr.HashPassword(DBpass, BCr.GenerateSalt());

                File.WriteAllText("user.pl", hash);

                pnlLogin.Visible = false;
                pnlLogin.Visible = true;
                pnlLogin.Dock = DockStyle.Fill;

                createDB();


            } else {
                //displays that the passwords did not match
                lbMisMatch.Visible = true;
                txtSetupPassword.BackColor = Color.DarkRed;
                txtSetupPasswordCon.BackColor = Color.DarkRed;

            }
        }

        //shows the passwords while the mouse is down
        private void showPass_MouseDown(object sender, MouseEventArgs e) {
            txtSetupPassword.UseSystemPasswordChar = false;
            txtSetupPasswordCon.UseSystemPasswordChar = false;
        }

        private void showPass_MouseUp(object sender, MouseEventArgs e) {
            txtSetupPassword.UseSystemPasswordChar = true;
            txtSetupPasswordCon.UseSystemPasswordChar = true;
        }

        //logs onto the program
        private void login_Click(object sender, EventArgs e) {
            string hash = File.ReadAllText("user.pl");
            DBpass = txtLogin.Text;
            if (BCr.Verify(DBpass, hash)) {
                System.Console.Write("worked");
                test();
            } else {
                lbPassInc.Visible = true;
                txtLogin.BackColor = Color.DarkRed;
            }
        }

        private void showLogonPass_MouseDown(object sender, MouseEventArgs e) {
            txtLogin.UseSystemPasswordChar = false;
        }

        private void showLogonPass_MouseUp(object sender, MouseEventArgs e) {
            txtLogin.UseSystemPasswordChar = true;
        }

        private void test() {
            SQLiteConnection dbConnection;

            dbConnection = new SQLiteConnection("Data Source=Passwords.sqlite;Version=3;Password=" + DBpass + ";");


            dbConnection.Open();
            string sql = "INSERT INTO Site VALUES (1, 'test', 'www.test.com')";

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

            command.ExecuteNonQuery();

            sql = "SELECT * FROM Site";

            command = new SQLiteCommand(sql, dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read()) {
                Console.WriteLine("ID " + reader["S_ID"] + "\tName " + reader["Name"] + "\tUrl " + reader["Url"]);
            }

            dbConnection.Close();
        }
    }  

}



    

