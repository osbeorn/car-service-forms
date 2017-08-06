using CarServiceForms.Core.Helpers;
using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceForms.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            companyNameTextBox.Text = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_NAME);
            companyAddress1TextBox.Text = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_ADDRESS_1);
            companyAddress2TextBox.Text = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_ADDRESS_2);
            companyTaxIdTextBox.Text = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_TAX_ID);
            companyBankAccountTextBox.Text = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_BANK_ACCOUNT);

            repairmanTextBox.Text = SettingsHelper.GetConfigValue<string>(SettingsFields.REPAIRMAN);
            paymentDeadlineNumericUpDown.Value = SettingsHelper.GetConfigValue<int>(SettingsFields.PAYMENT_DEADLINE);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SettingsHelper.SetConfigValue(SettingsFields.COMPANY_NAME, companyNameTextBox.Text);
            SettingsHelper.SetConfigValue(SettingsFields.COMPANY_ADDRESS_1, companyAddress1TextBox.Text);
            SettingsHelper.SetConfigValue(SettingsFields.COMPANY_ADDRESS_2, companyAddress2TextBox.Text);
            SettingsHelper.SetConfigValue(SettingsFields.COMPANY_TAX_ID, companyTaxIdTextBox.Text);
            SettingsHelper.SetConfigValue(SettingsFields.COMPANY_BANK_ACCOUNT, companyBankAccountTextBox.Text);

            SettingsHelper.SetConfigValue(SettingsFields.REPAIRMAN, repairmanTextBox.Text);
            SettingsHelper.SetConfigValue(SettingsFields.PAYMENT_DEADLINE, (int) paymentDeadlineNumericUpDown.Value);
        }
    }
}
