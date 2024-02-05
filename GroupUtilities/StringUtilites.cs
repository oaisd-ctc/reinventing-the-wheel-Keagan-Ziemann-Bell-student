using System.Text.RegularExpressions;

namespace GroupUtilities
{

    public static class StringUtilities
    {


        /// <summary>
        /// Converts all characters in a given string to it's Uppercase form
        /// </summary>
        /// <param name="s">A string that will be converted to Uppercase and returned</param>
        /// <returns>Uppercase form of string 's'</returns>
        public static string ToUpper(string s)
        {
            string upperString = "";

            foreach (char c in s)
            {
                byte charInAscii = (byte)c;
                if (charInAscii >= 65 && charInAscii <= 90 || charInAscii >= 97 && charInAscii <= 122)
                {
                    if (charInAscii <= 90)
                    {
                        upperString += c;
                        continue;
                    }
                    charInAscii -= 32;
                    char upperChar = (char)charInAscii;

                    upperString += upperChar;
                }
                else
                {
                    upperString += c;
                }
            }

            return upperString;
        }


        /// <summary>
        /// Converts all characters in a given string to it's Lowercase form
        /// </summary>
        /// <param name="s">A string that will be converted to Lowercase and returned</param>
        /// <returns>Lowercase form of string 's'</returns>
        public static string ToLower(string s)
        {
            string lowerString = "";

            foreach (char c in s)
            {
                byte charInAscii = (byte)c;
                if (charInAscii >= 65 && charInAscii <= 90 || charInAscii >= 97 && charInAscii <= 122)
                {
                    if (charInAscii > 90)
                    {
                        lowerString += c;
                        continue;
                    }
                    charInAscii += 32;
                    char lowerChar = (char)charInAscii;

                    lowerString += lowerChar;
                }
                else
                {
                    lowerString += c;
                }
            }

            return lowerString;
        }


        /// <summary>
        /// Counts the amount of characters within a string
        /// </summary>
        /// <param name="s">A string whose length is counted and returned</param>
        /// <returns>The length of string 's'</returns>
        public static int Length(string s)
        {
            int letters = 0;

            foreach (char c in s)
            {
                letters++;
            }

            return letters;
        }


        /// <summary>
        /// Reverses the order characters appear in a given string
        /// </summary>
        /// <param name="s">A string that is reversed and returned</param>
        /// <returns>String 's' in reverse</returns>
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


        /// <summary>
        /// Counts the number of Vowels in a given string
        /// </summary>
        /// <param name="s">A string whose Vowels will be counted and returned</param>
        /// <returns>The number of Vowels within string 's'</returns>
        public static int CountVowels(string s)
        {
            char[] vowel = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
            int numOfVowels = 0;

            foreach (char c in s)
            {
                byte asciiNum = (byte)c;
                if (asciiNum >= 65 && asciiNum <= 90 || asciiNum >= 97 && asciiNum <= 122)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (c == vowel[i])
                        {
                            numOfVowels++;
                            break;
                        }
                    }
                }
            }

            return numOfVowels;
        }


        /// <summary>
        /// Counts the number of Consonants in a given string
        /// </summary>
        /// <param name="s">A string whose Consonants will be counted and returned</param>
        /// <returns>The number of Consonants within string 's'</returns>
        public static int CountConsonants(string s)
        {
            char[] vowel = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
            int numOfVowels = 0;
            int notLetters = 0;

            foreach (char c in s)
            {
                byte asciiNum = (byte)c;
                if (asciiNum >= 65 && asciiNum <= 90 || asciiNum >= 97 && asciiNum <= 122)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (c == vowel[i])
                        {
                            numOfVowels++;
                            break;
                        }
                    }
                }
                else
                {
                    notLetters++;
                }
            }

            int numOfLetters = Length(s) - notLetters;
            return numOfLetters - numOfVowels;
        }


        /// <summary>
        /// Runs through the given string to verify if there is the given char within the string
        /// </summary>
        /// <param name="s">A string who is verified of having the given char</param>
        /// <param name="letter">A char that is searched for within the given string</param>
        /// <returns>A boolean of whether char 'letter' is within string 's'</returns>
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


        /// <summary>
        /// Finds and removes any null spaces within a given string
        /// </summary>
        /// <param name="s">A string to search and remove null spaces from</param>
        /// <returns>String 's' with no null spaces</returns>
        public static string RemoveNullSpace(string s)
        {
            string finalString = "";

            foreach (char c in s)
            {
                if (c != ' ')
                {
                    finalString += c;
                }
            }

            return finalString;
        }


        /// <summary>
        /// Adds '.' at the end of a given string
        /// </summary>
        /// <param name="s">A string to add '.' to</param>
        /// <returns>String 's' with '.' added at the end of the string</returns>
        public static string AddPunctuation(string s)
        {
            return s += ".";
        }


        /// <summary>
        /// Removes all numbers from a given string
        /// </summary>
        /// <param name="s">A string that numbers are removed from</param>
        /// <returns>String 's' without any numbers</returns>
        public static string RemoveNumbers(string s)
        {
            string finalString = "";

            foreach (char c in s)
            {
                byte charInAscii = (byte)c;
                if (charInAscii >= 48 && charInAscii <= 57) { }
                else
                {
                    finalString += c;
                }
            }

            return finalString;
        }

    }
}