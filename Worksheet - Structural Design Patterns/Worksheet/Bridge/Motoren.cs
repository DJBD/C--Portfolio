namespace Bridge
{
    public class Motoren : Car
    {
        public Motoren(IProduct product, string v) : base(product, v)
        {
        }

        public override void Assemble()
        {
            System.Console.WriteLine($"Assembling {_product.ToString()} for {_carType.ToString()}");
        }

        public override void ProduceProduct()
        {
            _product.Produce();
            System.Console.WriteLine($"Modifying product {_product.ToString()} according to {_carType.ToString()}");
        }

        public override string ToString()
        {
            return ($"Car: {_carType.ToString()}, Product: {_product.ToString()} \n");
        }
    }
}