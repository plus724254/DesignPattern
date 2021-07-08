using DecoratorPattern.Model;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);

            Console.WriteLine(beverage.Cost());
            Console.ReadLine();

        }
    }
}
