using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------REVERSING STRING------


            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            Console.WriteLine("Reversed String: " + reverse);



            //-----PALINDROME OR NOT----

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            if (str.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a Palindrome.");
            }


            //----How to reverse the order of words in a given string-----

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string[] words = str.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Reversed Word Order: ");

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }

            Console.WriteLine();



            //  -----How to reverse each word in a given string------

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string[] words = str.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Reversed Words: ");

            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    Console.Write(word[i]);
                }

                Console.Write(" ");
            }

            Console.WriteLine();



            //-----How to count the occurrence of each character in a string-----

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    continue;
                }

                if (count.ContainsKey(ch))
                {
                    count[ch]++;
                }
                else
                {
                    count[ch] = 1;
                }
            }

            Console.WriteLine("Character Occurrences:");

            foreach (KeyValuePair<char, int> item in count)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }



            //----How to remove duplicate characters from a string---

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            HashSet<char> seen = new HashSet<char>();
            string result = "";

            foreach (char ch in str)
            {
                if (seen.Add(ch))
                {
                    result += ch;
                }
            }

            Console.WriteLine("String without Duplicates: " + result);
        }

    }


    }








    
    
    


