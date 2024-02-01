using System;
using GroupUtilities;
public class Program {
public static void Main(string[] args) {
Console.WriteLine(ArrayUtilities.Average(new int[] {8, 2, 7, 4, 5, 6}));
Console.WriteLine(ArrayUtilities.Average(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.0}));
Console.WriteLine(ArrayUtilities.Max(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.3}));
Console.WriteLine(ArrayUtilities.Max(new int[] {1, 2, 3, 4, 5, 6}));
Console.WriteLine(ArrayUtilities.Min(new int[] {1, 2, 3, 4, 5, 6}));
Console.WriteLine(ArrayUtilities.Min(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.3}));
int[] result = ArrayUtilities.SortAscending(new int[] {3124, 62,6, 4, 2, 3, 7,2, 78});
Console.WriteLine(string.Join(", ", result));
double[] result3 = ArrayUtilities.SortAscending(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.3});
Console.WriteLine(string.Join(", ", result3));
int[] result2 = ArrayUtilities.SortDescending(new int[] {3124, 62,6, 4, 2, 3, 7,2, 78});
Console.WriteLine(string.Join(", ", result2));
double[] result4 = ArrayUtilities.SortDescending(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.3});
Console.WriteLine(string.Join(", ", result4));
Console.WriteLine(ArrayUtilities.Sum(new int[] {1, 2, 3, 4, 5, 6}));
Console.WriteLine(ArrayUtilities.Sum(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.0}));
Console.WriteLine(ArrayUtilities.Product(new int[] {8, 2, 7, 4, 5, 6}));
Console.WriteLine(ArrayUtilities.Product(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.0}));
int[] result5 = ArrayUtilities.SetAllMin(new int[] {3124, 62,6, 4, 2, 3, 7,2, 78, 1});
Console.WriteLine(string.Join(", ", result5));
double[] result6 = ArrayUtilities.SetAllMin(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.0});
Console.WriteLine(string.Join(", ", result6));
int[] result7 = ArrayUtilities.SetAllMax(new int[] {3124, 62,6, 4, 2, 3, 7,2, 78, 1});
Console.WriteLine(string.Join(", ", result7));
double[] result8 = ArrayUtilities.SetAllMax(new double[] {1.1, 2.5, 3.0, 4.0, 5.0, 6.5});
Console.WriteLine(string.Join(", ", result8));
Console.WriteLine(ArrayUtilities.AbsoluteValue(new int[] {-1, 2, -3, 4, -5, -6}));
Console.WriteLine(ArrayUtilities.AbsoluteValue(new double[] {1.1, 2.5, -3.0, 4.0, -5.0, -6.0}));
}
}
