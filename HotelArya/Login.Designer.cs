namespace HotelArya
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordInput);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.usernameInput);
            this.panel1.Location = new System.Drawing.Point(401, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 624);
            this.panel1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "loginButton";
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Geist SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(149, 403);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 52);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Sign In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AccessibleName = "passwordLabel";
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Geist", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(14, 285);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(147, 37);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // passwordInput
            // 
            this.passwordInput.AccessibleName = "passwordInput";
            this.passwordInput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.passwordInput.Font = new System.Drawing.Font("Geist", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(21, 325);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(422, 43);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AccessibleName = "usernameLabel";
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Geist", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(14, 189);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(152, 37);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Geist", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(21, 229);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(422, 43);
            this.usernameInput.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button loginButton;
    }
}

