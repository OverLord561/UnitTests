using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrenge
            string str = "Have a nice day";
            int startIndex = str.IndexOf('n');
            int length = str.Length - startIndex;
            string subExpected = "nice day";

            //act

            string subActual = str.Substring(startIndex, length);
            Console.WriteLine(subActual);
            //assert

            Console.ReadLine();
        }
    }
}
