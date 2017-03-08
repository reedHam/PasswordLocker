namespace PasswordLocker {
    partial class PasswordLocker {
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.Button();
            this.lbMisMatch = new System.Windows.Forms.Label();
            this.passSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSetupPasswordCon = new System.Windows.Forms.TextBox();
            this.txtSetupPassword = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.showLogonPass = new System.Windows.Forms.Button();
            this.lbPassInc = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.addNewSite = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSetup.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlSetup
            // 
            this.pnlSetup.Controls.Add(this.label6);
            this.pnlSetup.Controls.Add(this.showPass);
            this.pnlSetup.Controls.Add(this.lbMisMatch);
            this.pnlSetup.Controls.Add(this.passSubmit);
            this.pnlSetup.Controls.Add(this.label3);
            this.pnlSetup.Controls.Add(this.label2);
            this.pnlSetup.Controls.Add(this.label1);
            this.pnlSetup.Controls.Add(this.txtSetupPasswordCon);
            this.pnlSetup.Controls.Add(this.txtSetupPassword);
            this.pnlSetup.Location = new System.Drawing.Point(12, 12);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(440, 368);
            this.pnlSetup.TabIndex = 1;
            this.pnlSetup.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "to use to access your password locker";
            // 
            // showPass
            // 
            this.showPass.Location = new System.Drawing.Point(302, 88);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(114, 23);
            this.showPass.TabIndex = 7;
            this.showPass.Text = "Show Passwords";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPass_MouseDown);
            this.showPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPass_MouseUp);
            // 
            // lbMisMatch
            // 
            this.lbMisMatch.AutoSize = true;
            this.lbMisMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMisMatch.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMisMatch.Location = new System.Drawing.Point(96, 64);
            this.lbMisMatch.Name = "lbMisMatch";
            this.lbMisMatch.Size = new System.Drawing.Size(216, 20);
            this.lbMisMatch.TabIndex = 6;
            this.lbMisMatch.Text = "The passwords did not match";
            this.lbMisMatch.UseWaitCursor = true;
            this.lbMisMatch.Visible = false;
            // 
            // passSubmit
            // 
            this.passSubmit.Location = new System.Drawing.Point(100, 139);
            this.passSubmit.Name = "passSubmit";
            this.passSubmit.Size = new System.Drawing.Size(196, 23);
            this.passSubmit.TabIndex = 5;
            this.passSubmit.Text = "Submit";
            this.passSubmit.UseVisualStyleBackColor = true;
            this.passSubmit.Click += new System.EventHandler(this.passSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please enter the password you would like ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // txtSetupPasswordCon
            // 
            this.txtSetupPasswordCon.Location = new System.Drawing.Point(100, 113);
            this.txtSetupPasswordCon.Name = "txtSetupPasswordCon";
            this.txtSetupPasswordCon.Size = new System.Drawing.Size(196, 20);
            this.txtSetupPasswordCon.TabIndex = 1;
            this.txtSetupPasswordCon.UseSystemPasswordChar = true;
            this.txtSetupPasswordCon.TextChanged += new System.EventHandler(this.txtSetupPasswordCon_TextChanged);
            // 
            // txtSetupPassword
            // 
            this.txtSetupPassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtSetupPassword.Location = new System.Drawing.Point(100, 87);
            this.txtSetupPassword.Name = "txtSetupPassword";
            this.txtSetupPassword.Size = new System.Drawing.Size(196, 20);
            this.txtSetupPassword.TabIndex = 0;
            this.txtSetupPassword.UseSystemPasswordChar = true;
            this.txtSetupPassword.TextChanged += new System.EventHandler(this.txtSetupPassword_TextChanged);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.showLogonPass);
            this.pnlLogin.Controls.Add(this.lbPassInc);
            this.pnlLogin.Controls.Add(this.login);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Location = new System.Drawing.Point(458, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(462, 368);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.Visible = false;
            // 
            // showLogonPass
            // 
            this.showLogonPass.Location = new System.Drawing.Point(292, 100);
            this.showLogonPass.Name = "showLogonPass";
            this.showLogonPass.Size = new System.Drawing.Size(114, 23);
            this.showLogonPass.TabIndex = 8;
            this.showLogonPass.Text = "Show Passwords";
            this.showLogonPass.UseVisualStyleBackColor = true;
            this.showLogonPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showLogonPass_MouseDown);
            this.showLogonPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showLogonPass_MouseUp);
            // 
            // lbPassInc
            // 
            this.lbPassInc.AutoSize = true;
            this.lbPassInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassInc.ForeColor = System.Drawing.Color.DarkRed;
            this.lbPassInc.Location = new System.Drawing.Point(117, 79);
            this.lbPassInc.Name = "lbPassInc";
            this.lbPassInc.Size = new System.Drawing.Size(158, 20);
            this.lbPassInc.TabIndex = 8;
            this.lbPassInc.Text = "Password is incorrect";
            this.lbPassInc.UseWaitCursor = true;
            this.lbPassInc.Visible = false;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(34, 124);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(372, 23);
            this.login.TabIndex = 8;
            this.login.Text = "Submit";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Please unlock your locker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(90, 102);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogin.Size = new System.Drawing.Size(196, 20);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.UseSystemPasswordChar = true;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.addNewSite);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.btnNew);
            this.pnlMain.Controls.Add(this.grid);
            this.pnlMain.Location = new System.Drawing.Point(926, 13);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(976, 525);
            this.pnlMain.TabIndex = 3;
            // 
            // addNewSite
            // 
            this.addNewSite.Location = new System.Drawing.Point(718, 32);
            this.addNewSite.Name = "addNewSite";
            this.addNewSite.Size = new System.Drawing.Size(111, 23);
            this.addNewSite.TabIndex = 4;
            this.addNewSite.Text = "Add new site";
            this.addNewSite.UseVisualStyleBackColor = true;
            this.addNewSite.Click += new System.EventHandler(this.addNewSite_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(835, 32);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add new account";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 63);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(934, 416);
            this.grid.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search by URL";
            // 
            // PasswordLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1970, 552);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlSetup);
            this.Name = "PasswordLocker";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.PasswordLocker_Activated);
            this.pnlSetup.ResumeLayout(false);
            this.pnlSetup.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.TextBox txtSetupPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSetupPasswordCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button passSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMisMatch;
        private System.Windows.Forms.Button showPass;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label lbPassInc;
        private System.Windows.Forms.Button showLogonPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button addNewSite;
        private System.Windows.Forms.Label label7;
    }
}

