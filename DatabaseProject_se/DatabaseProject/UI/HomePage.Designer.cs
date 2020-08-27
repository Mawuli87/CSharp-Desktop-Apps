namespace DatabaseProject.UI
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameHome = new System.Windows.Forms.TextBox();
            this.txtEmailHome = new System.Windows.Forms.TextBox();
            this.txtPasswordHome = new System.Windows.Forms.TextBox();
            this.txtCountryHome = new System.Windows.Forms.ComboBox();
            this.btnDelete_Account = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeName
            // 
            this.welcomeName.AutoSize = true;
            this.welcomeName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeName.Location = new System.Drawing.Point(265, 38);
            this.welcomeName.Name = "welcomeName";
            this.welcomeName.Size = new System.Drawing.Size(248, 32);
            this.welcomeName.TabIndex = 0;
            this.welcomeName.Text = "Welcome: Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chang Account Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country";
            // 
            // txtNameHome
            // 
            this.txtNameHome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameHome.Location = new System.Drawing.Point(160, 140);
            this.txtNameHome.Name = "txtNameHome";
            this.txtNameHome.Size = new System.Drawing.Size(365, 33);
            this.txtNameHome.TabIndex = 6;
            // 
            // txtEmailHome
            // 
            this.txtEmailHome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailHome.Location = new System.Drawing.Point(160, 191);
            this.txtEmailHome.Name = "txtEmailHome";
            this.txtEmailHome.Size = new System.Drawing.Size(365, 33);
            this.txtEmailHome.TabIndex = 7;
            // 
            // txtPasswordHome
            // 
            this.txtPasswordHome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordHome.Location = new System.Drawing.Point(160, 230);
            this.txtPasswordHome.Name = "txtPasswordHome";
            this.txtPasswordHome.Size = new System.Drawing.Size(365, 33);
            this.txtPasswordHome.TabIndex = 8;
            // 
            // txtCountryHome
            // 
            this.txtCountryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryHome.FormattingEnabled = true;
            this.txtCountryHome.Items.AddRange(new object[] {
            "Ghana",
            "Uk",
            "Togo",
            "USA",
            "Benin",
            "Nigeria",
            "Canada"});
            this.txtCountryHome.Location = new System.Drawing.Point(160, 289);
            this.txtCountryHome.Name = "txtCountryHome";
            this.txtCountryHome.Size = new System.Drawing.Size(365, 28);
            this.txtCountryHome.TabIndex = 9;
            // 
            // btnDelete_Account
            // 
            this.btnDelete_Account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Account.Location = new System.Drawing.Point(385, 336);
            this.btnDelete_Account.Name = "btnDelete_Account";
            this.btnDelete_Account.Size = new System.Drawing.Size(140, 38);
            this.btnDelete_Account.TabIndex = 11;
            this.btnDelete_Account.Text = "Delete Account";
            this.btnDelete_Account.UseVisualStyleBackColor = true;
            this.btnDelete_Account.Click += new System.EventHandler(this.btnDelete_Account_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete_Account);
            this.Controls.Add(this.txtCountryHome);
            this.Controls.Add(this.txtPasswordHome);
            this.Controls.Add(this.txtEmailHome);
            this.Controls.Add(this.txtNameHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeName);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameHome;
        private System.Windows.Forms.TextBox txtEmailHome;
        private System.Windows.Forms.TextBox txtPasswordHome;
        private System.Windows.Forms.ComboBox txtCountryHome;
        private System.Windows.Forms.Button btnDelete_Account;
        private System.Windows.Forms.Button button1;
    }
}