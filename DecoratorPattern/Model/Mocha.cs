using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class Mocha : CondimentDecorator
    {
        protected Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
