namespace Decorator
{
    public class GreenOlives : IPizza
    {
        protected IPizza _decoratedPizza;
        public GreenOlives(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            Description =  decoratedPizza.Description +  ", Green Olives (5.47)"; 
            Price = decoratedPizza.Price + (decimal)5.47;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}