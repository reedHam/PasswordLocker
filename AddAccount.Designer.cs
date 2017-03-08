namespace PasswordLocker {
    partial class AddAccount {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.submitAccount = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Site = new System.Windows.Forms.Label();
            this.siteList = new System.Windows.Forms.ListView();
            this.lblEmptyField = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitAccount
            // 
            this.submitAccount.Location = new System.Drawing.Point(13, 227);
            this.submitAccount.Name = "submitAccount";
            this.submitAccount.Size = new System.Drawing.Size(216, 23);
            this.submitAccount.TabIndex = 11;
            this.submitAccount.Text = "Submit";
            this.submitAccount.UseVisualStyleBackColor = true;
            this.submitAccount.Click += new System.EventHandler(this.submitAccount_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(71, 175);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Site);
            this.panel1.Controls.Add(this.siteList);
            this.panel1.Controls.Add(this.lblEmptyField);
            this.panel1.Controls.Add(this.submitAccount);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 251);
            this.panel1.TabIndex = 1;
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Site.Location = new System.Drawing.Point(95, 36);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(56, 13);
            this.Site.TabIndex = 15;
            this.Site.Text = "Site Name";
            // 
            // siteList
            // 
            this.siteList.FullRowSelect = true;
            this.siteList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.siteList.HideSelection = false;
            this.siteList.Location = new System.Drawing.Point(13, 52);
            this.siteList.MultiSelect = false;
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(216, 97);
            this.siteList.TabIndex = 14;
            this.siteList.UseCompatibleStateImageBehavior = false;
            this.siteList.View = System.Windows.Forms.View.Details;
            // 
            // lblEmptyField
            // 
            this.lblEmptyField.AutoSize = true;
            this.lblEmptyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyField.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyField.Location = new System.Drawing.Point(47, 1);
            this.lblEmptyField.Name = "lblEmptyField";
            this.lblEmptyField.Size = new System.Drawing.Size(142, 24);
            this.lblEmptyField.TabIndex = 13;
            this.lblEmptyField.Text = "Field Left empty";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 270);
            this.Controls.Add(this.panel1);
            this.Name = "AddAccount";
            this.Text = "Add New Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button submitAccount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmptyField;
        private System.Windows.Forms.ListView siteList;
        private System.Windows.Forms.Label Site;
    }
}