using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("treasureisland.txt");
            Console.WriteLine(input);
            int[] intArray = new int[5] { 0, 0, 0, 0, 0 };

            Console.WriteLine("\n\n\n\n");
            int printableCount = PrintableChars(input);
            Console.WriteLine("Total number of printable characters: {0}", printableCount);

            int whitespaceCount = WhiteSpaces(input);
            Console.WriteLine("Total number of whitespace characters: {0}", whitespaceCount);

            int consonentsCount = Consonents(input);
            Console.WriteLine("Total number of consonents: {0}", consonentsCount);

            int vowelsCount = Vowels(input);
            Console.WriteLine("Total number of vowels: {0}", vowelsCount);

            VowelFrequency(intArray, input);

        }

        public static int PrintableChars(string text)
        {
            int result = 0;

            foreach (char c in text)
            {
                if (IsPrintableCharacter(c) == true) result++;

            }

            return result;
        }
        public static int WhiteSpaces(string text)
        {
            int result = 0;
            //char c = ' ';
            //result = Regex.Matches(text, c.ToString()).Count;
            foreach (char c in text)
            {
                if (IsWhitespace(c) == true) result++;

            }
            return result;
        }
        public static int Vowels(string text)
        {
            int result = 0;

            foreach (char c in text)
            {
                if (isVowel(c) == true) result++;

            }
            return result;

        }
        public static int Consonents(string text)
        {
            int result = 0;
            foreach (char c in text)
            {
                if (isConsonant(c) == true) result++;

            }
            return result;
        }
        public static void VowelFrequency(int[] ints, string text)
        {
            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;

            text = text.ToUpper();

            //add the frequency to the array
            foreach (char c in text)
            {
                if (isVowel(c) == true && c == 'A')
                {
                    a++;
                    ints[0] = a;

                }

                else if (isVowel(c) == true && c == 'E')
                {
                    e++;
                    ints[1] = e;
                }
                else if (isVowel(c) == true && c == 'I')
                {
                    i++;
                    ints[2] = i;
                }
                else if (isVowel(c) == true && c == 'O')
                {
                    o++;
                    ints[3] = o;
                }
                else if (isVowel(c) == true && c == 'U')
                {
                    u++;
                    ints[4] = u;
                }

            }

            Console.WriteLine("Frequency of a: {0}", ints[0]);
            Console.WriteLine("Frequency of e: {0}", ints[1]);
            Console.WriteLine("Frequency of i: {0}", ints[2]);
            Console.WriteLine("Frequency of o: {0}", ints[3]);
            Console.WriteLine("Frequency of u: {0}", ints[4]);

        }




        public static bool IsPrintableCharacter(char character)
        {
            return (character >= 33 || character < 127);
        }
        public static bool IsWhitespace(char character)
        {
            return (character == 32);
        }

        public static bool isConsonant(char character)
        {
            // Convert to all uppercase 
            character = Char.ToUpper(character);

            return !(character == 'A' || character == 'E' || character == 'I' || character == 'O' ||
                character == 'U') && character >= 65 && character <= 90;
        }

        public static bool isVowel(char character)
        {
            // Convert to all uppercase 
            character = Char.ToUpper(character);
            return (character == 'A' || character == 'E' || character == 'I' || character == 'O' ||
                character == 'U');
        }

    }

