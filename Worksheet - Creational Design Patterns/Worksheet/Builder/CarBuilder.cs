using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionTwo
{
    public abstract class CarBuilder : ICarBuilder
    {
        protected readonly ICar _car = new Car();
        public abstract void SetBodyStyle();
        public abstract void SetPower();
        public abstract void SetEngine();
        public abstract void SetBrakes();
        public abstract void SetSeats();
        public abstract void SetWindows();
        public abstract void SetFuelType();
        public abstract void SetCarType();
        public virtual ICar GetCar()
        {
            return _car;
        }
    }
}
