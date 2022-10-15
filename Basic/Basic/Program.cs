using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(typeof(String) == typeof(string));
            //TestVar();
            //int val = 0;
            //long val2 = 0;
            //double val3 = 0;
            //float val4 = 0;
            //Console.WriteLine(val.GetType());
            //Console.WriteLine(val2.GetType());
            //Console.WriteLine(val3.GetType());  
            //Console.WriteLine(val4.GetType());
            //Console.WriteLine(val.GetType() == typeof(int));
            //PrintDataType();
            //UseOperator();
            //UserExpression();
            long ret = Fac(5);
            Console.WriteLine("5! = {0}", ret);
            Console.ReadKey();
        }

        static long Fac(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            long ret;
            return ret = Fac(n - 1) * n;
        }

        static void TestForEach()
        {
            var IntValues = new List<int>() { 1, 3, 5, 7, 9 };
            foreach(var value in IntValues)
            {
                Console.WriteLine(value);
            }
        }

        static void TestVar()
        {
            var a = 100;
            var s = "hello";
            var c = 3.1415926;
            Console.WriteLine(a.GetType());
            Console.WriteLine(s.GetType());
            Console.WriteLine(c.GetType());
        }
        static void PrintDataType()
        {
            int intVal = 100;
            long longVal = 100L;
            double doubleVal = 100.5d;
            float floatVal = 3.14f;

            Console.WriteLine("{0},{1}", sizeof(double), sizeof(long));

            longVal = intVal;
            doubleVal = intVal;
            doubleVal = longVal;
            intVal = (int)floatVal;
            doubleVal = (double)longVal;
        }

        static void StringAndNumberType()
        {
            //字符串转数字
            string strValue = "100";
            int intVal = int.Parse(strValue);   
            double doubleVal = double.Parse(strValue);
            intVal = Convert.ToInt32(strValue);
            doubleVal = Convert.ToDouble(strValue);

            //数字转字符串
            strValue = intVal.ToString();
            strValue = doubleVal.ToString();
            strValue = 100.ToString();

            strValue = intVal + "";
        }

        static void UseOperator()
        {
            // + - * / ()
            //double result = ((5 + 3) * 2 - 7) / 6.0;
            //Console.WriteLine(result);

            //int val = 9 % 4;
            //Console.WriteLine(val);

            int val2 = 1;
            Console.WriteLine(val2++); 
            int val3 = 1;
            Console.WriteLine(++val3);
        }
        static void UserExpression()
        {
            int value = 100;
            Console.WriteLine(value*2);
        }
    }
}
