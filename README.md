# Reinventing The Wheel Package

###### This package consists of three static classes: StringUtilities, ArrayUtilites, and MathUtilities. 
###### They were designed to apply to logic specifically when working with strings, arrays, and math. Pre-written methods to make your coding life easier.
<br>

*Detailed List of Functions found below >>>*

-----------------------------
# StringUtilities.cs - 


A static class of functions relating to the manipulating and searching of strings.
<br><br><br>


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
<br>


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
<br>


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
<br>


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
<br>


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
<br>


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
<br>


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
<br>


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
<br>


### (AddPunctuation): This method will take 1 string and return the string with a period on the end of it.
``` Csharp
public static string AddPunctuation(string s)
        {
            return s += ".";
        }
```
<br>

-----------------------------
ArrayUtilities.cs - 


(description): This package contains a multitude of functions that either find something or alter something about/from an array.  This can vary from adding every number an array up or sorting them in some way.  Every function included has one overload that uses double inputs/results while the orignals use integer inputs/results

(Method 1 Average): This function finds the average of an array by finding the sum and then dividing it by the total, Ex. 8, 2, 7, 4, 5, 6 would return 5.  .  
=======
``` Csharp
public static int Average(int[] array) {
            int total = 0;
            int amount = 0;
            foreach (int num in array) {
                total += num;
            }
            foreach (int num in array) {
                amount++;
            }
            int average = total / amount;
            return average;
        }
``` 

(Method 2 Max): This function finds the highest number within an array.  Ex. 8, 2, 7, 4, 5, 6 would return 8.  
``` Csharp
    public static int Max(int[] array) {
            int Max = array[0];
            int n = 0;
            foreach (int num in array) {
                if (Max < array[n]) {
                    Max = array[n];
                }
                n++;
            }
            return Max;
        }
``` 

(Method 3 Min): This function finds the lowest number within an array, Ex. 8, 2, 7, 4, 5, 6 would return 2
``` Csharp
    public static int Min(int[] array) {
            int Min = array[0];
            int n = 0;
            foreach (int num in array) {
                if (Min > array[n]) {
                    Min = array[n];
                }
                n++;
            }
            return Min;
        }
``` 

(Method 4 SortAscending): Takes in an array input and sorts it in ascending order, Ex. 8, 2, 7, 4, 5, 6 would return 2, 4, 5, 6, 7, 8.  
``` Csharp
    public static int[] SortAscending(int[] array) {
            int amount = 0;
            foreach (int num in array) {
                amount++;
            }
            for (int i = 0; i < amount; i++) {
                for (int n = 0; n < amount - 1; n++) {
                    if (array[n] > array[n+ 1]) {
                        (array[n + 1], array[n]) = (array[n], array[n + 1]);
                    }
            }
            }
            return array;
        }
``` 

(Method 5 SortDescending): Takes in an array input and sorts it in descending order, Ex. 8, 2, 7, 4, 5, 6 would return 8, 7, 6, 5, 4, 2.  
``` Csharp
    public static int[] SortDescending(int[] array) {
            int amount = 0;
            foreach (int num in array) {
                amount++;
            }
            for (int i = 0; i < amount; i++) {
                for (int n = 0; n < amount - 1; n++) {
                    if (array[n] < array[n+ 1]) {
                        (array[n + 1], array[n]) = (array[n], array[n + 1]);
                    }
            }
            }
            return array;
        }
``` 

(Method 6 Sum): Takes in an array input and finds the sum of all elements, Ex. 8, 2, 7, 4, 5, 6 would return 32.  
``` Csharp
    public static int Sum(int[] array) {
            
            int total = 0;
            foreach (int num in array) {
                total += num;
            }
            return total;
        }
``` 

(Method 7 Product): Takes in an array input and finds the product of all elements, Ex. 8, 2, 7, 4, 5, 6 would return 13440. 
``` Csharp
      public static int Product(int[] array) {
            int total = 1;
            foreach (int num in array) {
                total *= num;
            }
            return total;
        }

```  

(Method 8 SetAllMin): Takes in an array input and sets every element to the minimum of the array, Ex. 8, 2, 7, 4, 5, 6 would return 2, 2, 2, 2, 2, 2.  
``` Csharp
    public static int[] SetAllMin(int[] array) {
            int Min = array[0];
            int n = 0;
            foreach (int num in array) {
                if (Min > array[n]) {
                    Min = array[n];
                }
                n++;
            }
            n = 0;
            foreach (int num in array) {
                array[n] = Min;
                n++;
            }
            return array;
        }
``` 

(Method 9 SetAllMax): Takes in an array input and sets every element to the maximum of the array, Ex. 8, 2, 7, 4, 5, 6 would return 8, 8, 8, 8, 8, 8.  
``` Csharp
    public static int[] SetAllMax(int[] array) {
            int Max = array[0];
            int n = 0;
            foreach (int num in array) {
                if (Max < array[n]) {
                    Max = array[n];
                }
                n++;
            }
            n = 0;
            foreach (int num in array) {
                array[n] = Max;
                n++;
            }
            return array;
        }

``` 

(Method 10 AbsoluteValue): Takes in an array input and adds up the absolute value of every element meaning any negative elements are turned postive and then added, Ex. -8, 2, 7, 4, -5, 6 would return 32.  
``` Csharp
    public static int AbsoluteValue(int[] array) {
           int n = 0;
           int total = 0;
           foreach (int num in array) {
            if (num < 0) {
                array[n] *= -1;
            }
            n++;
           }
           foreach (int number in array) {
                total += number;
            }
           return total;
        }
``` 



-----------------------------
MathUtilites.cs - 


(description): This part of the package is Math-Focused, allowing you to Add, Subtract, Divide, and Multiply; As well as offering other functions like finding the Minimum of two Integers, the Maximum of two Integers, showing you the Absolute Value of an Integer, and even multiplication of one Integer to the Power of another Integer.

(Method 1 Add): Takes in two Integers and adds them together. Ex. 2, 5 would return 7.

(Method 2 Subtract): Takes in two Integers and subtracts them. Ex. 7, 5 would return 2.

(Method 3 Divide): Takes in two Integers and divides them. Ex. 6, 3 would return 2.

(Method 4 Multiply): Takes in two Integers and multiplies them. Ex. 2, 3 would return 6.

(Method 5 Min): Takes in two Integers and returns the lower of the two. Ex. 3, 4 would return 3.

(Method 6 Max): Takes in two Integers and return the higher of the two. Ex. 3, 4 would return 4.

(Method 7 AbsoluteValue): Takes in an Integer and returns its absolute value. Ex. 3 would return -3

(Method 8 Power): Takes in two Integers and multiplies the first by the power of the secod. Ex. 2, 5 would return 32.

(Method 9 MultiStepAll): Takes in five Integers and adds, subtracts, divides, and multiplies them, in that order. Ex. 2, 5, 3, 4, 6 would return 7.

(Method 10 MultiStepAddSubtract): Takes in three Integers and adds the first two Integers, then subtracts the result by the last Integer. Ex. 2, 3, 4 would return 1.

(Method 11 MultiStepDivideMultiply): takes in three Integers and Divides the first two Integers, then multiplies the result by the last Integer, Ex. 6, 3, 4 would return 8.
