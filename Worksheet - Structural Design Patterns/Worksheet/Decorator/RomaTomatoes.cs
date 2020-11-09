namespace Decorator
{
    public class RomaTomatoes : IPizza
    {
        private readonly IPizza _decoratedPizza;
        public RomaTomatoes(IPizza decoratedPizza)
        {
            _decoratedPizza = decoratedPizza;
            Description =  decoratedPizza.Description + ", Roma Tomatoes (5.20)";
            Price = decoratedPizza.Price + (decimal)5.2;
        }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Desc: {Description} \nPrice: {Price}";
        }
    }
}