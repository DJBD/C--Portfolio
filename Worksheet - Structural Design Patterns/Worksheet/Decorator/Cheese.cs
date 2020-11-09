namespace Decorator
{
    public class Cheese : IPizza
    {
        protected IPizza _decoratedPizza;

        public Cheese(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            Description = decoratedPizza.Description + ", Cheese (20.72)";
            Price = decoratedPizza.Price + (decimal) 20.72;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}