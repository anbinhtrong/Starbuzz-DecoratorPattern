using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description
        {
            get { return _beverage.Description + ", Whip"; }
        }

        public override double Cost
        {
            get { return .10 + _beverage.Cost; }
        }
    }
}
