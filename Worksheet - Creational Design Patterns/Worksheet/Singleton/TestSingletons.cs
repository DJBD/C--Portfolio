using System;
using System.Threading;

namespace QuestionFive
{
    public static class TestSingletons
    {
        //A lot of developers consider the Singleton pattern an antipattern. That’s why its usage is on the decline in C# code.
        
        public static void Main(string[] args)
        {
            Thread process1 = new Thread(() =>
            {
                TestLazySingleton("GOOD");
                TestSingleton("FINGERS CROSSED");
            });
            Thread process2 = new Thread(() =>
            {
                TestLazySingleton("NO GOOD"); //for singleton to be "thread safe" this should not be printed but however it is.
                TestSingleton("FINGERS NOT CROSSED"); //this singleton is "thread safe", once it is initialised by process1, process2 is unable to change it.
            });
            
            process1.Start();
            process2.Start();
            process1.Join();
            process2.Join();
            
        }
        
        public static void TestLazySingleton(string value)
        {
            LazySingleton singleton = LazySingleton.GetInstance(value);
            Console.WriteLine(singleton.LValue);
        } 
        
        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        } 
    }
}