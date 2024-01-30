namespace GroupUtilities {
    
    public static class MathUtilities 
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Min(int x, int y)
        {
            int Min = 0;
            if (x < y)
            {
                Min = x;
            }
            else
            {
                Min = y;
            }
            return Min;
        }
        public static int Max(int x, int y)
        {
            int Max = 0;
            if (x > y)
            {
                Max = x;
            }
            else
            {
                Max = y;
            }
            return Max;
        }
        public static int AbsoluteValue(int x)
        {
            return -x;
        }
        public static int Power(int Base, int Power)
        {
            int total = Base;
            for (int n = 2; n <= Power; n++)
            {
                total = total * Base;
            }
            return total;
        }
         public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Min(double x, double y)
        {
            double Min = 0;
            if (x < y)
            {
                Min = x;
            }
            else
            {
                Min = y;
            }
            return Min;
        }
        public static double Max(double x, double y)
        {
            double Max = 0;
            if (x > y)
            {
                Max = x;
            }
            else
            {
                Max = y;
            }
            return Max;
        }
        public static double AbsoluteValue(double x)
        {
            return -x;
        }
        public static double Power(double Base, double Power)
        {
            double total = Base;
            for (double n = 2; n <= Power; n++)
            {
                total = total * Base;
            }
            return total;
        }
    }
}