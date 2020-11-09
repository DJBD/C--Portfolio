namespace Bridge
{
    public class GearLocking : IProduct
    {
        public GearLocking(string name)
        {
        }

        public string ProductName { get; set; }

        public void Produce()
        {
            System.Console.WriteLine($"Producing Gear Locking System");
        }

        public override string ToString()
        {
            return "Gear Locking System";
        }
    }
}