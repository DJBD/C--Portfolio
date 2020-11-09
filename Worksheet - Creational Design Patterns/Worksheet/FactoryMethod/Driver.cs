using System;

namespace QuestionThree
{
    public static class Driver
    {
        public static void Main(string[] args)
        {
            //Creator C = new Creator();
            //Console.WriteLine(C.FactoryMethod().whatProduct());

            ClientCode(new ConcreteCreator());
        }

        public static void ClientCode(Creator creator)
        {
            Console.WriteLine(creator.DoSometing());
        }
    }
}