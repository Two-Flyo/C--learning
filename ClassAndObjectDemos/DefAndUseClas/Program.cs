using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefAndUseClas
{
    public class Myclass
    {
        public int i = 0;
        private int j = 0;


        public void PrintValue()
        {
            int j = 1;
            Console.WriteLine("i={0},j={1}",i ,j);
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.i = 100;
            obj.PrintValue();
        }
    }
}
