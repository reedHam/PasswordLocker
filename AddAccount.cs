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
namespace PasswordLocker {
    public partial class AddAccount : Form {
        public AddAccount() {
            InitializeComponent();
            siteList.Columns.Add("Site", (siteList.Width - 4 - SystemInformation.VerticalScrollBarWidth), HorizontalAlignment.Left);
            fillCombo();
        }

        //fils the listview with sites in the database
        private void fillCombo() {
            PasswordLocker pswLkr = new PasswordLocker();
            SQLiteConnection dbConnection = pswLkr.openDB();
            dbConnection.Open();

            string sqlSelectSites = "SELECT S_ID, Name FROM Site;";
            SQLiteCommand command = new SQLiteCommand(sqlSelectSites, dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            while(reader.Read()) {
                ListViewItem tempListItem = new ListViewItem(new[] {reader["Name"].ToString()});
                tempListItem.Tag = reader["S_ID"].ToString();
                siteList.Items.Add(tempListItem);
            }
            dbConnection.Close();
            //TODO set to selected site on grid
            siteList.Refresh();
        }
       
        private void submitAccount_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtUserName.Text)) {
                lblEmptyField.Visible = true;

                if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                    txtEmail.BackColor = Color.DarkRed;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text)) {
                    txtPassword.BackColor = Color.DarkRed;
                }

                if (string.IsNullOrWhiteSpace(txtUserName.Text)) {
                    txtUserName.BackColor = Color.DarkRed;
                }
            } else {

                PasswordLocker pswLker = new PasswordLocker();
                SQLiteConnection dbConnection = pswLker.openDB();
                dbConnection.Open();

                string sqlAddSite = "INSERT INTO Account (S_ID, UserName, Email, Password) VALUES (@S_ID, @UserName, @Email, @Password);";
                SQLiteCommand command = new SQLiteCommand(sqlAddSite, dbConnection);
                command.Parameters.AddWithValue("@S_ID", siteList.SelectedItems[0].Tag);
                command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);

                command.ExecuteNonQuery();

                dbConnection.Close();
                Close();

            } 
        }
       
    }
}
