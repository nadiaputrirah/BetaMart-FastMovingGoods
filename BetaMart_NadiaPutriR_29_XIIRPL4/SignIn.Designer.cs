namespace BetaMart_NadiaPutriR_29_XIIRPL4
{
    partial class SignIn
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
            this.titleLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLogin = new System.Windows.Forms.Label();
            this.pwdLogin = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLogin
            // 
            this.titleLogin.AutoSize = true;
            this.titleLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLogin.Location = new System.Drawing.Point(191, 29);
            this.titleLogin.Name = "titleLogin";
            this.titleLogin.Size = new System.Drawing.Size(291, 29);
            this.titleLogin.TabIndex = 0;
            this.titleLogin.Text = "Selamat datang di BetaMart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetaMart_NadiaPutriR_29_XIIRPL4.Properties.Resources.img_login;
            this.pictureBox1.Location = new System.Drawing.Point(212, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userLogin
            // 
            this.userLogin.AutoSize = true;
            this.userLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogin.Location = new System.Drawing.Point(208, 359);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(90, 24);
            this.userLogin.TabIndex = 2;
            this.userLogin.Text = "Username";
            // 
            // pwdLogin
            // 
            this.pwdLogin.AutoSize = true;
            this.pwdLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLogin.Location = new System.Drawing.Point(209, 441);
            this.pwdLogin.Name = "pwdLogin";
            this.pwdLogin.Size = new System.Drawing.Size(85, 24);
            this.pwdLogin.TabIndex = 3;
            this.pwdLogin.Text = "Password";
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxName.Location = new System.Drawing.Point(212, 396);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(247, 28);
            this.boxName.TabIndex = 4;
            // 
            // boxPassword
            // 
            this.boxPassword.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPassword.Location = new System.Drawing.Point(212, 478);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(247, 28);
            this.boxPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(212, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sign In untuk mendapatkan akses login";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSignIn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(150, 569);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(387, 47);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(730, 677);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.pwdLogin);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLogin);
            this.Name = "SignIn";
            this.Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLogin;
        private System.Windows.Forms.Label pwdLogin;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignIn;
    }
}

