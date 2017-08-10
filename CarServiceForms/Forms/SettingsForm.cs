using CarServiceForms.Core.Helpers;
using System;
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
            companyDirectorTextBox.Text = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_DIRECTOR);

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
            SettingsHelper.SetConfigValue(SettingsFields.COMPANY_DIRECTOR, companyDirectorTextBox.Text);

            SettingsHelper.SetConfigValue(SettingsFields.REPAIRMAN, repairmanTextBox.Text);
            SettingsHelper.SetConfigValue(SettingsFields.PAYMENT_DEADLINE, (int) paymentDeadlineNumericUpDown.Value);
        }

        private void PaymentDeadlineNumericUpDown_Enter(object sender, EventArgs e)
        {
            paymentDeadlineNumericUpDown.Select(0, paymentDeadlineNumericUpDown.Text.Length);
        }
    }
}
