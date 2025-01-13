namespace HotelArya
{
    partial class createRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.nrLabel = new System.Windows.Forms.Label();
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorInput = new System.Windows.Forms.NumericUpDown();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.capacityInput = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createRoomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geist SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(160, 112);
            this.numberInput.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(300, 35);
            this.numberInput.TabIndex = 1;
            // 
            // nrLabel
            // 
            this.nrLabel.AutoSize = true;
            this.nrLabel.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrLabel.ForeColor = System.Drawing.Color.White;
            this.nrLabel.Location = new System.Drawing.Point(35, 113);
            this.nrLabel.Name = "nrLabel";
            this.nrLabel.Size = new System.Drawing.Size(119, 34);
            this.nrLabel.TabIndex = 2;
            this.nrLabel.Text = "Number";
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorLabel.ForeColor = System.Drawing.Color.White;
            this.floorLabel.Location = new System.Drawing.Point(35, 162);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(81, 34);
            this.floorLabel.TabIndex = 4;
            this.floorLabel.Text = "Floor";
            this.floorLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // floorInput
            // 
            this.floorInput.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorInput.Location = new System.Drawing.Point(160, 161);
            this.floorInput.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.floorInput.Name = "floorInput";
            this.floorInput.Size = new System.Drawing.Size(300, 35);
            this.floorInput.TabIndex = 3;
            this.floorInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Geist SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLabel.ForeColor = System.Drawing.Color.White;
            this.capacityLabel.Location = new System.Drawing.Point(35, 210);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(117, 31);
            this.capacityLabel.TabIndex = 6;
            this.capacityLabel.Text = "Capacity";
            // 
            // capacityInput
            // 
            this.capacityInput.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityInput.Location = new System.Drawing.Point(160, 209);
            this.capacityInput.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.capacityInput.Name = "capacityInput";
            this.capacityInput.Size = new System.Drawing.Size(300, 35);
            this.capacityInput.TabIndex = 5;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Geist SemiBold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(36, 256);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(121, 29);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price/Day";
            // 
            // priceInput
            // 
            this.priceInput.Font = new System.Drawing.Font("Geist", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.Location = new System.Drawing.Point(160, 256);
            this.priceInput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(300, 35);
            this.priceInput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Image";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(41, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 218);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // createRoomButton
            // 
            this.createRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(98)))), ((int)(((byte)(201)))));
            this.createRoomButton.FlatAppearance.BorderSize = 0;
            this.createRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRoomButton.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRoomButton.ForeColor = System.Drawing.Color.White;
            this.createRoomButton.Location = new System.Drawing.Point(60, 567);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.Size = new System.Drawing.Size(376, 73);
            this.createRoomButton.TabIndex = 11;
            this.createRoomButton.Text = "Submit";
            this.createRoomButton.UseVisualStyleBackColor = false;
            this.createRoomButton.Click += new System.EventHandler(this.createRoomButton_Click);
            // 
            // createRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(494, 652);
            this.Controls.Add(this.createRoomButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.capacityInput);
            this.Controls.Add(this.floorLabel);
            this.Controls.Add(this.floorInput);
            this.Controls.Add(this.nrLabel);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "createRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "createRoom";
            this.Load += new System.EventHandler(this.createRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.Label nrLabel;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.NumericUpDown floorInput;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.NumericUpDown capacityInput;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createRoomButton;
    }
}