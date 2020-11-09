namespace QuestionTwo
{
    public interface ICarBuilder
    {
        public abstract void SetBodyStyle();
        public abstract void SetPower();
        public abstract void SetEngine();
        public abstract void SetBrakes();
        public abstract void SetSeats();
        public abstract void SetWindows();
        public abstract void SetFuelType();
        public abstract void SetCarType();
        ICar GetCar();
    }
}