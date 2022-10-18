using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 1, 3, 5, 7, 9, 11, 13, 15 };
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
