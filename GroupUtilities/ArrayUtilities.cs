using System.Numerics;

namespace GroupUtilities {
    
    public static class ArrayUtilities {

        /// <summary>
        /// Finds the average of an integer array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The total average of the array.  
        /// </returns>
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

        /// <summary>
        /// Finds the average of an double array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The total average of the array.  
        /// </returns>
        public static double Average(double[] array) {
            double total = 0;
            double amount = 0;
            foreach (double num in array) {
                total += num;
            }
            foreach (double num in array) {
                amount++;
            }
            double average = total / amount;
            return average;
        }
        /// <summary>
        /// Finds the maximum of an integer array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The overall highest number in the array.  
        /// </returns>
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

        /// <summary>
        /// Finds the maximum of an double array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The overall highest number in the array.  
        /// </returns>
        public static double Max(double[] array) {
            double Max = array[0];
            int n = 0;
            foreach (double num in array) {
                if (Max < array[n]) {
                    Max = array[n];
                }
                n++;
            }
            return Max;
        }

        /// <summary>
        /// Finds the minimum of an integer array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The overall lowest number in the array.  
        /// </returns>
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

        /// <summary>
        /// Finds the minimum of an double array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The overall lowest number in the array.  
        /// </returns>
        public static double Min(double[] array) {
            double Min = array[0];
            int n = 0;
            foreach (double num in array) {
                if (Min > array[n]) {
                    Min = array[n];
                }
                n++;
            }
            return Min;
        }

        /// <summary>
        /// Sorts the integer array in an ascending fashion.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// An ascendingly sorted array.  
        /// </returns>
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

        /// <summary>
        /// Sorts the double array in an ascending fashion.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// An ascendingly sorted array.  
        /// </returns>
        public static double[] SortAscending(double[] array) {
            int amount = 0;
            foreach (double num in array) {
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

        /// <summary>
        /// Sorts the integer array in an descending fashion.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// A descendingly sorted array.  
        /// </returns>
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
        /// <summary>
        /// Sorts the double array in an descending fashion.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// A descendingly sorted array.  
        /// </returns>

        
        public static double[] SortDescending(double[] array) {
            int amount = 0;
            foreach (double num in array) {
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

        /// <summary>
        /// Finds the sum of an integer array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The total sum of the array.  
        /// </returns>
        public static int Sum(int[] array) {
            
            int total = 0;
            foreach (int num in array) {
                total += num;
            }
            return total;
        }
        /// <summary>
        /// Finds the sum of an double array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The total sum of the array.  
        /// </returns>
        public static  double Sum(double[] array) {
            double total = 0;
            foreach (double num in array) {
                total += num;
            }
            return total;
        }

        /// <summary>
        /// Finds the product of an integer array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The total product of the array.  
        /// </returns>
        public static int Product(int[] array) {
            int total = 1;
            foreach (int num in array) {
                total *= num;
            }
            return total;
        }

        /// <summary>
        /// Finds the product of an double array.  
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The total product of the array.  
        /// </returns>
        public static double Product(double[] array) {
            double total = 1;
            foreach (double num in array) {
                total *= num;
            }
            return total;
        }

        /// <summary>
        /// Sets every element in an integer array to the minimum.   
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// An array with every element as the minimum element from the input array.  
        /// </returns>
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

        /// <summary>
        /// Sets every element in an double array to the minimum.   
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// An array with every element as the minimum element from the input array.  
        /// </returns>

        public static double[] SetAllMin(double[] array) {
            double Min = array[0];
            int n = 0;
            foreach (double num in array) {
                if (Min > array[n]) {
                    Min = array[n];
                }
                n++;
            }
            n = 0;
            foreach (double num in array) {
                array[n] = Min;
                n++;
            }
            return array;
        }

        /// <summary>
        /// Sets every element in an integer array to the maximum.   
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// An array with every element as the maximum element from the input array.  
        /// </returns>
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

        /// <summary>
        /// Sets every element in an double array to the maximum.   
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// An array with every element as the maximum element from the input array.  
        /// </returns>
        public static double[] SetAllMax(double[] array) {
            double Max = array[0];
            int n = 0;
            foreach (double num in array) {
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

        /// <summary>
        /// Finds the sum of the absolute value of every number in an integer array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The absolute value of the array.  
        /// </returns>
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
        
        /// <summary>
        /// Finds the sum of the absolute value of every number in an double array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>
        /// The absolute value of the array.  
        /// </returns>
        public static double AbsoluteValue(double[] array) {
           int n = 0;
           double total = 0;
           foreach (double num in array) {
            if (array[n] < 0) {
                array[n] *= -1;
                
            }
            n++;
           }
           foreach (double number in array) {
                total += number;
            }
           return total;
        }

        }

    }