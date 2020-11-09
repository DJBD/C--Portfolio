using System.ComponentModel;
using System.Diagnostics;

namespace Decorator
{
    public class SimplyVegPizza : IPizza
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public SimplyVegPizza()
        {
            this.Description = "SimplyVegPizza (230)";
            this.Price = 230;
        }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}