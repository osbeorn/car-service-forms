using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Model
{
    public partial class Customer
    {
        public string ShortDescription
        {
            get
            {
                const string FORMAT = "{0} {1}, {2}, {3}";
                return string.Format(FORMAT, FirstName, LastName, Street, Post);
            }
        }

        public string LongDescription
        {
            get
            {
                const string FORMAT = "{0} {1}\n{2}\n{3}\n{4}";
                return string.Format(FORMAT, FirstName, LastName, Street, Post, Phone);
            }
        }
    }
}
