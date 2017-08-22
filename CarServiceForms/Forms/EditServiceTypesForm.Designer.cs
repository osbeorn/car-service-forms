namespace CarServiceForms.Forms
{
    partial class EditServiceTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServiceTypesForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serviceItemServiceTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemServiceTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serviceItemServiceTypesDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 622);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tip servisa in postavke";
            // 
            // serviceItemsDataGridView
            // 
            this.serviceItemServiceTypesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceItemServiceTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceItemServiceTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameColumn,
            this.serviceTypeColumn});
            this.serviceItemServiceTypesDataGridView.Location = new System.Drawing.Point(3, 19);
            this.serviceItemServiceTypesDataGridView.Name = "serviceItemsDataGridView";
            this.serviceItemServiceTypesDataGridView.Size = new System.Drawing.Size(912, 597);
            this.serviceItemServiceTypesDataGridView.TabIndex = 0;
            this.serviceItemServiceTypesDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ServiceItemsDataGridView_UserDeletingRow);
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
            // itemNameColumn
            // 
            this.itemNameColumn.DataPropertyName = "ServiceItemName";
            this.itemNameColumn.FillWeight = 71F;
            this.itemNameColumn.HeaderText = "Naziv";
            this.itemNameColumn.Name = "itemNameColumn";
            // 
            // serviceTypeColumn
            // 
            this.serviceTypeColumn.FillWeight = 20F;
            this.serviceTypeColumn.HeaderText = "Tip servisa";
            this.serviceTypeColumn.Name = "serviceTypeColumn";
            // 
            // EditServiceTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 675);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditServiceTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tip servisa in postavke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditServiceTypesForm_FormClosing);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemServiceTypesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView serviceItemServiceTypesDataGridView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceTypeColumn;
    }
}