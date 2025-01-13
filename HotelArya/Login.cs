using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelArya
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.panel1.Location = new Point(
            this.ClientSize.Width / 2 - this.panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - this.panel1.Size.Height / 2);
            this.panel1.Anchor = AnchorStyles.None;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes("hotelArya")))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                return Convert.ToBase64String(hash) == storedHash;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text; 
            string password = passwordInput.Text;
            Console.WriteLine(password);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "SELECT PasswordHash, Role FROM Users WHERE Username = @username";
                using (OleDbCommand command = new OleDbCommand(query, DatabaseHelper.Connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["PasswordHash"].ToString();
                            Console.WriteLine(storedHash);
                            string role = reader["Role"].ToString();

                            if (VerifyPassword(password, storedHash))
                            {
                                MessageBox.Show($"Welcome, {username}! Role: {role}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                main mainForm = new main();
                                mainForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

  
    }
