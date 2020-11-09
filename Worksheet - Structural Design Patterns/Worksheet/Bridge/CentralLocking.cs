namespace Bridge
{
    public class CentralLocking : IProduct
    {
        public CentralLocking(string name)
        {
        }

        public string ProductName { get; set; }

        public void Produce()
        {
            System.Console.WriteLine($"Producing Central Locking System");
        }

        public override string ToString()
        {
            return "Central Locking System";
        }
    }
}