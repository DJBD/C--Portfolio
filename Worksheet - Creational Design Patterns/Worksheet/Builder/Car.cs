using System.Text;

namespace QuestionTwo
{
    public class Car : ICar
    {
        public string BodyStyle { get; set; }
        public string Power { get; set; }
        public string Engine { get; set; }
        public string Brakes { get; set; }
        public string Seats { get; set; }
        public string Windows { get; set; }
        public string FuelType { get; set; }
        public string CarType { get; set; }

        public override string ToString() => new StringBuilder()
            .Append($"-------------- {CarType} --------------------- \n")
            .Append($"Body: {BodyStyle}\n")
            .Append($"Power: {Power}\n")
            .Append($"Engine: {Engine}\n")
            .Append($"Breaks: {Brakes}\n")
            .Append($"Seats: {Seats}\n")
            .Append($"Windows: {Windows}\n")
            .Append($"Fuel Type: {FuelType}")
            .ToString();
    }
}