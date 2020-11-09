namespace QuestionTwo
{
    public class CarDirector : ICarDirector
    {
        public void Build(ICarBuilder builder)
        {
            builder.SetCarType();
            builder.SetBodyStyle();
            builder.SetBrakes();
            builder.SetEngine();
            builder.SetFuelType();
            builder.SetPower();
            builder.SetSeats();
            builder.SetWindows();
        }
    }
}