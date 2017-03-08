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
            MaximumSize = new System.Drawing.Size(450, 250);

            if (File.Exists("Passwords.sqlite") || File.Exists("user.pl")) {
                this.AcceptButton = login;// sets the button pressed when enter is hit
                pnlLogin.Visible = true;
                pnlLogin.Dock = DockStyle.Fill;
            } else {
                this.AcceptButton = passSubmit;
                pnlSetup.Visible = true;
                pnlSetup.Dock = DockStyle.Fill;
            }

        }

        string DBpass;

        private void createDB() {
            SQLiteConnection.CreateFile("Passwords.sqlite");

            SQLiteConnection dbConnection = openDB();
            dbConnection.Open();

            string site = "CREATE TABLE Site (S_ID INTEGER PRIMARY KEY NOT NULL, Name VARCHAR(50), Url VARCHAR(75));";
            string account = "CREATE TABLE Account (A_ID INTEGER PRIMARY KEY NOT NULL, S_ID INTEGER, UserName VARCHAR(30), Email VARCHAR(75), Password VARCHAR(50), FOREIGN KEY(S_ID) REFERENCES Site(S_ID));";
            string sql = site + account;

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);

            command.ExecuteNonQuery();

        }

        //opens the database
        public SQLiteConnection openDB() {
            SQLiteConnection dbConnection;
            dbConnection = new SQLiteConnection("Data Source=Passwords.sqlite;Version=3;Password=" + DBpass + ";");
            return dbConnection;
        }
        
        //Top textbox
        private void txtSetupPassword_TextChanged(object sender, EventArgs e) {
            lbMisMatch.Visible = false;
            txtSetupPassword.BackColor = SystemColors.Window;
            txtSetupPasswordCon.BackColor = SystemColors.Window;
        }

        //bottom textbox
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

      //submit button for the setup pannle
        private void passSubmit_Click(object sender, EventArgs e) {
            if (txtSetupPassword.Text == txtSetupPasswordCon.Text) {
                DBpass = txtSetupPassword.Text;

                string hash = BCr.HashPassword(DBpass, BCr.GenerateSalt());

                File.WriteAllText("user.pl", hash);
  
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

        //logs onto the program
        private void login_Click(object sender, EventArgs e) {
            string hash = File.ReadAllText("user.pl");
            DBpass = txtLogin.Text;
            if (BCr.Verify(DBpass, hash)) {

                this.AcceptButton = null;
                this.MaximumSize = pnlMain.Size;
                this.Size = pnlMain.Size;
                pnlMain.Visible = true;
                pnlMain.Dock = DockStyle.Fill;

                populateGrid();

            } else {
                lbPassInc.Visible = true;
                txtLogin.BackColor = Color.DarkRed;
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

        private void showLogonPass_MouseDown(object sender, MouseEventArgs e) {
            txtLogin.UseSystemPasswordChar = false;
        }

        private void showLogonPass_MouseUp(object sender, MouseEventArgs e) {
            txtLogin.UseSystemPasswordChar = true;
        }

        //adds an site to the database
        private void addNewSite_Click(object sender, EventArgs e) {
            AddSite addSite = new AddSite();
            addSite.StartPosition = FormStartPosition.Manual;
            addSite.Location = this.Location;
            addSite.ShowDialog();
        }

        //adds an Account to the database
        private void btnNew_Click(object sender, EventArgs e) {
            AddAccount addAccount= new AddAccount();
            addAccount.StartPosition = FormStartPosition.Manual;
            addAccount.Location = this.Location;
            addAccount.ShowDialog();
        }

        public void populateGrid() {
            DataTable dataSource = new DataTable();
            SQLiteConnection dbconnection = openDB();
            dbconnection.Open();

            string sqlSite = "SELECT * FROM Account;";

            SQLiteCommand command = new SQLiteCommand(sqlSite, dbconnection);

            SQLiteDataReader reader = command.ExecuteReader();

            dataSource.Load(reader);

            dbconnection.Close();

            grid.DataSource = dataSource;

            grid.Columns[0].Visible = false;
            grid.Refresh();
        }

        private void PasswordLocker_Activated(object sender, EventArgs e) {
            populateGrid();
        }

        
    }  

}



    

