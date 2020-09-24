using System;
using System.Collections.Generic;
using System.Text;

namespace Loodos
{
    public class StringPermutation
    {
        public static bool Compare(string mainText, string pattern)
        {
            var mainArray = mainText.ToCharArray();
            var patArray = pattern.ToCharArray();

            Array.Sort(mainArray);
            Array.Sort(patArray);

            var m = 0;
            for (int i = 0; i < mainArray.Length; i++)
            {
                if (patArray[m] == mainArray[i])
                {
                    m++;
                    if (m == patArray.Length)
                    {
                        Console.WriteLine($"It's OK! -------- MainText: \"{mainText}\"  , Pattern: \"{pattern}\" => {true}");
                        return true;
                    }
                }
            }

            Console.WriteLine($"Failed -------- MainText: \"{mainText}\"  , Pattern: \"{pattern}\" => {false}");
            return false;
        }
    }
}