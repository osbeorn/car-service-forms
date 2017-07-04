using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Model
{
    public partial class Vehicle
    {
        public string ShortDescription
        {
            get
            {
                const string FORMAT = "{0}, ({1})";
                return string.Format(FORMAT, Type, RegistrationNumber);
            }
        }
    }
}
