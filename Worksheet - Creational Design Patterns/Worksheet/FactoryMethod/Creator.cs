using System;

namespace QuestionThree
{
    public abstract class Creator : ICreator
    {
        //public IProduct FactoryMethod(string s) // some type of argument - you might change this
        //{
        //    throw new NotImplementedException();
        //}

        public abstract IProduct FactoryMethod();

        public string DoSometing()
        {
            var F = FactoryMethod();

            var P = F.whatProduct();

            return P;
        }
    }
}