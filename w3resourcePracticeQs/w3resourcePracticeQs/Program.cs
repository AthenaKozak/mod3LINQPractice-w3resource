using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3resourcePracticeQs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1 write prg that produces numbers with the remainder of 0 after dividing by 2
            int[] numArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var q1 = from n in numArray
                     where (n % 2) == 0
                     select n;
            foreach (var n in q1) {
                Console.Write(n + " ");
            }


            // Q2

            Console.ReadLine();
        }
    }
}
