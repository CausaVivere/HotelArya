namespace HotelArya
{
    partial class main
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.roomsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(19)))), ((int)(((byte)(26)))));
            this.navPanel.Location = new System.Drawing.Point(12, 12);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(193, 657);
            this.navPanel.TabIndex = 0;
            // 
            // roomsPanel
            // 
            this.roomsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.roomsPanel.Location = new System.Drawing.Point(211, 76);
            this.roomsPanel.Name = "roomsPanel";
            this.roomsPanel.Size = new System.Drawing.Size(1041, 593);
            this.roomsPanel.TabIndex = 1;
            this.roomsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.topPanel.Controls.Add(this.createButton);
            this.topPanel.Controls.Add(this.datePicker);
            this.topPanel.Location = new System.Drawing.Point(211, 12);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1041, 58);
            this.topPanel.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(73)))), ((int)(((byte)(166)))));
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(10, 10);
            this.createButton.Margin = new System.Windows.Forms.Padding(10);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(155, 41);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Add Room";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Geist", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(185, 10);
            this.datePicker.Margin = new System.Windows.Forms.Padding(10);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(256, 39);
            this.datePicker.TabIndex = 1;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // main
            // 
            this.AccessibleName = "main";
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.roomsPanel);
            this.Controls.Add(this.navPanel);
            this.Font = new System.Drawing.Font("Geist", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "main";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.FlowLayoutPanel roomsPanel;
        private System.Windows.Forms.FlowLayoutPanel topPanel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}