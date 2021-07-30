using System;
using System.Linq;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jai Shree Ram ! , Welcome to LINQ");

            // declare an string array
            string[] words = {"deepak","appu","pratik","vipin","avika" };
            
            // select words length > 5
            var shortWords = from word in words where word.Length >= 5 select word;

            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }


            Console.ReadLine();
        }
    }
}
