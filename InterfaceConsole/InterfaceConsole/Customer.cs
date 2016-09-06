using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    public class Customer : ICustomer, IRecordable
    {
        private string _customerName;

        public string Name { get; set; }

        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
            }
        }

        public string CompanyName { get; set; }

        public string CustomerCompanyName => CustomerName + " " + CompanyName;

        public void Record(string moo)
        {
            string padRight = CustomerName.PadRight(9);
            Console.WriteLine($"{padRight}:{CompanyName}, {moo}");
        }

        public string Left(string sName, int value)
        {
            return string.Format(sName.Substring(0, value));
        }

    }
}
