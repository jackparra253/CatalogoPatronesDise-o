using System;
using System.Threading;

namespace ThreadSafe.Domain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:");

            var procces1 = new Thread(() =>
            {
                TestSingleton("Hi");
            });

            var process2 = new Thread(() =>
            {
                TestSingleton("Hi singleton!!!");
            });

            procces1.Start();
            process2.Start();

            procces1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            var singleton = Singleton.GetIntance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
