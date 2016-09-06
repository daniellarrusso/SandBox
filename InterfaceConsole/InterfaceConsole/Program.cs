using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    class Program : IRecordable
    {
        static void Record(IRecordable recorder)
        {
            string s = recorder.GetType().GUID.ToString();
            recorder.Record(s);
        }

        public string Name { get; set; }
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            string x = customer.CustomerName = "Nigella";
            customer.Name = "Sophie";
            customer.CompanyName = "Auto's LTD";
            x = "Nigel 2";
            Console.WriteLine("String from{2}customer is {0}\r\nor Variable x = {1}\r\n{3}", 
                   customer.CustomerName?.ToLower(), 
                   x?.ToLower(), 
                   Environment.NewLine,
                   customer.CustomerCompanyName);

            string leftString;
            leftString = customer.Left(customer.CustomerName,3);
            Console.WriteLine($"{leftString}");

            Console.WriteLine("Interface");
            Laptop laptop = new Laptop("Nathan", 56);
            Program p = new Program();
            Record(laptop);
            Record(customer);

            // Collection of Classes that interface with Irecordable 
            IRecordable[] Recordables = { laptop, customer };

            foreach (var recordable in Recordables)
            {
                recordable.Record(recordable.Name);
                Console.WriteLine("Moo" + recordable.Name);
            }

            // Can implicit cast but not sure of point... Can create an object out of Irecordable and use any methods 
            // belonging to thta interface for classes that use it
            IRecordable recordObject = new Program();

            recordObject.Record("TEST");
            Console.ReadLine();
            
        }

        public void Record(string value)
        {
            Console.WriteLine("Test: " + value);
        }
    }
}
