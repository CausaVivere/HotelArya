namespace HotelArya
{
    partial class viewReservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.roomValue = new System.Windows.Forms.Label();
            this.userValue = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.daysValue = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geist SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geist SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 1;
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.ForeColor = System.Drawing.Color.White;
            this.roomLabel.Location = new System.Drawing.Point(38, 153);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(104, 39);
            this.roomLabel.TabIndex = 2;
            this.roomLabel.Text = "Room";
            this.roomLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // roomValue
            // 
            this.roomValue.AutoSize = true;
            this.roomValue.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomValue.ForeColor = System.Drawing.Color.White;
            this.roomValue.Location = new System.Drawing.Point(148, 153);
            this.roomValue.Name = "roomValue";
            this.roomValue.Size = new System.Drawing.Size(30, 39);
            this.roomValue.TabIndex = 3;
            this.roomValue.Text = "1";
            // 
            // userValue
            // 
            this.userValue.AutoSize = true;
            this.userValue.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userValue.ForeColor = System.Drawing.Color.White;
            this.userValue.Location = new System.Drawing.Point(148, 213);
            this.userValue.Name = "userValue";
            this.userValue.Size = new System.Drawing.Size(331, 39);
            this.userValue.TabIndex = 5;
            this.userValue.Text = "FirstName LastName";
            this.userValue.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(38, 213);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(87, 39);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "User";
            this.userLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValue.ForeColor = System.Drawing.Color.White;
            this.dateValue.Location = new System.Drawing.Point(148, 266);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(186, 39);
            this.dateValue.TabIndex = 7;
            this.dateValue.Text = "12.02.2004";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(38, 266);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(87, 39);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date";
            // 
            // daysValue
            // 
            this.daysValue.AutoSize = true;
            this.daysValue.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysValue.ForeColor = System.Drawing.Color.White;
            this.daysValue.Location = new System.Drawing.Point(148, 317);
            this.daysValue.Name = "daysValue";
            this.daysValue.Size = new System.Drawing.Size(37, 39);
            this.daysValue.TabIndex = 9;
            this.daysValue.Text = "3";
            this.daysValue.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.ForeColor = System.Drawing.Color.White;
            this.daysLabel.Location = new System.Drawing.Point(38, 317);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(90, 39);
            this.daysLabel.TabIndex = 8;
            this.daysLabel.Text = "Days";
            this.daysLabel.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "350 ron";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Geist SemiBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sum";
            this.label4.Click += new System.EventHandler(this.label4_Click_2);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Geist SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(109, 466);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(275, 73);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // viewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(515, 577);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.daysValue);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.userValue);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.roomValue);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "viewReservation";
            this.Load += new System.EventHandler(this.viewReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label roomValue;
        private System.Windows.Forms.Label userValue;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label daysValue;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
    }
}