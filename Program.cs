using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            Console.WriteLine("Please enter some text: ");
            myString = Console.ReadLine();

            myString.ToCharArray();
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            int sum = 0;

            for (int i = 0; i < myString.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (myString[i] == vowels[j])
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
