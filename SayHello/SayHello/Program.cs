using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestConsoleProperty();
            Console.WriteLine("Hello!");
            TestInputAndOutput();
            Console.WriteLine("First ReadKey()");
            Console.ReadKey();
            Console.WriteLine("Seccond ReadKey()");
            Console.ReadKey(true); //不希望用户的按键显示在控制台上
            Console.WriteLine("Final Readkey()");
            Console.ReadKey();
            Console.Beep();
            Console.WriteLine("Press any key to qui...");
            Console.ReadKey();
        }
        
        static void TestConsoleProperty()
        {
            Console.Title = "Current Time:" + DateTime.Now;
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        static void TestInputAndOutput()
        {
            Console.Write("Please input a string:");
            String userInfo = Console.ReadLine();
            

            Console.WriteLine("User input:{0} length:{1}",userInfo,userInfo.Length);
        }
    }
}
