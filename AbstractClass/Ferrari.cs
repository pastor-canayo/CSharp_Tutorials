using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Ferrari : baseCarAbastract
    {
        public override void Color()
        {
            Console.WriteLine("Red is a great color on this car");
        }

        public override void Model()
        {
            Console.WriteLine("Ferrari LP300X is the most powerful one");
        }

        public override void Price()
        {
            Console.WriteLine("This car has a tag of 450000 dollars");
        }
    }
}
