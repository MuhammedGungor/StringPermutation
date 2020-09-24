using System;

namespace Loodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Main Text:");
            var mainText = Console.ReadLine();

            Console.WriteLine("Input Searchable Text (Pattern for search): ");
            var patternText = Console.ReadLine();
            StringPermutation.Compare(mainText, patternText);
        }
    }
}
