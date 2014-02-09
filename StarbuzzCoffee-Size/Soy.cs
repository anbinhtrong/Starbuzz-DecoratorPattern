using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description
        {
            get { return _beverage.Description + ", Soy"; }
        }

        public override double Cost
        {            
            get 
            {
                switch (_beverage.Size)
                {
                    case BeverageSize.TALL: return _beverage.Cost + .10;
                    case BeverageSize.GRANDLE: return _beverage.Cost + .15;
                    case BeverageSize.VENTI: return _beverage.Cost + .20;
                }
                return _beverage.Cost;
            }
        }
    }
}
