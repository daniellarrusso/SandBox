using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    public class Laptop : IRecordable
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public Laptop(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
           
        }

        
        
        public void Record(string moo)
        {

            string padRight = Name.PadRight(9);
            Console.WriteLine($"{padRight}:{Grade}, {moo}");
        }
    }
}
