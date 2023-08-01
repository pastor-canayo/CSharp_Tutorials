using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Lamborghini : baseCarAbastract
    {
        public override void Color()
        {
            Console.WriteLine("Green is a great color on this car");
        }

        public override void Model()
        {
            Console.WriteLine("Lamborghini Murcielago  is the most powerful one");
        }

        public override void Price()
        {
            Console.WriteLine("This car has a tag of 600000 dollars");
        }
    }
}
