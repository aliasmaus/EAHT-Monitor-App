namespace EAHT_App_UI
{
    partial class LoginPage
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
            this.Exit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AccessibleDescription = "Exit";
            this.Exit.AccessibleName = "Exit";
            this.Exit.Location = new System.Drawing.Point(458, 323);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 68);
            this.Exit.TabIndex = 0;
            this.Exit.Tag = "Exit";
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.Login.AccessibleDescription = "Login";
            this.Login.AccessibleName = "Login";
            this.Login.Location = new System.Drawing.Point(171, 323);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(128, 68);
            this.Login.TabIndex = 1;
            this.Login.Tag = "Login";
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 38);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 38);
            this.textBox2.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AccessibleDescription = "Username";
            this.Username.AccessibleName = "Username";
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Username.Location = new System.Drawing.Point(153, 109);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(118, 31);
            this.Username.TabIndex = 4;
            this.Username.Tag = "Username";
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // Password
            // 
            this.Password.AccessibleDescription = "Password";
            this.Password.AccessibleName = "Password";
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.Control;
            this.Password.Location = new System.Drawing.Point(153, 200);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(111, 31);
            this.Password.TabIndex = 5;
            this.Password.Tag = "Password";
            this.Password.Text = "Password";
            // 
            // LoginPage
            // 
            this.AccessibleDescription = "Login Page";
            this.AccessibleName = "Login Page";
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LoginPage";
            this.Tag = "Login Page";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
    }
}