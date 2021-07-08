using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public abstract class Beverage
    {
        protected string _description;
        public string GetDescription()
        {
            return _description;
        }
        public abstract double Cost();
    }
}
