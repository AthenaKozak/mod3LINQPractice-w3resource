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
            // Q1 Produce numbers with the remainder of 0 after dividing by 2
            int[] numArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var q1 = from n in numArray
                     where (n % 2) == 0
                     select n;
            Console.WriteLine("Question 1");
            foreach (var n in q1) {
                Console.Write(n + " ");
            }
            Console.WriteLine("");


            // Q2 Find the +ve nums from a list using two where conditions
            var q2 = from n in numArray
                     where (n > 3)
                     where (n < 9)
                     select n;
            Console.WriteLine("Question 2");
            foreach (var n in q2)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("");

            // Q3 Find nums of array + their squares
            var q3 = from n in numArray
                     select new
                     {
                         num = n,
                         square = n * n
                     };
            Console.WriteLine("Question 3");
            foreach (var n in q3)
            {
                Console.WriteLine("The square of " + n.num + " is " + n.square);
            }
            Console.WriteLine("");


            // Q4 Display the number & frequency from array
            int[] numFreq = new int[10] { 3, 6, 8, 9, 9, 8, 4, 3, 3, 6 };

            var q4 = from n in numFreq
                     group n by n into list
                     orderby list.Key
                     select list;
            Console.WriteLine("Question 4");
            foreach (var n in q4)
            {
                Console.WriteLine("The number " + n.Key + " appears " + n.Count() );
            }
            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}
