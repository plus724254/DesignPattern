using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }
}
