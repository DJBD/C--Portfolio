namespace Decorator
{
    public class Meat : IPizza
    {
        protected IPizza _decoratedPizza;
        public Meat(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            Description =  decoratedPizza.Description +  ", Meat (14.25)"; 
            Price = decoratedPizza.Price + (decimal)14.25;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}