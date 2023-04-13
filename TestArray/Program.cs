using System.Runtime.CompilerServices;
using System;
using System.Linq;
using TestArray.Entities;

namespace TestArray
{
    internal class Program
    {
        private const int NmbersCount = 20;
        private const int ValueLengthStart = 1;
        private const int ValueLengthEnd = 5;
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        { 
            var array = Enumerable.Range(0, NmbersCount).Select(_=>new Item {Number= Random.Next(10), Value = new string('x', Random.Next(ValueLengthStart, ValueLengthEnd)) }).ToArray();

            array = array.OrderBy(x => x.Number).ToArray();

            Console.WriteLine(string.Join(", ", array.Select(i => $"{i.Number} - {i.Value }")));

            Console.ReadKey();
        }
    }
}
