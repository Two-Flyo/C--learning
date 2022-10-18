using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace UseMyLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathLibrary lib = new MathLibrary();
            Console.WriteLine(lib.Add(110,220));
        }   
    }
}
