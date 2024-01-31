using System.Text.RegularExpressions;

namespace GroupUtilities
{

    public static class StringUtilities
    {


        public static string ToUpper(string s)
        {
            string upperString = "";

            foreach (char c in s)
            {
                byte CharInAscii = (byte)c;
                if (CharInAscii <= 90)
                {
                    upperString += c;
                    continue;
                }
                CharInAscii -= 32;
                char upperChar = (char)CharInAscii;

                upperString += upperChar;
            }

            return upperString;
        }

        public static string ToLower(string s)
        {
            string lowerString = "";

            foreach (char c in s)
            {
                byte CharInAscii = (byte)c;
                if (CharInAscii > 90)
                {
                    lowerString += c;
                    continue;
                }
                CharInAscii += 32;
                char lowerChar = (char)CharInAscii;

                lowerString += lowerChar;
            }

            return lowerString;
        }

        public static int Length(string s)
        {
            int letters = 0;

            foreach (char c in s)
            {
                letters++;
            }

            return letters;
        }

        public static string Reverse(string s)
        {
            char[] array = new char[Length(s)];
            String reversedString = "";
            int index = 0;

            foreach (char c in s)
            {
                array[index] = c;
                index++;
            }
            for (int i = Length(s) - 1; i >= 0; i--)
            {
                reversedString += array[i];
            }

            return reversedString;
        }

        public static int CountVowels(string s)
        {
            char[] vowel = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
            int numberOfVowels = 0;

            foreach (char letter in s)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (letter == vowel[i])
                    {
                        numberOfVowels++;
                    }
                }
            }

            return numberOfVowels;
        }

        public static int CountConsonants(string s)
        {
            char[] vowel = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
            int numberOfVowels = 0;
            bool match = false;

            foreach (char letter in s)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (letter == vowel[i])
                    {
                        numberOfVowels++;
                    }
                }
            }

            return Length(s) - numberOfVowels;
        }

        public static bool HasLetter(string s, char letter)
        {
            bool hasLetter = false;

            foreach (char c in s)
            {
                if (c == letter)
                {
                    hasLetter = true;
                    break;
                }
            }

            return hasLetter;
        }
    }
}