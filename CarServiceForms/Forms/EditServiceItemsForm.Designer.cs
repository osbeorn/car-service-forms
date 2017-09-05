namespace CarServiceForms.Forms
{
    partial class EditServiceItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServiceItemsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serviceItemGroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupActiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serviceItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemActiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serviceTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.serviceTypeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeActiveColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemGroupsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemsDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serviceItemGroupsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skupine postavk";
            // 
            // serviceItemGroupsDataGridView
            // 
            this.serviceItemGroupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceItemGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceItemGroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIdColumn,
            this.groupNameColumn,
            this.groupOrderColumn,
            this.groupActiveColumn});
            this.serviceItemGroupsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceItemGroupsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serviceItemGroupsDataGridView.Name = "serviceItemGroupsDataGridView";
            this.serviceItemGroupsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceItemGroupsDataGridView.Size = new System.Drawing.Size(915, 176);
            this.serviceItemGroupsDataGridView.TabIndex = 0;
            this.serviceItemGroupsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ServiceItemGroupsDataGridView_CellValidating);
            this.serviceItemGroupsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ServiceItemGroupsDataGridView_DefaultValuesNeeded);
            this.serviceItemGroupsDataGridView.SelectionChanged += new System.EventHandler(this.ServiceItemGroupsDataGridView_SelectionChanged);
            this.serviceItemGroupsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ServiceItemGroupsDataGridView_UserDeletingRow);
            // 
            // groupIdColumn
            // 
            this.groupIdColumn.DataPropertyName = "Id";
            this.groupIdColumn.HeaderText = "Id";
            this.groupIdColumn.Name = "groupIdColumn";
            this.groupIdColumn.Visible = false;
            // 
            // groupNameColumn
            // 
            this.groupNameColumn.DataPropertyName = "Name";
            this.groupNameColumn.FillWeight = 95F;
            this.groupNameColumn.HeaderText = "Naziv";
            this.groupNameColumn.Name = "groupNameColumn";
            // 
            // groupOrderColumn
            // 
            this.groupOrderColumn.DataPropertyName = "Order";
            this.groupOrderColumn.FillWeight = 10F;
            this.groupOrderColumn.HeaderText = "Vrstni red";
            this.groupOrderColumn.Name = "groupOrderColumn";
            this.groupOrderColumn.Visible = false;
            // 
            // groupActiveColumn
            // 
            this.groupActiveColumn.DataPropertyName = "Active";
            this.groupActiveColumn.FillWeight = 5F;
            this.groupActiveColumn.HeaderText = "Prikaži";
            this.groupActiveColumn.Name = "groupActiveColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceItemsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 275);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postavke";
            // 
            // serviceItemsDataGridView
            // 
            this.serviceItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdColumn,
            this.itemNameColumn,
            this.itemOrderColumn,
            this.itemActiveColumn});
            this.serviceItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceItemsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serviceItemsDataGridView.Name = "serviceItemsDataGridView";
            this.serviceItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceItemsDataGridView.Size = new System.Drawing.Size(915, 256);
            this.serviceItemsDataGridView.TabIndex = 0;
            this.serviceItemsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ServiceItemsDataGridView_CellValidating);
            this.serviceItemsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ServiceItemsDataGridView_DefaultValuesNeeded);
            this.serviceItemsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ServiceItemsDataGridView_UserDeletingRow);
            // 
            // itemIdColumn
            // 
            this.itemIdColumn.DataPropertyName = "Id";
            this.itemIdColumn.HeaderText = "Id";
            this.itemIdColumn.Name = "itemIdColumn";
            this.itemIdColumn.Visible = false;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.DataPropertyName = "Name";
            this.itemNameColumn.FillWeight = 95F;
            this.itemNameColumn.HeaderText = "Naziv";
            this.itemNameColumn.Name = "itemNameColumn";
            // 
            // itemOrderColumn
            // 
            this.itemOrderColumn.DataPropertyName = "Order";
            this.itemOrderColumn.FillWeight = 5F;
            this.itemOrderColumn.HeaderText = "Vrstni red";
            this.itemOrderColumn.Name = "itemOrderColumn";
            this.itemOrderColumn.Visible = false;
            // 
            // itemActiveColumn
            // 
            this.itemActiveColumn.DataPropertyName = "Active";
            this.itemActiveColumn.FillWeight = 5F;
            this.itemActiveColumn.HeaderText = "Prikaži";
            this.itemActiveColumn.Name = "itemActiveColumn";
            this.itemActiveColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemActiveColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(475, 637);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(394, 637);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serviceTypesDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(921, 140);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipi servisnih pregledov";
            // 
            // serviceTypesDataGridView
            // 
            this.serviceTypesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTypeIdColumn,
            this.serviceTypeNameColumn,
            this.serviceTypeActiveColumn});
            this.serviceTypesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceTypesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serviceTypesDataGridView.Name = "serviceTypesDataGridView";
            this.serviceTypesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceTypesDataGridView.Size = new System.Drawing.Size(915, 121);
            this.serviceTypesDataGridView.TabIndex = 0;
            this.serviceTypesDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ServiceTypesDataGridView_CellValidating);
            this.serviceTypesDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ServiceTypesDataGridView_DefaultValuesNeeded);
            this.serviceTypesDataGridView.SelectionChanged += new System.EventHandler(this.ServiceTypesDataGridView_SelectionChanged);
            // 
            // serviceTypeIdColumn
            // 
            this.serviceTypeIdColumn.HeaderText = "Id";
            this.serviceTypeIdColumn.Name = "serviceTypeIdColumn";
            this.serviceTypeIdColumn.Visible = false;
            // 
            // serviceTypeNameColumn
            // 
            this.serviceTypeNameColumn.DataPropertyName = "Name";
            this.serviceTypeNameColumn.FillWeight = 95F;
            this.serviceTypeNameColumn.HeaderText = "Naziv";
            this.serviceTypeNameColumn.Name = "serviceTypeNameColumn";
            // 
            // serviceTypeActiveColumn
            // 
            this.serviceTypeActiveColumn.DataPropertyName = "Active";
            this.serviceTypeActiveColumn.FillWeight = 5F;
            this.serviceTypeActiveColumn.HeaderText = "Prikaži";
            this.serviceTypeActiveColumn.Name = "serviceTypeActiveColumn";
            // 
            // EditServiceItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 672);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditServiceItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servisni pregledi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditServiceItemsForm_FormClosing);
            this.Load += new System.EventHandler(this.EditServiceItemsForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemGroupsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemsDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceTypesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView serviceItemGroupsDataGridView;
        private System.Windows.Forms.DataGridView serviceItemsDataGridView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView serviceTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupOrderColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn groupActiveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemOrderColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemActiveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn serviceTypeActiveColumn;
    }
}