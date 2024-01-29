namespace GroupUtilities
{

    public static class StringUtilities
    {


        public static void ToUpper(string s)
        {

        }

        public static void ToLower(string s)
        {

        }

        public static void Length(string s)
        {

        }

        public static void Reverse(string s)
        {

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
            int numberOfConsonants = 0;

            foreach (char letter in s)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (letter != vowel[i])
                    {
                        numberOfConsonants++;
                    }
                }
            }

            return numberOfConsonants;
        }

        public static void HasLetter(string s, char letter)
        {

        }
    }
}