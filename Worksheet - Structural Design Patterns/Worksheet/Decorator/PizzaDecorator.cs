namespace Decorator
{
    public abstract class PizzaDecorator: IPizza
    {
        protected IPizza _decoratedPizza;

        public PizzaDecorator(IPizza decoratedPizza)
        {
        }
        
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}