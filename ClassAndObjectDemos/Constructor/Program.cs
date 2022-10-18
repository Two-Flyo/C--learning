using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Myclass
    {
        private string _info;

        public string Info
        {
            get { return _info; }       
            set { _info = value; }  
        }

        public Myclass()
        {
            _info = "Hello World!";
            Console.WriteLine("无参构造函数被调用");
        }
        public Myclass(string info)
        {
            _info = info;
            Console.WriteLine("含参构造函数被调用");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            Myclass myclass1 = new Myclass("hello lrf ~ ");
        }
    }
}
