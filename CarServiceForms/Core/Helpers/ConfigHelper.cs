using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;

namespace CarServiceForms.Core.Helpers
{
    public enum ConfigFields
    {
        COMPANY_NAME,
        COMPANY_ADDRESS_1,
        COMPANY_ADDRESS_2,
        COMPANY_BANK_ACCOUNT,
        REPAIRMAN,
    }

    public class ConfigHelper
    {
        private static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private CarServiceFormsDBContext DBContext { get; set; }

        #region mapper
        private static readonly Dictionary<ConfigFields, string> configFieldsMapper = new Dictionary<ConfigFields, string>
        {
            {
                ConfigFields.COMPANY_NAME,
                "company_name"
            },
            {
                ConfigFields.COMPANY_ADDRESS_1,
                "company_address_1"
            },
            {
                ConfigFields.COMPANY_ADDRESS_2,
                "company_address_2"
            },
            {
                ConfigFields.COMPANY_BANK_ACCOUNT,
                "company_bank_account"
            },
            {
                ConfigFields.REPAIRMAN,
                "repairman"
            }
        };
        #endregion mapper

        public static T GetConfigValue<T>(ConfigFields field) where T : IConvertible
        {
            switch (field)
            {
                case ConfigFields.REPAIRMAN:
                    return (T)Convert.ChangeType(GetStringValue(configFieldsMapper[field]), typeof(T));

                //case ConfigFields.ZNESEK:
                //    return (T)Convert.ChangeType(GetDecimalValue(configFieldsMapper[field]), typeof(T));

                //case ConfigFields.DOLZNI_CLANI:
                //case ConfigFields.DOLZNI_CLANICE:
                //    return (T)Convert.ChangeType(GetBoolValue(configFieldsMapper[field]), typeof(T));

                //case ConfigFields.OBDOBJE_CLANI_OD:
                //case ConfigFields.OBDOBJE_CLANI_DO:
                //case ConfigFields.OBDOBJE_CLANICE_OD:
                //case ConfigFields.OBDOBJE_CLANICE_DO:
                //case ConfigFields.OPOMINI_OD:
                //case ConfigFields.OPOMINI_DO:
                //    return (T)Convert.ChangeType(GetIntValue(configFieldsMapper[field]), typeof(T));

                //case ConfigFields.ZNESEK_CLANI:
                //case ConfigFields.ZNESEK_CLANICE:
                //    return (T)Convert.ChangeType(GetDecimalValue(configFieldsMapper[field]), typeof(T));

                //case ConfigFields.LASER_XOFFSET:
                //case ConfigFields.LASER_YOFFSET:
                //case ConfigFields.ENDLESS_XOFFSET:
                //case ConfigFields.ENDLESS_YOFFSET:
                //    return (T)Convert.ChangeType(GetFloatValue(configFieldsMapper[field]), typeof(T));

                //case ConfigFields.DEBTS_TEMPLATE:
                //    return (T)Convert.ChangeType(GetStringValueFromFile(configFieldsMapper[field]), typeof(T));
            }

            return default(T);
        }

        private static bool GetBoolValue(string property)
        {
            bool retVal = bool.Parse(ConfigurationManager.AppSettings[property]);
            return retVal;
        }

        private static int GetIntValue(string property)
        {
            int retVal;
            int.TryParse(ConfigurationManager.AppSettings[property], out retVal);
            return retVal;
        }

        private static float GetFloatValue(string property)
        {
            float retVal = float.Parse(ConfigurationManager.AppSettings[property].Replace(',', '.'), CultureInfo.InvariantCulture);
            return retVal;
        }

        private static string GetStringValue(string property)
        {
            return ConfigurationManager.AppSettings[property];
        }

        private static decimal GetDecimalValue(string property)
        {
            decimal retVal;
            decimal.TryParse(ConfigurationManager.AppSettings[property], out retVal);
            return retVal;
        }

        private static string GetStringValueFromFile(string property)
        {
            string path = ConfigurationManager.AppSettings[property];
            return File.ReadAllText(Path.GetFullPath(path));
        }
    }
}
