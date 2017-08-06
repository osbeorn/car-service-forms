using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarServiceForms.Core.Helpers
{
    public enum SettingsFields
    {
        COMPANY_NAME,
        COMPANY_ADDRESS_1,
        COMPANY_ADDRESS_2,
        COMPANY_TAX_ID,
        COMPANY_BANK_ACCOUNT,
        REPAIRMAN,
        PAYMENT_DEADLINE // [days]
    }

    public class SettingsHelper
    {
        private static CarServiceFormsDBContext DBContext { get; set; }

        #region mapper
        private static readonly Dictionary<SettingsFields, string> settingsFieldsMapper = new Dictionary<SettingsFields, string>
        {
            {
                SettingsFields.COMPANY_NAME,
                "company_name"
            },
            {
                SettingsFields.COMPANY_ADDRESS_1,
                "company_address_1"
            },
            {
                SettingsFields.COMPANY_ADDRESS_2,
                "company_address_2"
            },
            {
                SettingsFields.COMPANY_TAX_ID,
                "company_tax_id"
            },
            {
                SettingsFields.COMPANY_BANK_ACCOUNT,
                "company_bank_account"
            },
            {
                SettingsFields.REPAIRMAN,
                "repairman"
            },
            {
                SettingsFields.PAYMENT_DEADLINE,
                "payment_deadline"
            }
        };
        #endregion mapper

        static SettingsHelper()
        {
            DBContext = new CarServiceFormsDBContext();
        }

        public static T GetConfigValue<T>(SettingsFields field) where T : IConvertible
        {
            switch (field)
            {
                case SettingsFields.COMPANY_NAME:
                case SettingsFields.COMPANY_ADDRESS_1:
                case SettingsFields.COMPANY_ADDRESS_2:
                case SettingsFields.COMPANY_TAX_ID:
                case SettingsFields.COMPANY_BANK_ACCOUNT:
                case SettingsFields.REPAIRMAN:
                    return (T)Convert.ChangeType(GetStringValue(settingsFieldsMapper[field]), typeof(T));
                case SettingsFields.PAYMENT_DEADLINE:
                    return (T)Convert.ChangeType(GetIntValue(settingsFieldsMapper[field]), typeof(T));
            }

            return default(T);
        }

        public static void SetConfigValue<T>(SettingsFields field, T value)
        {
            SetConfigValue(settingsFieldsMapper[field], value);
        }

        private static bool GetBoolValue(string property)
        {
            throw new NotImplementedException();
        }

        private static int GetIntValue(string property)
        {
            var setting = DBContext.Settings.Where(s => s.Key == property).FirstOrDefault();
            if (setting == null)
            {
                return default(int);
            }

            int.TryParse(setting.Value, out int retVal);

            return retVal;
        }

        private static float GetFloatValue(string property)
        {
            throw new NotImplementedException();
        }

        private static string GetStringValue(string property)
        {
            var setting = DBContext.Settings.Where(s => s.Key == property).FirstOrDefault();
            if (setting == null)
            {
                return default(string);
            }
            
            return setting.Value;
        }

        private static decimal GetDecimalValue(string property)
        {
            throw new NotImplementedException();
        }

        private static void SetConfigValue<T>(string property, T value)
        {
            var setting = DBContext.Settings.Where(s => s.Key == property).FirstOrDefault();
            if (setting == null)
            {
                setting = new Settings()
                {
                    Key = property,
                    Value = value.ToString()
                };
                DBContext.Settings.Add(setting);
            }
            else
            {
                setting.Value = value.ToString();
            }

            DBContext.SaveChanges();
        }
    }
}
