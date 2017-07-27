namespace CarServiceForms.Forms
{
    partial class ExtendedServiceSelectionForm
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
            this.transferRightButton = new System.Windows.Forms.Button();
            this.transferLeftButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rightListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leftListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferRightButton
            // 
            this.transferRightButton.Location = new System.Drawing.Point(296, 335);
            this.transferRightButton.Name = "transferRightButton";
            this.transferRightButton.Size = new System.Drawing.Size(45, 23);
            this.transferRightButton.TabIndex = 8;
            this.transferRightButton.Text = ">>";
            this.transferRightButton.UseVisualStyleBackColor = true;
            this.transferRightButton.Click += new System.EventHandler(this.TransferRightButton_Click);
            // 
            // transferLeftButton
            // 
            this.transferLeftButton.Location = new System.Drawing.Point(296, 306);
            this.transferLeftButton.Name = "transferLeftButton";
            this.transferLeftButton.Size = new System.Drawing.Size(45, 23);
            this.transferLeftButton.TabIndex = 7;
            this.transferLeftButton.Text = "<<";
            this.transferLeftButton.UseVisualStyleBackColor = true;
            this.transferLeftButton.Click += new System.EventHandler(this.TransferLeftButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Izbrani tip servisa";
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.DisplayMember = "Description";
            this.serviceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceTypeComboBox.FormattingEnabled = true;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(103, 12);
            this.serviceTypeComboBox.Name = "serviceTypeComboBox";
            this.serviceTypeComboBox.Size = new System.Drawing.Size(250, 21);
            this.serviceTypeComboBox.TabIndex = 1;
            this.serviceTypeComboBox.ValueMember = "Value";
            this.serviceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 2);
            this.label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preostalo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Izbrano";
            // 
            // rightListView
            // 
            this.rightListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.rightListView.Location = new System.Drawing.Point(347, 77);
            this.rightListView.Name = "rightListView";
            this.rightListView.ShowItemToolTips = true;
            this.rightListView.Size = new System.Drawing.Size(278, 511);
            this.rightListView.TabIndex = 6;
            this.rightListView.UseCompatibleStateImageBehavior = false;
            this.rightListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Postavke";
            this.columnHeader2.Width = 257;
            // 
            // leftListView
            // 
            this.leftListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.leftListView.Location = new System.Drawing.Point(12, 77);
            this.leftListView.Name = "leftListView";
            this.leftListView.ShowItemToolTips = true;
            this.leftListView.Size = new System.Drawing.Size(278, 511);
            this.leftListView.TabIndex = 4;
            this.leftListView.UseCompatibleStateImageBehavior = false;
            this.leftListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Postavke";
            this.columnHeader1.Width = 257;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(321, 594);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(240, 594);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(550, 594);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 11;
            this.printButton.Text = "Natisni";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExtendedServiceSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 629);
            this.ControlBox = false;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.leftListView);
            this.Controls.Add(this.rightListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serviceTypeComboBox);
            this.Controls.Add(this.transferLeftButton);
            this.Controls.Add(this.transferRightButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtendedServiceSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtendedServiceSelectionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button transferRightButton;
        private System.Windows.Forms.Button transferLeftButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView rightListView;
        private System.Windows.Forms.ListView leftListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button printButton;
    }
}