namespace CarServiceForms.Forms
{
    partial class InvoiceForm
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
            this.invoiceItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalSalePriceLabel = new System.Windows.Forms.Label();
            this.totalDiscountLabel = new System.Windows.Forms.Label();
            this.totalFinalPriceLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceItemsDataGridView
            // 
            this.invoiceItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Quantity,
            this.Price,
            this.Discount});
            this.invoiceItemsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.invoiceItemsDataGridView.Name = "invoiceItemsDataGridView";
            this.invoiceItemsDataGridView.Size = new System.Drawing.Size(699, 252);
            this.invoiceItemsDataGridView.TabIndex = 0;
            this.invoiceItemsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceItemsDataGridView_CellValueChanged);
            this.invoiceItemsDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.InvoiceItemsDataGridView_EditingControlShowing);
            this.invoiceItemsDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.InvoiceItemsDataGridView_UserDeletedRow);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(364, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Prekliči";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(283, 352);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Potrdi";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(520, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SKUPNI ZNESEK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rabat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Skupna prodajna cena:";
            // 
            // totalSalePriceLabel
            // 
            this.totalSalePriceLabel.Location = new System.Drawing.Point(636, 276);
            this.totalSalePriceLabel.Name = "totalSalePriceLabel";
            this.totalSalePriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalSalePriceLabel.Size = new System.Drawing.Size(75, 13);
            this.totalSalePriceLabel.TabIndex = 11;
            this.totalSalePriceLabel.Text = "0 €";
            this.totalSalePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalDiscountLabel
            // 
            this.totalDiscountLabel.Location = new System.Drawing.Point(639, 299);
            this.totalDiscountLabel.Name = "totalDiscountLabel";
            this.totalDiscountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalDiscountLabel.Size = new System.Drawing.Size(72, 13);
            this.totalDiscountLabel.TabIndex = 12;
            this.totalDiscountLabel.Text = "0 €";
            this.totalDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalFinalPriceLabel
            // 
            this.totalFinalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalFinalPriceLabel.Location = new System.Drawing.Point(639, 322);
            this.totalFinalPriceLabel.Name = "totalFinalPriceLabel";
            this.totalFinalPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalFinalPriceLabel.Size = new System.Drawing.Size(72, 13);
            this.totalFinalPriceLabel.TabIndex = 13;
            this.totalFinalPriceLabel.Text = "0 €";
            this.totalFinalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(636, 352);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 14;
            this.printButton.Text = "Natisni";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 55F;
            this.Description.HeaderText = "Opis";
            this.Description.Name = "Description";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 15F;
            this.Quantity.HeaderText = "Količina";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 15F;
            this.Price.HeaderText = "Cena [EUR]";
            this.Price.Name = "Price";
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.FillWeight = 15F;
            this.Discount.HeaderText = "Popust [%]";
            this.Discount.Name = "Discount";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 387);
            this.ControlBox = false;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.totalFinalPriceLabel);
            this.Controls.Add(this.totalDiscountLabel);
            this.Controls.Add(this.totalSalePriceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.invoiceItemsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Račun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoiceForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoiceItemsDataGridView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalSalePriceLabel;
        private System.Windows.Forms.Label totalDiscountLabel;
        private System.Windows.Forms.Label totalFinalPriceLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}