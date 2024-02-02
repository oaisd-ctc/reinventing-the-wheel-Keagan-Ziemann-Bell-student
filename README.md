This package consists of three static classes: StringUtilities, ArrayUtilites, and MathUtilities. 
They were designed to apply to logic specifically when working with strings, arrays, and math. Pre-written methods to make your life easier.


Detailed List of Functions found below >>>

-----------------------------
StringUtilities.cs - 


(description)

(Method 1):

(Method 2):

(Method 3):

...

-----------------------------
ArrayUtilities.cs - 


(description): This package contains a multitude of functions that either find something or alter something about/from an array.  This can vary from adding every number an array up or sorting them in some way.  Every function included has one overload that uses double inputs/results while the orignals use integer inputs/results

(Method 1 Average): This function finds the average of an array by finding the sum and then dividing it by the total, Ex. 8, 2, 7, 4, 5, 6 would return 5.  
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


(description)

(Method 1):

(Method 2):

(Method 3):

...

-----------------------------
