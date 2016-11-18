using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
    }
    class MyClass
    {
        public int GetCountOfSubstrings(string str)
        {

            string[] subStrings = str.Split(' ');
            return subStrings.Length;

        }
    }
}
