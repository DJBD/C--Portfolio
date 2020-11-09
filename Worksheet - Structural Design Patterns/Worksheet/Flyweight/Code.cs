namespace Flyweight
{
    public class Code
    {
        private string _code;
        
        public Code(string code)
        {
            _code = code;
        }

        public override string ToString()
        {
            return _code;
        }
    }
}