using System;

namespace QuestionTwo
{
    public static class TestBuilderPattern
    {
        public static void Main(string[] args)
        {
            ICarBuilder carBuilder = new EstateCarBuilder();
            ICarDirector director = new CarDirector();
            director.Build(carBuilder);
            ICar car = carBuilder.GetCar();
            Console.WriteLine(car);

            Console.WriteLine();

            carBuilder = new SportsCarBuilder();
            director = new CarDirector();
            director.Build(carBuilder);
            car = carBuilder.GetCar();
            Console.WriteLine(car);
        }
    }
}