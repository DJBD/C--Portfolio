namespace Decorator
{
    public class Ham : IPizza
    {
        protected IPizza _decoratedPizza;
        public Ham(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            Description =  decoratedPizza.Description +  ", Ham (18.12)"; 
            Price = decoratedPizza.Price + (decimal)18.12;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}