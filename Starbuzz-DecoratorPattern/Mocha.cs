using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description
        {
            get { return _beverage.Description + ", Mocha"; }
        }

        public override double Cost
        {
            get { return .20 + _beverage.Cost; }
        }
    }
}
