using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    interface ICustomer
    {
        string CustomerName { get; set; }
        string Left(string s, int val);
    }
}
