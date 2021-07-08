using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = nameof(HouseBlend);
        }
        public override double Cost()
        {
            return .89;
        }
    }
}
