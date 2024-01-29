namespace GroupUtilities {
    
    public static class ArrayUtilities {

        public static int[] arrayRes;
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

        public static int[] SortAscending(int[] array) {
            int Min = array[0];
            int amount = 0;
            int n = 0;
            foreach (int num in array) {
                amount++;
            }
            for (int i = 0; i < amount -1; i++) {
                for (n = i+ 1; n< amount; n++) {
                if (Min > array[n]) {
                    Min = array[n];
                }
            }
            array[i] = Min;
            n = 0;
            }
            arrayRes = array;
            return array;

        }


        }

    }