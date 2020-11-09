namespace QuestionThree
{
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
        
      
    }
}