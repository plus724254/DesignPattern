using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = nameof(Espresso);
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
