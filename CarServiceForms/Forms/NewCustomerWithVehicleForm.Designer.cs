namespace CarServiceForms.Forms
{
    partial class NewCustomerWithVehicleForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.customerPostTextBox = new System.Windows.Forms.TextBox();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.customerStreetTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vehicleModelYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vehicleMileageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vehicleRegistrationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.vehicleGKBTextBox = new System.Windows.Forms.TextBox();
            this.vehicleMKBTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeCodeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vehicleIdentificationNumberTextBox = new System.Windows.Forms.TextBox();
            this.vehicleRegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleModelYearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMileageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(192, 336);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(273, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerPhoneTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.searchCustomerButton);
            this.groupBox1.Controls.Add(this.customerPostTextBox);
            this.groupBox1.Controls.Add(this.customerLastNameTextBox);
            this.groupBox1.Controls.Add(this.customerStreetTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerFirstNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stranka";
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(314, 71);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(191, 20);
            this.customerPhoneTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(430, 97);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Počisti";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.Location = new System.Drawing.Point(349, 97);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.searchCustomerButton.TabIndex = 10;
            this.searchCustomerButton.Text = "Išči";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.SearchCustomerButton_Click);
            // 
            // customerPostTextBox
            // 
            this.customerPostTextBox.Location = new System.Drawing.Point(72, 71);
            this.customerPostTextBox.Name = "customerPostTextBox";
            this.customerPostTextBox.Size = new System.Drawing.Size(187, 20);
            this.customerPostTextBox.TabIndex = 7;
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Location = new System.Drawing.Point(314, 19);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.customerLastNameTextBox.TabIndex = 3;
            // 
            // customerStreetTextBox
            // 
            this.customerStreetTextBox.Location = new System.Drawing.Point(72, 45);
            this.customerStreetTextBox.Name = "customerStreetTextBox";
            this.customerStreetTextBox.Size = new System.Drawing.Size(433, 20);
            this.customerStreetTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pošta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ulica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priimek";
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(72, 19);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(187, 20);
            this.customerFirstNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vehicleModelYearNumericUpDown);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.vehicleMileageNumericUpDown);
            this.groupBox2.Controls.Add(this.vehicleRegistrationDateDateTimePicker);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.vehicleGKBTextBox);
            this.groupBox2.Controls.Add(this.vehicleMKBTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.vehicleTypeTextBox);
            this.groupBox2.Controls.Add(this.vehicleTypeCodeTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.vehicleIdentificationNumberTextBox);
            this.groupBox2.Controls.Add(this.vehicleRegistrationNumberTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vozilo";
            // 
            // vehicleModelYearNumericUpDown
            // 
            this.vehicleModelYearNumericUpDown.Location = new System.Drawing.Point(72, 97);
            this.vehicleModelYearNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.vehicleModelYearNumericUpDown.Name = "vehicleModelYearNumericUpDown";
            this.vehicleModelYearNumericUpDown.Size = new System.Drawing.Size(187, 20);
            this.vehicleModelYearNumericUpDown.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Modelno l.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Št. km";
            // 
            // vehicleMileageNumericUpDown
            // 
            this.vehicleMileageNumericUpDown.Location = new System.Drawing.Point(314, 149);
            this.vehicleMileageNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.vehicleMileageNumericUpDown.Name = "vehicleMileageNumericUpDown";
            this.vehicleMileageNumericUpDown.Size = new System.Drawing.Size(191, 20);
            this.vehicleMileageNumericUpDown.TabIndex = 17;
            // 
            // vehicleRegistrationDateDateTimePicker
            // 
            this.vehicleRegistrationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vehicleRegistrationDateDateTimePicker.Location = new System.Drawing.Point(72, 149);
            this.vehicleRegistrationDateDateTimePicker.Name = "vehicleRegistrationDateDateTimePicker";
            this.vehicleRegistrationDateDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.vehicleRegistrationDateDateTimePicker.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Dat. 1. reg.";
            // 
            // vehicleGKBTextBox
            // 
            this.vehicleGKBTextBox.Location = new System.Drawing.Point(314, 123);
            this.vehicleGKBTextBox.Name = "vehicleGKBTextBox";
            this.vehicleGKBTextBox.Size = new System.Drawing.Size(191, 20);
            this.vehicleGKBTextBox.TabIndex = 13;
            // 
            // vehicleMKBTextBox
            // 
            this.vehicleMKBTextBox.Location = new System.Drawing.Point(72, 123);
            this.vehicleMKBTextBox.Name = "vehicleMKBTextBox";
            this.vehicleMKBTextBox.Size = new System.Drawing.Size(187, 20);
            this.vehicleMKBTextBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "GKB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "MKB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Koda tipa";
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(314, 71);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(191, 20);
            this.vehicleTypeTextBox.TabIndex = 7;
            // 
            // vehicleTypeCodeTextBox
            // 
            this.vehicleTypeCodeTextBox.Location = new System.Drawing.Point(72, 71);
            this.vehicleTypeCodeTextBox.Name = "vehicleTypeCodeTextBox";
            this.vehicleTypeCodeTextBox.Size = new System.Drawing.Size(187, 20);
            this.vehicleTypeCodeTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ident. št.";
            // 
            // vehicleIdentificationNumberTextBox
            // 
            this.vehicleIdentificationNumberTextBox.Location = new System.Drawing.Point(72, 45);
            this.vehicleIdentificationNumberTextBox.Name = "vehicleIdentificationNumberTextBox";
            this.vehicleIdentificationNumberTextBox.Size = new System.Drawing.Size(433, 20);
            this.vehicleIdentificationNumberTextBox.TabIndex = 3;
            // 
            // vehicleRegistrationNumberTextBox
            // 
            this.vehicleRegistrationNumberTextBox.Location = new System.Drawing.Point(72, 19);
            this.vehicleRegistrationNumberTextBox.Name = "vehicleRegistrationNumberTextBox";
            this.vehicleRegistrationNumberTextBox.Size = new System.Drawing.Size(433, 20);
            this.vehicleRegistrationNumberTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reg. št.";
            // 
            // NewCustomerWithVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(541, 371);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomerWithVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova stranka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCustomerWithVehicleForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleModelYearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMileageNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox customerPostTextBox;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox customerStreetTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker vehicleRegistrationDateDateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vehicleGKBTextBox;
        private System.Windows.Forms.TextBox vehicleMKBTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.TextBox vehicleTypeCodeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vehicleIdentificationNumberTextBox;
        private System.Windows.Forms.TextBox vehicleRegistrationNumberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown vehicleMileageNumericUpDown;
        private System.Windows.Forms.NumericUpDown vehicleModelYearNumericUpDown;
        private System.Windows.Forms.Label label14;
    }
}