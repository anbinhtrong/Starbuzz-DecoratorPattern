using Starbuzz_DecoratorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee_Size
{
    class Program
    {
        //http://blog.daum.net/chowood/8039123
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();

            Console.WriteLine(beverage.Description
                + " $" + beverage.Cost);

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description
                + " $" + beverage2.Cost);

            Beverage beverage3 = new HouseBlend();
            beverage3.Size = BeverageSize.TALL;
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description
                + " $" + beverage3.Cost);

            // Wait for user
            Console.ReadKey();
        }
    }
}
