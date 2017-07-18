namespace CarServiceForms.Forms
{
    partial class EditServiceForm
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
            this.serviceItemGroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serviceItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemGroupsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serviceItemGroupsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skupine";
            // 
            // serviceItemGroupsDataGridView
            // 
            this.serviceItemGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceItemGroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNameColumn,
            this.groupOrderColumn});
            this.serviceItemGroupsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceItemGroupsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serviceItemGroupsDataGridView.Name = "serviceItemGroupsDataGridView";
            this.serviceItemGroupsDataGridView.Size = new System.Drawing.Size(720, 181);
            this.serviceItemGroupsDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceItemsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postavke";
            // 
            // serviceItemsDataGridView
            // 
            this.serviceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameColumn,
            this.itemOrderColumn});
            this.serviceItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceItemsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serviceItemsDataGridView.Name = "serviceItemsDataGridView";
            this.serviceItemsDataGridView.Size = new System.Drawing.Size(720, 299);
            this.serviceItemsDataGridView.TabIndex = 0;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.DataPropertyName = "Name";
            this.itemNameColumn.HeaderText = "Naziv";
            this.itemNameColumn.Name = "itemNameColumn";
            // 
            // itemOrderColumn
            // 
            this.itemOrderColumn.DataPropertyName = "Order";
            this.itemOrderColumn.HeaderText = "Vrstni red";
            this.itemOrderColumn.Name = "itemOrderColumn";
            // 
            // groupNameColumn
            // 
            this.groupNameColumn.DataPropertyName = "Name";
            this.groupNameColumn.HeaderText = "Naziv";
            this.groupNameColumn.Name = "groupNameColumn";
            // 
            // groupOrderColumn
            // 
            this.groupOrderColumn.DataPropertyName = "Order";
            this.groupOrderColumn.HeaderText = "Vrstni red";
            this.groupOrderColumn.Name = "groupOrderColumn";
            // 
            // EditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditServiceForm";
            this.Text = "EditServiceForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemGroupsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView serviceItemGroupsDataGridView;
        private System.Windows.Forms.DataGridView serviceItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupOrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemOrderColumn;
    }
}