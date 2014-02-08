using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
            Cost = 1.99;
        }
    }
}
