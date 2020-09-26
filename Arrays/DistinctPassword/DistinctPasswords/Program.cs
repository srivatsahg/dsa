    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = {"abcd", "topi", "adcb",
                          "cdba", "bcda", "qrst"};

            //String[] input = {"abcd", "acbd", "adcb",
            //              "cdba", "bcda", "badc"};
            int n = input.Length;

            Console.WriteLine(countDistinct(input, n));
            Console.ReadLine();
        }

        private static int countDistinct(string[] input, int n)
        {
            int distinctPasswordCount = 0; // Initialize result 

            // Create an empty set and store all distinct 
            // strings in it. 
            HashSet<String> s = new HashSet<String>();
            for (int i = 0; i < n; i++)
            {
                // If this encoding appears first time, 
                // increment count of distinct encodings. 
                if (!s.Contains(encodeString(input[i].ToCharArray())))
                {
                    s.Add(encodeString(input[i].ToCharArray()));
                    distinctPasswordCount++;
                }
            }

            return distinctPasswordCount;
        }

        static int MAX_CHAR = 26;
        private static string encodeString(char[] str)
        {
            // hashEven stores the count of even  
            // indexed character for each string  
            // hashOdd stores the count of odd 
            // indexed characters for each string 
            int[] hashEven = new int[MAX_CHAR];
            int[] hashOdd = new int[MAX_CHAR];

            // creating hash for each string 
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                // If index of current character is odd 
                if ((i & 1) != 0)
                    hashOdd[i]++;
                else
                    hashEven[i]++;
            }

            // For every character from 'a' to 'z',  
            // we store its count at even position  
            // followed by a separator,  
            // followed by count at odd position. 
            String encoding = "";
            for (int i = 0; i < MAX_CHAR; i++)
            {
                encoding += (hashEven[i]);
                encoding += ('-');
                encoding += (hashOdd[i]);
                encoding += ('-');
            }
            return encoding;
        }
    }
}
