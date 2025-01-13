using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace HotelArya
{
    public partial class main : Form
    {

        private void SetupResponsivePanels()
        {
            this.navPanel.Dock = DockStyle.Left;

            this.roomsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.roomsPanel.Location = new System.Drawing.Point(this.navPanel.Width, this.topPanel.Height);
            this.roomsPanel.Size = new System.Drawing.Size(this.ClientSize.Width - this.navPanel.Width, this.ClientSize.Height - this.topPanel.Height);

            this.topPanel.Dock = DockStyle.Top;

            this.Resize += Main_Resize;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            this.roomsPanel.Size = new System.Drawing.Size(this.ClientSize.Width - this.navPanel.Width, this.ClientSize.Height - this.topPanel.Height);
        }
        public main()
        {
            InitializeComponent();
            SetupResponsivePanels();
            this.Shown += Main_Shown; 
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            LoadRooms(); 
        }

        private void LoadRooms()
        {

            if (!this.IsHandleCreated)
            {
                this.HandleCreated += (s, e) => LoadRooms();
                return;
            }

            this.roomsPanel.Controls.Clear();

            try
            {
                if (DatabaseHelper.Connection.State == ConnectionState.Closed)
                {
                    DatabaseHelper.Connection.Open();
                }

                string query = "SELECT number, capacity, floor, price, ID FROM Rooms";
                using (OleDbCommand command = new OleDbCommand(query, DatabaseHelper.Connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roomNumber = Convert.ToInt32(reader["number"]);
                            int roomId = Convert.ToInt32(reader["ID"]);
                            string capacity = reader["capacity"].ToString();
                            int price = Convert.ToInt32(reader["price"]);
                            string status = "available";
                            DateTime date = datePicker.Value;
                            try
                            {
                                using (OleDbConnection statusConnection = new OleDbConnection(DatabaseHelper.Connection.ConnectionString))
                                {
                                    statusConnection.Open();
                                    string statusQuery = @"
                                        SELECT R.[ID], RC.[roomNr], RC.[reservedFor], RC.[days]
                                        FROM [ReservationDetails] AS RC
                                        INNER JOIN [Reservations] AS R ON RC.[reservationId] = R.[ID]
                                        WHERE RC.roomNr = @roomNumber
                                        AND (RC.reservedFor <= @date AND DATEADD('d', RC.days, RC.reservedFor) > @date)";

                                    using (OleDbCommand statusCommand = new OleDbCommand(statusQuery, statusConnection))
                                    {
                                        // Add parameters in the correct order
                                        statusCommand.Parameters.Add("@roomNumber", OleDbType.Integer).Value = roomNumber;
                                        statusCommand.Parameters.Add("@date", OleDbType.Date).Value = date.Date;
                                        statusCommand.Parameters.Add("@date", OleDbType.Date).Value = date.Date;

                                        using (OleDbDataReader statusReader = statusCommand.ExecuteReader())
                                        {
                                            if (statusReader.HasRows)
                                            {
                                                status = "unavailable";
                                          
                                            }
                                        }
                                    }

                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            this.Invoke(new Action(() =>
                            {
                                Button roomButton = new Button
                                {
                                    Width = 200,
                                    Height = 200,
                                    BackColor = status == "available" ? Color.FromArgb(15, 73, 166) : Color.FromArgb(166, 15, 15),
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat,
                                    Font = new Font("Geist", 12, FontStyle.Bold),
                                    Text = $"Room: {roomNumber}\nCapacity: {capacity}\nPrice: ${price}\nStatus: {status}",
                                    Margin = new Padding(10)
                                };

                                roomButton.FlatAppearance.BorderSize = 0;

                                roomButton.Click += (s, e) =>
                                {
                                    //MessageBox.Show($"Room {roomNumber} clicked!", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if(status == "available")
                                    {
                                        addReservation addReservationDialog = new addReservation(date, roomId, roomNumber, price);
                                        DialogResult result = addReservationDialog.ShowDialog();
                                        if (result == DialogResult.OK)
                                        {
                                            LoadRooms();
                                        }
                                    }
                                };

                                this.roomsPanel.Controls.Add(roomButton);
                            }));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (DatabaseHelper.Connection.State == ConnectionState.Open)
                {
                    DatabaseHelper.Connection.Close();
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createRoom createRoomDialog = new createRoom();

            DialogResult result = createRoomDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                //MessageBox.Show("Room creation was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
            }
            else
            {
                //MessageBox.Show("Room creation was canceled or failed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }
    }
}
