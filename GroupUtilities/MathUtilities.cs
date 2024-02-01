namespace GroupUtilities
{
    public static class MathUtilities
    {
        /// <summary>
        /// Adds together two Integers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns the sum of the two numbers</returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Subtracts the two Integers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retruns the remainder of the two numbers</returns>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Divides the two Integers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns the quotient of the two numbers</returns>
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        /// <summary>
        /// Multiplies the two Integers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns the of product the two numbers</returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Gives the minimum of the two Integers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns the Minimum of the two numbers</returns>
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
        /// <summary>
        /// Gives the maximum of the two integers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns the Maximum of the two numbers</returns>
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
        /// <summary>
        /// Gives the abosolute value of the integer
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Returns the Absolute Value of the number</returns>
        public static int AbsoluteValue(int x)
        {
            return -x;
        }
        /// <summary>
        /// Gives the total of the Base Integer by the power of the Power Integer
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Power"></param>
        /// <returns>Returns the Base number to the power of the Power number</returns>
        public static int Power(int Base, int Power)
        {
            int total = Base;
            for (int n = 2; n <= Power; n++)
            {
                total = total * Base;
            }
            return total;
        }
        public static int MultiStepAll(int v, int w, int x, int y, int z)
        {
            return v + w - x / y * z;
        }
        public static int MultiStepAddSubtract(int x, int y, int z)
        {
            return x + y - z;
        }
        public static int MultiStepDivideMultiply(int x, int y, int z)
        {
            return x / y * z;
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
        public static double MultiStepAll(double v, double w, double x, double y, double z)
        {
            return v + w - x / y * z;
        }
        public static double MultiStepAddSubtract(double x, double y, double z)
        {
            return x + y - z;
        }
        public static double MultiStepDivideMultiply(double x, double y, double z)
        {
            return x / y * z;
        }
        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float Subtract(float x, float y)
        {
            return x - y;
        }
        public static float Divide(float x, float y)
        {
            return x / y;
        }
        public static float Multiply(float x, float y)
        {
            return x * y;
        }
        public static float Min(float x, float y)
        {
            float Min = 0;
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
        public static float Max(float x, float y)
        {
            float Max = 0;
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
        public static float AbsoluteValue(float x)
        {
            return -x;
        }
        public static float Power(float Base, float Power)
        {
            float total = Base;
            for (float n = 2; n <= Power; n++)
            {
                total = total * Base;
            }
            return total;
        }
        public static float MultiStepAll(float v, float w, float x, float y, float z)
        {
            return v + w - x / y * z;
        }
        public static float MultiStepAddSubtract(float x, float y, float z)
        {
            return x + y - z;
        }
        public static float MultiStepDivideMultiply(float x, float y, float z)
        {
            return x / y * z;
        }
    }
}