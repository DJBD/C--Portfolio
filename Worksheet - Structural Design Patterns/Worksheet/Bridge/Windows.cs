namespace Bridge
{
    public class Windows: IProduct
    {
        public Windows(string name)
        {
        }
        public string ProductName { get; set; }
        public void Produce()
        {
            System.Console.WriteLine($"Producing Windows");
        }
        
        public override string ToString()
        {
            return "Window";
        }
    }
}