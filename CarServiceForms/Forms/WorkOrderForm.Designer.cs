﻿namespace CarServiceForms.Forms
{
    partial class WorkOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.customerDataTextBox = new System.Windows.Forms.TextBox();
            this.selectCustomerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.workOrderDeadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.wordOrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.workOrderInstructionsDataGridView = new System.Windows.Forms.DataGridView();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.vehicleModelYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMileageNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderInstructionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleModelYearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.customerDataTextBox);
            this.groupBox1.Controls.Add(this.selectCustomerButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stranka";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.vehicleModelYearNumericUpDown);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.vehicleMileageNumericUpDown);
            this.groupBox4.Controls.Add(this.vehicleRegistrationDateDateTimePicker);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.vehicleGKBTextBox);
            this.groupBox4.Controls.Add(this.vehicleMKBTextBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.vehicleTypeTextBox);
            this.groupBox4.Controls.Add(this.vehicleTypeCodeTextBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.vehicleIdentificationNumberTextBox);
            this.groupBox4.Controls.Add(this.vehicleRegistrationNumberTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 134);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vozilo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Št. km";
            // 
            // vehicleMileageNumericUpDown
            // 
            this.vehicleMileageNumericUpDown.Location = new System.Drawing.Point(319, 104);
            this.vehicleMileageNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.vehicleMileageNumericUpDown.Name = "vehicleMileageNumericUpDown";
            this.vehicleMileageNumericUpDown.Size = new System.Drawing.Size(187, 20);
            this.vehicleMileageNumericUpDown.TabIndex = 17;
            // 
            // vehicleRegistrationDateDateTimePicker
            // 
            this.vehicleRegistrationDateDateTimePicker.Enabled = false;
            this.vehicleRegistrationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vehicleRegistrationDateDateTimePicker.Location = new System.Drawing.Point(72, 104);
            this.vehicleRegistrationDateDateTimePicker.Name = "vehicleRegistrationDateDateTimePicker";
            this.vehicleRegistrationDateDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.vehicleRegistrationDateDateTimePicker.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Dat. 1. reg.";
            // 
            // vehicleGKBTextBox
            // 
            this.vehicleGKBTextBox.Location = new System.Drawing.Point(319, 73);
            this.vehicleGKBTextBox.Name = "vehicleGKBTextBox";
            this.vehicleGKBTextBox.ReadOnly = true;
            this.vehicleGKBTextBox.Size = new System.Drawing.Size(187, 20);
            this.vehicleGKBTextBox.TabIndex = 11;
            // 
            // vehicleMKBTextBox
            // 
            this.vehicleMKBTextBox.Location = new System.Drawing.Point(72, 73);
            this.vehicleMKBTextBox.Name = "vehicleMKBTextBox";
            this.vehicleMKBTextBox.ReadOnly = true;
            this.vehicleMKBTextBox.Size = new System.Drawing.Size(187, 20);
            this.vehicleMKBTextBox.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "GKB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "MKB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tip vozila";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Koda tipa";
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(208, 45);
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.ReadOnly = true;
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(298, 20);
            this.vehicleTypeTextBox.TabIndex = 7;
            // 
            // vehicleTypeCodeTextBox
            // 
            this.vehicleTypeCodeTextBox.Location = new System.Drawing.Point(72, 45);
            this.vehicleTypeCodeTextBox.Name = "vehicleTypeCodeTextBox";
            this.vehicleTypeCodeTextBox.ReadOnly = true;
            this.vehicleTypeCodeTextBox.Size = new System.Drawing.Size(72, 20);
            this.vehicleTypeCodeTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ident. št.";
            // 
            // vehicleIdentificationNumberTextBox
            // 
            this.vehicleIdentificationNumberTextBox.Location = new System.Drawing.Point(319, 19);
            this.vehicleIdentificationNumberTextBox.Name = "vehicleIdentificationNumberTextBox";
            this.vehicleIdentificationNumberTextBox.ReadOnly = true;
            this.vehicleIdentificationNumberTextBox.Size = new System.Drawing.Size(187, 20);
            this.vehicleIdentificationNumberTextBox.TabIndex = 3;
            // 
            // vehicleRegistrationNumberTextBox
            // 
            this.vehicleRegistrationNumberTextBox.Location = new System.Drawing.Point(72, 19);
            this.vehicleRegistrationNumberTextBox.Name = "vehicleRegistrationNumberTextBox";
            this.vehicleRegistrationNumberTextBox.ReadOnly = true;
            this.vehicleRegistrationNumberTextBox.Size = new System.Drawing.Size(187, 20);
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
            // customerDataTextBox
            // 
            this.customerDataTextBox.Location = new System.Drawing.Point(6, 19);
            this.customerDataTextBox.Multiline = true;
            this.customerDataTextBox.Name = "customerDataTextBox";
            this.customerDataTextBox.ReadOnly = true;
            this.customerDataTextBox.Size = new System.Drawing.Size(755, 59);
            this.customerDataTextBox.TabIndex = 1;
            // 
            // selectCustomerButton
            // 
            this.selectCustomerButton.Location = new System.Drawing.Point(686, 84);
            this.selectCustomerButton.Name = "selectCustomerButton";
            this.selectCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.selectCustomerButton.TabIndex = 0;
            this.selectCustomerButton.Text = "Izberi";
            this.selectCustomerButton.UseVisualStyleBackColor = true;
            this.selectCustomerButton.Click += new System.EventHandler(this.SelectCustomerButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.workOrderDeadlineDateTimePicker);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.wordOrderNumberTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delovni nalog";
            // 
            // workOrderDeadlineDateTimePicker
            // 
            this.workOrderDeadlineDateTimePicker.CustomFormat = "dd.MM.yyyy  HH:mm";
            this.workOrderDeadlineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.workOrderDeadlineDateTimePicker.Location = new System.Drawing.Point(282, 19);
            this.workOrderDeadlineDateTimePicker.Name = "workOrderDeadlineDateTimePicker";
            this.workOrderDeadlineDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.workOrderDeadlineDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rok izdelave";
            // 
            // wordOrderNumberTextBox
            // 
            this.wordOrderNumberTextBox.Location = new System.Drawing.Point(51, 19);
            this.wordOrderNumberTextBox.Name = "wordOrderNumberTextBox";
            this.wordOrderNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.wordOrderNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Št. DN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.workOrderInstructionsDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 269);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navodila za delo";
            // 
            // workOrderInstructionsDataGridView
            // 
            this.workOrderInstructionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workOrderInstructionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workOrderInstructionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.position,
            this.quantity,
            this.description});
            this.workOrderInstructionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workOrderInstructionsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.workOrderInstructionsDataGridView.Name = "workOrderInstructionsDataGridView";
            this.workOrderInstructionsDataGridView.Size = new System.Drawing.Size(763, 250);
            this.workOrderInstructionsDataGridView.TabIndex = 0;
            // 
            // position
            // 
            this.position.DataPropertyName = "Position";
            this.position.FillWeight = 20F;
            this.position.HeaderText = "Pozicija";
            this.position.Name = "position";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.FillWeight = 10F;
            this.quantity.HeaderText = "Količina";
            this.quantity.Name = "quantity";
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.FillWeight = 70F;
            this.description.HeaderText = "Opis";
            this.description.Name = "description";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(317, 600);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(398, 600);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model. l";
            // 
            // vehicleModelYearNumericUpDown
            // 
            this.vehicleModelYearNumericUpDown.Location = new System.Drawing.Point(562, 73);
            this.vehicleModelYearNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.vehicleModelYearNumericUpDown.Name = "vehicleModelYearNumericUpDown";
            this.vehicleModelYearNumericUpDown.ReadOnly = true;
            this.vehicleModelYearNumericUpDown.Size = new System.Drawing.Size(187, 20);
            this.vehicleModelYearNumericUpDown.TabIndex = 13;
            // 
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 636);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delovni nalog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkOrderForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleMileageNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workOrderInstructionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleModelYearNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectCustomerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView workOrderInstructionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wordOrderNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker workOrderDeadlineDateTimePicker;
        private System.Windows.Forms.TextBox customerDataTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
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
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown vehicleMileageNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown vehicleModelYearNumericUpDown;
    }
}