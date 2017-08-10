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
            this.revertServiceItemGroupChangesButton = new System.Windows.Forms.Button();
            this.saveServiceItemGroupChangesButton = new System.Windows.Forms.Button();
            this.serviceItemGroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.revertServiceItemChangesButton = new System.Windows.Forms.Button();
            this.saveServiceItemChangesButton = new System.Windows.Forms.Button();
            this.serviceItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGroupColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemGroupsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.revertServiceItemGroupChangesButton);
            this.groupBox1.Controls.Add(this.saveServiceItemGroupChangesButton);
            this.groupBox1.Controls.Add(this.serviceItemGroupsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skupine";
            // 
            // revertServiceItemGroupChangesButton
            // 
            this.revertServiceItemGroupChangesButton.Location = new System.Drawing.Point(840, 223);
            this.revertServiceItemGroupChangesButton.Name = "revertServiceItemGroupChangesButton";
            this.revertServiceItemGroupChangesButton.Size = new System.Drawing.Size(75, 23);
            this.revertServiceItemGroupChangesButton.TabIndex = 18;
            this.revertServiceItemGroupChangesButton.Text = "Razveljavi";
            this.revertServiceItemGroupChangesButton.UseVisualStyleBackColor = true;
            this.revertServiceItemGroupChangesButton.Click += new System.EventHandler(this.RevertServiceItemGroupChangesButton_Click);
            // 
            // saveServiceItemGroupChangesButton
            // 
            this.saveServiceItemGroupChangesButton.Location = new System.Drawing.Point(759, 223);
            this.saveServiceItemGroupChangesButton.Name = "saveServiceItemGroupChangesButton";
            this.saveServiceItemGroupChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveServiceItemGroupChangesButton.TabIndex = 17;
            this.saveServiceItemGroupChangesButton.Text = "Shrani";
            this.saveServiceItemGroupChangesButton.UseVisualStyleBackColor = true;
            this.saveServiceItemGroupChangesButton.Click += new System.EventHandler(this.SaveServiceItemGroupChangesButton_Click);
            // 
            // serviceItemGroupsDataGridView
            // 
            this.serviceItemGroupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceItemGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceItemGroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNameColumn,
            this.groupOrderColumn});
            this.serviceItemGroupsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serviceItemGroupsDataGridView.Name = "serviceItemGroupsDataGridView";
            this.serviceItemGroupsDataGridView.Size = new System.Drawing.Size(915, 201);
            this.serviceItemGroupsDataGridView.TabIndex = 0;
            this.serviceItemGroupsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ServiceItemGroupsDataGridView_DefaultValuesNeeded);
            this.serviceItemGroupsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ServiceItemGroupsDataGridView_UserDeletingRow);
            // 
            // groupNameColumn
            // 
            this.groupNameColumn.DataPropertyName = "Name";
            this.groupNameColumn.FillWeight = 91F;
            this.groupNameColumn.HeaderText = "Naziv";
            this.groupNameColumn.Name = "groupNameColumn";
            // 
            // groupOrderColumn
            // 
            this.groupOrderColumn.DataPropertyName = "Order";
            this.groupOrderColumn.FillWeight = 9F;
            this.groupOrderColumn.HeaderText = "Vrstni red";
            this.groupOrderColumn.Name = "groupOrderColumn";
            this.groupOrderColumn.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.revertServiceItemChangesButton);
            this.groupBox2.Controls.Add(this.saveServiceItemChangesButton);
            this.groupBox2.Controls.Add(this.serviceItemsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postavke";
            // 
            // revertServiceItemChangesButton
            // 
            this.revertServiceItemChangesButton.Location = new System.Drawing.Point(840, 335);
            this.revertServiceItemChangesButton.Name = "revertServiceItemChangesButton";
            this.revertServiceItemChangesButton.Size = new System.Drawing.Size(75, 23);
            this.revertServiceItemChangesButton.TabIndex = 20;
            this.revertServiceItemChangesButton.Text = "Razveljavi";
            this.revertServiceItemChangesButton.UseVisualStyleBackColor = true;
            this.revertServiceItemChangesButton.Click += new System.EventHandler(this.RevertServiceItemChangesButton_Click);
            // 
            // saveServiceItemChangesButton
            // 
            this.saveServiceItemChangesButton.Location = new System.Drawing.Point(759, 335);
            this.saveServiceItemChangesButton.Name = "saveServiceItemChangesButton";
            this.saveServiceItemChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveServiceItemChangesButton.TabIndex = 19;
            this.saveServiceItemChangesButton.Text = "Shrani";
            this.saveServiceItemChangesButton.UseVisualStyleBackColor = true;
            this.saveServiceItemChangesButton.Click += new System.EventHandler(this.SaveServiceItemChangesButton_Click);
            // 
            // serviceItemsDataGridView
            // 
            this.serviceItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameColumn,
            this.itemOrderColumn,
            this.itemGroupColumn});
            this.serviceItemsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.serviceItemsDataGridView.Name = "serviceItemsDataGridView";
            this.serviceItemsDataGridView.Size = new System.Drawing.Size(912, 313);
            this.serviceItemsDataGridView.TabIndex = 0;
            this.serviceItemsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.ServiceItemsDataGridView_DefaultValuesNeeded);
            this.serviceItemsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ServiceItemsDataGridView_UserDeletingRow);
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.DataPropertyName = "Name";
            this.itemNameColumn.FillWeight = 71F;
            this.itemNameColumn.HeaderText = "Naziv";
            this.itemNameColumn.Name = "itemNameColumn";
            // 
            // itemOrderColumn
            // 
            this.itemOrderColumn.DataPropertyName = "Order";
            this.itemOrderColumn.FillWeight = 9F;
            this.itemOrderColumn.HeaderText = "Vrstni red";
            this.itemOrderColumn.Name = "itemOrderColumn";
            this.itemOrderColumn.Visible = false;
            // 
            // itemGroupColumn
            // 
            this.itemGroupColumn.FillWeight = 20F;
            this.itemGroupColumn.HeaderText = "Skupina";
            this.itemGroupColumn.Name = "itemGroupColumn";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(475, 640);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(394, 640);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // EditServiceItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 675);
            this.ControlBox = false;
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
            this.Text = "Postavke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditServiceItemsForm_FormClosing);
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button revertServiceItemGroupChangesButton;
        private System.Windows.Forms.Button saveServiceItemGroupChangesButton;
        private System.Windows.Forms.Button revertServiceItemChangesButton;
        private System.Windows.Forms.Button saveServiceItemChangesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupOrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemOrderColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemGroupColumn;
    }
}