using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelArya
{
    public partial class createRoom : Form
    {
        private string base64Image = string.Empty;
        public createRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createRoom_Load(object sender, EventArgs e)
        {

        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                int roomNumber = (int)numberInput.Value;
                int floor = (int)floorInput.Value;
                int capacity = (int)capacityInput.Value;
                decimal price = priceInput.Value;

                if (floor == 0)
                {
                    MessageBox.Show("Floor cannot be 0. Please enter a valid floor number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (capacity == 0)
                {
                    MessageBox.Show("Capacity cannot be 0. Please enter a valid capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (price == 0)
                {
                    MessageBox.Show("Price per day cannot be 0. Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(base64Image))
                {
                    MessageBox.Show("Please select an image for the room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO Rooms ([number], [capacity], [floor], [price], [image]) " +
                                "VALUES (@RoomNumber, @Capacity, @Floor, @PricePerDay, @Image)";

                using (OleDbCommand command = new OleDbCommand(query, DatabaseHelper.Connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    command.Parameters.AddWithValue("@Floor", floor);
                    command.Parameters.AddWithValue("@Capacity", capacity);
                    command.Parameters.AddWithValue("@PricePerDay", price);
                    command.Parameters.AddWithValue("@Image", base64Image);

                    if (DatabaseHelper.Connection.State == ConnectionState.Closed)
                    {
                        DatabaseHelper.Connection.Open();
                    }

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the room. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                // Ensure the connection is closed
                if (DatabaseHelper.Connection.State == ConnectionState.Open)
                {
                    DatabaseHelper.Connection.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image selectedImage = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = selectedImage;

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        selectedImage.Save(memoryStream, selectedImage.RawFormat);
                        byte[] imageBytes = memoryStream.ToArray();
                        base64Image = Convert.ToBase64String(imageBytes);
                    }

                    MessageBox.Show("Image successfully loaded and converted to Base64.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    
}
}
