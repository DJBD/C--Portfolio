namespace Decorator
{
    public class Spinach : IPizza
    {
        protected IPizza _decoratedPizza;
        public Spinach(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            Description =  decoratedPizza.Description +  ", Spinach (0.47)"; 
            Price = decoratedPizza.Price + (decimal).47;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}