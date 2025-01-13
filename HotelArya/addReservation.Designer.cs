namespace HotelArya
{
    partial class addReservation
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
            this.daysInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.phoneNrInput = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.daysInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geist SemiBold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserve Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Days";
            // 
            // daysInput
            // 
            this.daysInput.Font = new System.Drawing.Font("Geist", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysInput.Location = new System.Drawing.Point(218, 288);
            this.daysInput.Name = "daysInput";
            this.daysInput.Size = new System.Drawing.Size(260, 43);
            this.daysInput.TabIndex = 2;
            this.daysInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last  Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Geist SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Nr.";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Geist", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInput.Location = new System.Drawing.Point(218, 141);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(260, 43);
            this.firstNameInput.TabIndex = 6;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Geist", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInput.Location = new System.Drawing.Point(218, 190);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(260, 43);
            this.lastNameInput.TabIndex = 7;
            // 
            // phoneNrInput
            // 
            this.phoneNrInput.Font = new System.Drawing.Font("Geist", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNrInput.Location = new System.Drawing.Point(218, 239);
            this.phoneNrInput.Name = "phoneNrInput";
            this.phoneNrInput.Size = new System.Drawing.Size(260, 43);
            this.phoneNrInput.TabIndex = 8;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(98)))), ((int)(((byte)(201)))));
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Geist SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(130, 386);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(275, 73);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // addReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(549, 493);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.phoneNrInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.daysInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addReservation";
            ((System.ComponentModel.ISupportInitialize)(this.daysInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown daysInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox phoneNrInput;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox lastNameInput;
    }
}