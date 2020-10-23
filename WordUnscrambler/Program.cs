using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordUnscrambler
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] lines = { "first line", "second Line", "this is the third line" };

            File.WriteAllLines("MyfirstFile.txt", lines);

            string[] fileContents = File.ReadAllLines("MyFirstFile.txt");

            Console.WriteLine(fileContents);

            foreach(string line in File.ReadLines("MyFirstFile.txt"))
            {
                Console.WriteLine(line);
            }




        }

      
    }
}
