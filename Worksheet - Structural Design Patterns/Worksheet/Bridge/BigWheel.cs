using System;

namespace Bridge
{
    internal class BigWheel : Car
    {
       
        public BigWheel(IProduct product, string v) : base(product, v)
        {          
        }

        public override void ProduceProduct()
        {
            _product.Produce();
            Console.WriteLine($"Modifying product {_product.ToString()} according to {_carType.ToString()}");
        }

        public override void Assemble()
        {
            Console.WriteLine($"Assembling {_product.ToString()} for {_carType.ToString()} ");
        }

        public override string ToString()
        {
            return ($"Car: {_carType.ToString()}, Product: {_product.ToString()} \n"); 
        }
    }
}