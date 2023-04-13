using System.Runtime.CompilerServices;
using System;
using System.Linq;

namespace TestArray
{
    internal class Program
    {
        private const int NmbersCount = 20;
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        { 
            var array = Enumerable.Range(0, NmbersCount).Select(_=> Random.Next(10)).ToArray();
            array = array.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", array));

            Console.ReadKey();
        }
    }
}
