using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTuples
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int randomint = rnd.Next(); // creates a number between 1 and 12
            double randomdouble = rnd.Next();   // creates a number between 1 and 6
            bool randombool = rnd.Next(true);     // creates a number between 0 and 51





            Tuple<int, double, bool> tuple =
                new Tuple<int, double, bool>(1, 3.1415, true);

            if (tuple.Item1 == 1)
            {
                Console.WriteLine(tuple.Item1);
            }
            if (tuple.Item2 == 3.1415)
            {
                Console.WriteLine(tuple.Item2);
            }
            if (tuple.Item3)
            {
                Console.WriteLine(tuple.Item3);
            }
        }
    }
}

