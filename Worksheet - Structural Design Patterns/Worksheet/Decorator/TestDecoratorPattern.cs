using System;

namespace Decorator
{
    public static class TestDecoratorPattern
    {
        public static void Main(string[] args)
        {
            IPizza pizza = new SimplyVegPizza();
            Console.WriteLine(pizza);
            
            pizza = new GreenOlives(pizza);
            Console.WriteLine(pizza);
            
            pizza = new RomaTomatoes(pizza);
            Console.WriteLine(pizza);
            
            pizza = new Spinach(pizza);
            Console.WriteLine(pizza);
            
            pizza = new SimplyNonVegPizza();
            Console.WriteLine(pizza);
            
            pizza = new Meat(pizza);
            Console.WriteLine(pizza);
            
            pizza = new Cheese(pizza);
            Console.WriteLine(pizza);
            
            pizza = new Cheese(pizza);
            Console.WriteLine(pizza);
            
            pizza = new Ham(pizza);
            Console.WriteLine(pizza);
        }
    }
}