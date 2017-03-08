namespace PasswordLocker {
    partial class AddSite {
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
            this.addSiteSubmit = new System.Windows.Forms.Button();
            this.txtAddSiteName = new System.Windows.Forms.TextBox();
            this.txtAddURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmptyField = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addSiteSubmit
            // 
            this.addSiteSubmit.Location = new System.Drawing.Point(108, 111);
            this.addSiteSubmit.Name = "addSiteSubmit";
            this.addSiteSubmit.Size = new System.Drawing.Size(159, 23);
            this.addSiteSubmit.TabIndex = 12;
            this.addSiteSubmit.Text = "Submit";
            this.addSiteSubmit.UseVisualStyleBackColor = true;
            this.addSiteSubmit.Click += new System.EventHandler(this.addSiteSubmit_Click);
            // 
            // txtAddSiteName
            // 
            this.txtAddSiteName.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.txtAddSiteName.Location = new System.Drawing.Point(167, 85);
            this.txtAddSiteName.Name = "txtAddSiteName";
            this.txtAddSiteName.Size = new System.Drawing.Size(100, 20);
            this.txtAddSiteName.TabIndex = 3;
            this.txtAddSiteName.TextChanged += new System.EventHandler(this.txtAddSiteName_TextChanged);
            // 
            // txtAddURL
            // 
            this.txtAddURL.Location = new System.Drawing.Point(167, 59);
            this.txtAddURL.Name = "txtAddURL";
            this.txtAddURL.Size = new System.Drawing.Size(100, 20);
            this.txtAddURL.TabIndex = 2;
            this.txtAddURL.TextChanged += new System.EventHandler(this.txtAddURL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEmptyField);
            this.panel1.Controls.Add(this.addSiteSubmit);
            this.panel1.Controls.Add(this.txtAddSiteName);
            this.panel1.Controls.Add(this.txtAddURL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 153);
            this.panel1.TabIndex = 0;
            // 
            // lblEmptyField
            // 
            this.lblEmptyField.AutoSize = true;
            this.lblEmptyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyField.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEmptyField.Location = new System.Drawing.Point(105, 30);
            this.lblEmptyField.Name = "lblEmptyField";
            this.lblEmptyField.Size = new System.Drawing.Size(138, 16);
            this.lblEmptyField.TabIndex = 13;
            this.lblEmptyField.Text = "A field was letft empty ";
            this.lblEmptyField.Visible = false;
            // 
            // AddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 176);
            this.Controls.Add(this.panel1);
            this.Name = "AddSite";
            this.Text = "Add New Site";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addSiteSubmit;
        private System.Windows.Forms.TextBox txtAddSiteName;
        private System.Windows.Forms.TextBox txtAddURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmptyField;
    }
}