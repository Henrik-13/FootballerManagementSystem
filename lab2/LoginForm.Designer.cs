namespace FootballerManagementSystem
{
    partial class LoginForm
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btRegistration = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.btLoginGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(175, 94);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(102, 16);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Felhasznalonev";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(231, 171);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(46, 16);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Jelszo";
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(337, 94);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(212, 22);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(337, 165);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(212, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(56, 373);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(104, 38);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Kilepes";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(644, 369);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(104, 42);
            this.btRegistration.TabIndex = 5;
            this.btRegistration.Text = "Regisztracio";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(379, 246);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(147, 41);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Bejelentkezes";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btLoginGuest
            // 
            this.btLoginGuest.Location = new System.Drawing.Point(349, 309);
            this.btLoginGuest.Name = "btLoginGuest";
            this.btLoginGuest.Size = new System.Drawing.Size(200, 41);
            this.btLoginGuest.TabIndex = 7;
            this.btLoginGuest.Text = "Bejelentkezes vendegkent";
            this.btLoginGuest.UseVisualStyleBackColor = true;
            this.btLoginGuest.Click += new System.EventHandler(this.btLoginGuest_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLoginGuest);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btLoginGuest;
    }
}