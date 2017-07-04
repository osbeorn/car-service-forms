namespace CarServiceForms.Forms
{
    partial class SearchCustomerWithVehicleForm
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
            this.customerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.vehicleIdentificationNumberTextBox = new System.Windows.Forms.TextBox();
            this.vehicleRegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIdentificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMKBCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleGKBCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerFirstNameTextBox
            // 
            this.customerFirstNameTextBox.Location = new System.Drawing.Point(96, 12);
            this.customerFirstNameTextBox.Name = "customerFirstNameTextBox";
            this.customerFirstNameTextBox.Size = new System.Drawing.Size(530, 20);
            this.customerFirstNameTextBox.TabIndex = 1;
            this.customerFirstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerFirstNameTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // customerLastNameTextBox
            // 
            this.customerLastNameTextBox.Location = new System.Drawing.Point(96, 38);
            this.customerLastNameTextBox.Name = "customerLastNameTextBox";
            this.customerLastNameTextBox.Size = new System.Drawing.Size(530, 20);
            this.customerLastNameTextBox.TabIndex = 3;
            this.customerLastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerLastNameTextBox_KeyPress);
            // 
            // vehicleIdentificationNumberTextBox
            // 
            this.vehicleIdentificationNumberTextBox.Location = new System.Drawing.Point(96, 64);
            this.vehicleIdentificationNumberTextBox.Name = "vehicleIdentificationNumberTextBox";
            this.vehicleIdentificationNumberTextBox.Size = new System.Drawing.Size(530, 20);
            this.vehicleIdentificationNumberTextBox.TabIndex = 5;
            this.vehicleIdentificationNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VehicleIdentificationNumberTextBox_KeyPress);
            // 
            // vehicleRegistrationNumberTextBox
            // 
            this.vehicleRegistrationNumberTextBox.Location = new System.Drawing.Point(96, 90);
            this.vehicleRegistrationNumberTextBox.Name = "vehicleRegistrationNumberTextBox";
            this.vehicleRegistrationNumberTextBox.Size = new System.Drawing.Size(530, 20);
            this.vehicleRegistrationNumberTextBox.TabIndex = 7;
            this.vehicleRegistrationNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vehicleRegistrationNumberTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priimek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ident. št. vozila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registrska št.";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(470, 116);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Išči";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customersDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 267);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultati iskanja";
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerFirstName,
            this.customerLastName,
            this.customerStreet,
            this.customerPost,
            this.vehicleIdentificationNumber,
            this.vehicleRegistrationNumber,
            this.vehicleRegistrationDate,
            this.vehicleType,
            this.vehicleTypeCode,
            this.vehicleMKBCode,
            this.vehicleGKBCode});
            this.customersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDataGridView.Size = new System.Drawing.Size(608, 248);
            this.customersDataGridView.TabIndex = 0;
            // 
            // customerFirstName
            // 
            this.customerFirstName.DataPropertyName = "FirstName";
            this.customerFirstName.HeaderText = "Ime";
            this.customerFirstName.Name = "customerFirstName";
            this.customerFirstName.ReadOnly = true;
            this.customerFirstName.Width = 71;
            // 
            // customerLastName
            // 
            this.customerLastName.DataPropertyName = "LastName";
            this.customerLastName.HeaderText = "Priimek";
            this.customerLastName.Name = "customerLastName";
            this.customerLastName.ReadOnly = true;
            // 
            // customerStreet
            // 
            this.customerStreet.DataPropertyName = "Street";
            this.customerStreet.HeaderText = "Ulica";
            this.customerStreet.Name = "customerStreet";
            this.customerStreet.ReadOnly = true;
            // 
            // customerPost
            // 
            this.customerPost.DataPropertyName = "Post";
            this.customerPost.HeaderText = "Pošta";
            this.customerPost.Name = "customerPost";
            this.customerPost.ReadOnly = true;
            // 
            // vehicleIdentificationNumber
            // 
            this.vehicleIdentificationNumber.DataPropertyName = "IdentificationNumber";
            this.vehicleIdentificationNumber.HeaderText = "Ident. št.";
            this.vehicleIdentificationNumber.Name = "vehicleIdentificationNumber";
            this.vehicleIdentificationNumber.ReadOnly = true;
            // 
            // vehicleRegistrationNumber
            // 
            this.vehicleRegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.vehicleRegistrationNumber.HeaderText = "Reg. št.";
            this.vehicleRegistrationNumber.Name = "vehicleRegistrationNumber";
            this.vehicleRegistrationNumber.ReadOnly = true;
            // 
            // vehicleRegistrationDate
            // 
            this.vehicleRegistrationDate.DataPropertyName = "RegistrationDate";
            this.vehicleRegistrationDate.HeaderText = "Dat. 1. reg.";
            this.vehicleRegistrationDate.Name = "vehicleRegistrationDate";
            this.vehicleRegistrationDate.ReadOnly = true;
            // 
            // vehicleType
            // 
            this.vehicleType.DataPropertyName = "Type";
            this.vehicleType.HeaderText = "Tip";
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.ReadOnly = true;
            // 
            // vehicleTypeCode
            // 
            this.vehicleTypeCode.DataPropertyName = "TypeCode";
            this.vehicleTypeCode.HeaderText = "Koda tipa";
            this.vehicleTypeCode.Name = "vehicleTypeCode";
            this.vehicleTypeCode.ReadOnly = true;
            // 
            // vehicleMKBCode
            // 
            this.vehicleMKBCode.DataPropertyName = "MKBCode";
            this.vehicleMKBCode.HeaderText = "MKB";
            this.vehicleMKBCode.Name = "vehicleMKBCode";
            this.vehicleMKBCode.ReadOnly = true;
            // 
            // vehicleGKBCode
            // 
            this.vehicleGKBCode.DataPropertyName = "GKBCode";
            this.vehicleGKBCode.HeaderText = "GKB";
            this.vehicleGKBCode.Name = "vehicleGKBCode";
            this.vehicleGKBCode.ReadOnly = true;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(551, 116);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 9;
            this.newButton.Text = "Nova";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(323, 418);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(242, 418);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SearchCustomerWithVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(638, 453);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleRegistrationNumberTextBox);
            this.Controls.Add(this.vehicleIdentificationNumberTextBox);
            this.Controls.Add(this.customerLastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerFirstNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCustomerWithVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Išči stranko";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchCustomerWithVehicleForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerFirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerLastNameTextBox;
        private System.Windows.Forms.TextBox vehicleIdentificationNumberTextBox;
        private System.Windows.Forms.TextBox vehicleRegistrationNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdentificationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMKBCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleGKBCode;
    }
}