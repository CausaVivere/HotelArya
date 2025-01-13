using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelArya
{
    public partial class addReservation : Form
    {
        DateTime reservationTime;
        int roomId;
        int roomNr;
        int price;
        int clientId;
        int reservationId;

        public addReservation(DateTime reservationTime, int roomId, int roomNr, int price)
        {
            InitializeComponent();
            this.reservationTime = reservationTime;
            this.roomId = roomId;
            this.roomNr = roomNr;
            this.price = price;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createClient()
        {
            string firstName = firstNameInput.Text;
            string lastName = lastNameInput.Text;
            string phone = phoneNrInput.Text;
            if (firstName.Length == 0 || lastName.Length == 0 || phone.Length == 0)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phone.Length < 9)
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
              
                string query = "INSERT INTO Clients ([firstName], [lastName], [phoneNumber]) " +
                                "VALUES (@firstName, @lastName, @phoneNumber)";

                using (OleDbCommand command = new OleDbCommand(query, DatabaseHelper.Connection))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@phoneNumber", phone);

                    if (DatabaseHelper.Connection.State == ConnectionState.Closed)
                    {
                        DatabaseHelper.Connection.Open();
                    }

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        //MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        query = "SELECT MAX(id) FROM Clients";
                        using (OleDbCommand command2 = new OleDbCommand(query, DatabaseHelper.Connection))
                        {
                            using (OleDbDataReader reader = command2.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    clientId = reader.GetInt32(0);
                                    createReservation();
                                }
                            }
                        }   

                    }
                    else
                    {
                        MessageBox.Show("Failed to add the room. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DatabaseHelper.Connection.State == ConnectionState.Open)
                {
                    DatabaseHelper.Connection.Close();
                }
            }

        }

        private void createReservation()
        {
            try
            {
                string query = "INSERT INTO Reservations ([dateAt], [clientId]) VALUES (@dateAt, @clientId)";
                using (OleDbCommand command = new OleDbCommand(query, DatabaseHelper.Connection))
                {
                    command.Parameters.Add("@dateAt", OleDbType.Date).Value = DateTime.Today;
                    command.Parameters.Add("@clientId", OleDbType.Integer).Value = clientId;

                    if (DatabaseHelper.Connection.State == ConnectionState.Closed)
                    {
                        DatabaseHelper.Connection.Open();
                    }

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        query = "SELECT MAX(id) FROM Reservations";
                        using (OleDbCommand command2 = new OleDbCommand(query, DatabaseHelper.Connection))
                        {
                            using (OleDbDataReader reader = command2.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    reservationId = reader.GetInt32(0);
                                     createReservationDetails();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DatabaseHelper.Connection.State == ConnectionState.Open)
                {
                    DatabaseHelper.Connection.Close();
                }
            }
        }


        private void createReservationDetails()
        {
            try
            {
                string query = "INSERT INTO ReservationDetails ([roomId], [roomNr], [reservationId], [reservedFor], [price], [days]) " +
                  "VALUES (@roomId, @roomNr, @reservationId, @reservedFor, @price, @days)";
                using (OleDbCommand command = new OleDbCommand(query, DatabaseHelper.Connection))
                {
                    command.Parameters.Add("@roomId", OleDbType.Integer).Value = roomId;
                    command.Parameters.Add("@roomNr", OleDbType.Integer).Value = roomNr;
                    command.Parameters.Add("@reservationId", OleDbType.Integer).Value = reservationId;
                    command.Parameters.Add("@reservedFor", OleDbType.Date).Value = reservationTime.Date;
                    command.Parameters.Add("@price", OleDbType.Decimal).Value = price * daysInput.Value;
                    command.Parameters.Add("@days", OleDbType.Integer).Value = (int)daysInput.Value;

                    if (DatabaseHelper.Connection.State == ConnectionState.Closed)
                    {
                        DatabaseHelper.Connection.Open();
                    }
                    command.ExecuteNonQuery();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DatabaseHelper.Connection.State == ConnectionState.Open)
                {
                    DatabaseHelper.Connection.Close();
                }
            }
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            createClient();
        }
    }
}
