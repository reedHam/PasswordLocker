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
    public partial class AddSite : Form {
        public AddSite() {
            InitializeComponent();
        }
        

        private void addSiteSubmit_Click(object sender, EventArgs e) {
            //checking to make sure somthing is entered
            if (string.IsNullOrWhiteSpace(txtAddSiteName.Text) || string.IsNullOrWhiteSpace(txtAddURL.Text)) {
                lblEmptyField.Visible = true;

                if (string.IsNullOrWhiteSpace(txtAddSiteName.Text)) {
                    txtAddSiteName.BackColor = Color.DarkRed;
                }
                if (string.IsNullOrWhiteSpace(txtAddURL.Text)) {
                    txtAddURL.BackColor = Color.DarkRed;
                }
            } else {

                PasswordLocker pswLker = new PasswordLocker();
                SQLiteConnection dbConnection = pswLker.openDB();
                dbConnection.Open();

                string sqlAddSite = "INSERT INTO Site (Name, Url) VALUES (@SiteName, @SiteUrl);";
                SQLiteCommand command = new SQLiteCommand(sqlAddSite, dbConnection);
                command.Parameters.AddWithValue("@SiteName", txtAddSiteName.Text);
                command.Parameters.AddWithValue("@SiteUrl", txtAddURL.Text);
                command.ExecuteNonQuery();

                dbConnection.Close();
                Close();
                
            }
            
        }

        //changes the colour back to the default
        private void txtAddURL_TextChanged(object sender, EventArgs e) {
            txtAddURL.BackColor = SystemColors.Window;
            if (!(string.IsNullOrWhiteSpace(txtAddSiteName.Text) || string.IsNullOrWhiteSpace(txtAddURL.Text))) {
                lblEmptyField.Visible = false;
            }
        }

        //changes the colour back to the default
        private void txtAddSiteName_TextChanged(object sender, EventArgs e) {
            txtAddSiteName.BackColor = SystemColors.Window;
            if (!(string.IsNullOrWhiteSpace(txtAddSiteName.Text) || string.IsNullOrWhiteSpace(txtAddURL.Text))) {
                lblEmptyField.Visible = false;
            }
        }
    }
}
