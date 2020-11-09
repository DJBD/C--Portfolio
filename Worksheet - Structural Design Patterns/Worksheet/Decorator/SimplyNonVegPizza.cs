namespace Decorator
{
    public class SimplyNonVegPizza : IPizza
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public SimplyNonVegPizza()
        {
            this.Description = "SimplyNonVegPizza (350)";
            this.Price = 350;
        }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}