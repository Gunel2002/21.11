using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = MyLibrary.MyLibrary.Add(3, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
