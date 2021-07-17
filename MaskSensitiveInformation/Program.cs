using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaskSensitiveInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password");
            var value = Console.ReadLine();
            var numberToRemove = value.Length - 4;
            var fourLetters = value.Remove(0, numberToRemove);
            var remainingLetters = value.Remove(numberToRemove);
            var maskedLetters = new StringBuilder();
            for (var i=0; i < remainingLetters.Length; i++)
            {
                maskedLetters.Append('*');
            }
            Console.WriteLine(maskedLetters + fourLetters);
        }
    }
}
