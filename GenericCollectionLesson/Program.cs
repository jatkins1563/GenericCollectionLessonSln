using System;
using System.Collections.Generic;

namespace GenericCollectionLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new List<int>();
            ints.Add(4);
            ints.Add(7);
            ints.Add(15);
            Console.WriteLine($"The ints have {ints.Count} items.");
            ints.Remove(7);
            Console.WriteLine($"The ints have {ints.Count} items.");

            ints.RemoveAll(x => x < 5 || x > 25);

            //var bowling1 = new List<int>();
            //var bowling2 = new List<int>();
            //var bowling3 = new List<int>();
            //Random rnd = new Random();
            //var sum = 0;

            //for(int i = 0; i < 10; i++)
            //{
            //    var score = rnd.Next(0, 31);
            //    bowling1.Add(score);
            //    score = rnd.Next(0, 31);
            //    bowling2.Add(score);
            //    score = rnd.Next(0, 31);
            //    bowling3.Add(score);
            //}
            //foreach(var score in bowling1)
            //{
            //    sum += score;
            //}
            //foreach (var score in bowling2)
            //{
            //    sum += score;
            //}
            //foreach (var score in bowling3)
            //{
            //    sum += score;
            //}
            //Console.WriteLine($"Final Score: {sum}");
        }
    }
}
