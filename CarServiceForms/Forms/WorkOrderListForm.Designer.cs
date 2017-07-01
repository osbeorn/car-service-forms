namespace CarServiceForms.Forms
{
    partial class WorkOrderListForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.workOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.printButton = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(987, 12);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Nov";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // workOrdersDataGridView
            // 
            this.workOrdersDataGridView.AllowUserToAddRows = false;
            this.workOrdersDataGridView.AllowUserToDeleteRows = false;
            this.workOrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workOrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Created,
            this.Deadline,
            this.Customer,
            this.Vehicle,
            this.Service});
            this.workOrdersDataGridView.Location = new System.Drawing.Point(12, 41);
            this.workOrdersDataGridView.Name = "workOrdersDataGridView";
            this.workOrdersDataGridView.ReadOnly = true;
            this.workOrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workOrdersDataGridView.Size = new System.Drawing.Size(1050, 528);
            this.workOrdersDataGridView.TabIndex = 1;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(906, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Tiskaj";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Št. DN";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Created
            // 
            this.Created.DataPropertyName = "Created";
            this.Created.HeaderText = "Ustvarjen";
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "Rok izdelave";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Stranka";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Vehicle
            // 
            this.Vehicle.DataPropertyName = "Vehicle";
            this.Vehicle.HeaderText = "Vozilo";
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.ReadOnly = true;
            // 
            // Service
            // 
            this.Service.HeaderText = "Servis";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // WorkOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 581);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.workOrdersDataGridView);
            this.Controls.Add(this.createButton);
            this.Name = "WorkOrderListForm";
            this.Text = "Delovni nalogi";
            ((System.ComponentModel.ISupportInitialize)(this.workOrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridView workOrdersDataGridView;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewButtonColumn Service;
    }
}