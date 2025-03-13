namespace FootballerManagementSystem
{
    partial class RegistrationForm
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPasswordAgain = new System.Windows.Forms.Label();
            this.tbPasswordAgain = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegistration = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(348, 156);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(212, 22);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(348, 85);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(212, 22);
            this.tbUsername.TabIndex = 6;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(242, 162);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(46, 16);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Jelszo";
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(186, 85);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(102, 16);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Felhasznalonev";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // lbPasswordAgain
            // 
            this.lbPasswordAgain.AutoSize = true;
            this.lbPasswordAgain.Location = new System.Drawing.Point(207, 233);
            this.lbPasswordAgain.Name = "lbPasswordAgain";
            this.lbPasswordAgain.Size = new System.Drawing.Size(81, 16);
            this.lbPasswordAgain.TabIndex = 8;
            this.lbPasswordAgain.Text = "Jelszo ismet";
            // 
            // tbPasswordAgain
            // 
            this.tbPasswordAgain.Location = new System.Drawing.Point(348, 233);
            this.tbPasswordAgain.Name = "tbPasswordAgain";
            this.tbPasswordAgain.Size = new System.Drawing.Size(212, 22);
            this.tbPasswordAgain.TabIndex = 9;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(633, 363);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(105, 38);
            this.btLogin.TabIndex = 10;
            this.btLogin.Text = "Bejelentkezes";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(388, 293);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(108, 51);
            this.btRegistration.TabIndex = 12;
            this.btRegistration.Text = "Regisztracio";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(70, 363);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(104, 38);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Kilepes";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPasswordAgain);
            this.Controls.Add(this.lbPasswordAgain);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPasswordAgain;
        private System.Windows.Forms.TextBox tbPasswordAgain;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.Button btExit;
    }
}