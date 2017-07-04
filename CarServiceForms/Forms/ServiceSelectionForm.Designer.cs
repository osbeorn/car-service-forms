namespace CarServiceForms.Forms
{
    partial class ServiceSelectionForm
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
            this.serviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceTypeMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(125, 96);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(206, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.DisplayMember = "Description";
            this.serviceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceTypeComboBox.FormattingEnabled = true;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(106, 55);
            this.serviceTypeComboBox.Name = "serviceTypeComboBox";
            this.serviceTypeComboBox.Size = new System.Drawing.Size(287, 21);
            this.serviceTypeComboBox.TabIndex = 3;
            this.serviceTypeComboBox.ValueMember = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izbrani tip servisa";
            // 
            // serviceTypeMessageLabel
            // 
            this.serviceTypeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceTypeMessageLabel.Location = new System.Drawing.Point(12, 9);
            this.serviceTypeMessageLabel.Name = "serviceTypeMessageLabel";
            this.serviceTypeMessageLabel.Size = new System.Drawing.Size(381, 43);
            this.serviceTypeMessageLabel.TabIndex = 5;
            this.serviceTypeMessageLabel.Text = "label1";
            // 
            // ServiceSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(405, 131);
            this.ControlBox = false;
            this.Controls.Add(this.serviceTypeMessageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serviceTypeComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label serviceTypeMessageLabel;
    }
}