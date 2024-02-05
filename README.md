# Reinventing The Wheel Package

###### This package consists of three static classes: StringUtilities, ArrayUtilites, and MathUtilities. 
###### They were designed to apply to logic specifically when working with strings, arrays, and math. Pre-written methods to make your coding life easier.


*Detailed List of Functions found below >>>*

-----------------------------
# StringUtilities.cs - 


A static class of functions relating to the manipulating and searching of strings.



### (ToUpper): This method will take in 1 string as a parameter and return a string in the argument's uppercase form. 
``` Csharp
public static string ToUpper(string s)
        {
            string upperString = "";

            foreach (char c in s)
            {
                byte CharInAscii = (byte)c;
                if (CharInAscii >= 65 && CharInAscii <= 90 || CharInAscii >= 97 && CharInAscii <= 122)
                {
                    if (CharInAscii <= 90)
                    {
                        upperString += c;
                        continue;
                    }
                    CharInAscii -= 32;
                    char upperChar = (char)CharInAscii;

                    upperString += upperChar;
                }
                else
                {
                    upperString += c;
                }
            }
        }
```



### (ToLower): This method will take in 1 string as a parameter and return a string in the argument's lowercase form. 
``` Csharp
public static string ToLower(string s)
        {
            string lowerString = "";

            foreach (char c in s)
            {
                byte CharInAscii = (byte)c;
                if (CharInAscii >= 65 && CharInAscii <= 90 || CharInAscii >= 97 && CharInAscii <= 122)
                {
                    if (CharInAscii > 90)
                    {
                        lowerString += c;
                        continue;
                    }
                    CharInAscii += 32;
                    char lowerChar = (char)CharInAscii;

                    lowerString += lowerChar;
                }
                else
                {
                    lowerString += c;
                }
            }

            return lowerString;
        }
```



### (Length): This method will take in 1 string as a parameter and return an int regarding the number of characters within the given string.
``` Csharp
public static int Length(string s)
        {
            int letters = 0;

            foreach (char c in s)
            {
                letters++;
            }

            return letters;
        }
```



### (Reverse): This method will take in 1 string as a parameter and return a string that is the given string in reverse.
``` Csharp
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
```



### (CountVowels): This method will take in 1 string as a parameter and return an int that holds the number of vowels in the given string parameter.
``` Csharp
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
                        }
                    }
                }
            }

            return numOfVowels;
        }
```



### (CountConsonants): This method will take in 1 string as a parameter and return an int that holds the number of consonants in the given string parameter.
``` Csharp
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
        }
```



### (HasLetter): This method will take in 1 string and 1 char as parameters and return a bool that returns true if the given char was found in the given string, and false otherwise.
``` Csharp
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
```



### (RemoveNullSpace): This method will take in 1 string and return that given string without any spaces between the characters.
``` Csharp
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
```



### (AddPunctuation): This method will take 1 string and return the string with a period on the end of it.
``` Csharp
public static string AddPunctuation(string s)
        {
            return s += ".";
        }
```


### (RemoveNumbers): This method will take 1 string and return the string without any numbers within it.
``` Csharp
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
```

-----------------------------
ArrayUtilities.cs - 


(description)

(Method 1):

(Method 2):

(Method 3):

...

-----------------------------
MathUtilites.cs - 


(description)

(Method 1):

(Method 2):

(Method 3):

...

-----------------------------
