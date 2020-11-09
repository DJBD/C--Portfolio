namespace QuestionFive
{
    public class LazySingleton
    {
        /*This "lazy" singleton is not thread safe... if multiple threads are set off then it*/
        public string LValue { get; set; }

        private LazySingleton()
        {
        }

        private static LazySingleton _instance;

        public static LazySingleton GetInstance(string value)
        {
            if (_instance == null) //checks to see if it has already been initialised
            {
                _instance = new LazySingleton // if it hasn't then it creates one and saves it in the private field
                {
                    LValue = value
                }; 
            }

            return _instance; // returns the private field
        }

    }
}