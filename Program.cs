using System;
using GroupUtilities;
public class Program {
public static void Main(string[] args) {
Console.WriteLine(ArrayUtilities.Average(new int[] {1, 2, 3, 4, 5, 6}));
Console.WriteLine(ArrayUtilities.Max(new int[] {1, 2, 3, 4, 5, 6}));
Console.WriteLine(ArrayUtilities.Min(new int[] {1, 2, 3, 4, 5, 6}));
int[] result = ArrayUtilities.SortAscending(new int[] {1, 2, 3, 4, 5, 6});
Console.WriteLine(string.Join(", ", ArrayUtilities.arrayRes));

}
}
