using System.Numerics;

namespace GroupUtilities {
    
    public static class ArrayUtilities {

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
        public static int Sum(int[] array) {
            int total = 0;
            foreach (int num in array) {
                total += num;
            }
            return total;
        }

        public static  double Sum(double[] array) {
            double total = 0;
            foreach (double num in array) {
                total += num;
            }
            return total;
        }

        public static int Product(int[] array) {
            int total = 1;
            foreach (int num in array) {
                total *= num;
            }
            return total;
        }

        public static double Product(double[] array) {
            double total = 1;
            foreach (double num in array) {
                total *= num;
            }
            return total;
        }

        }

    }