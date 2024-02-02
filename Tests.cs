using Xunit;
using GroupUtilities;

public class Tests {

    [Fact]

    public void Test_Case_Sort_Ascending_Int() {
        int[] testArray = {1,5,2,3,7};
        int[] desiredOutcome = {1, 2, 3, 5, 7};
        Assert.Equal(desiredOutcome, ArrayUtilities.SortAscending(testArray));
    }
    [Fact]
    public void Test_Case_Sort_Ascending_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double[] desiredOutcome = {1.1, 2.5, 3.5, 5.2, 7.2};
        Assert.Equal(desiredOutcome, ArrayUtilities.SortAscending(testArray));
    }

    [Fact]
    public void Test_Case_Average_Int() {
        int[] testArray = {1,5,2,3,7};
        int desiredOutcome = (1 +5+2+3+7) / 5;
        Assert.Equal(desiredOutcome, ArrayUtilities.Average(testArray));
    }

    [Fact]
    public void Test_Case_Average_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double desiredOutcome = (1.1 +5.2+2.5+3.5+7.2) / 5;
        Assert.Equal(desiredOutcome, ArrayUtilities.Average(testArray));
    }

    [Fact]
    public void Test_Case_Max_Int() {
        int[] testArray = {1,5,2,3,7};
        int desiredOutcome = 7;
        Assert.Equal(desiredOutcome, ArrayUtilities.Max(testArray));
    }

    [Fact]
    public void Test_Case_Max_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double desiredOutcome = 7.2;
        Assert.Equal(desiredOutcome, ArrayUtilities.Max(testArray));
    }

    [Fact]
    public void Test_Case_Min_Int() {
        int[] testArray = {1,5,2,3,7};
        int desiredOutcome = 1;
        Assert.Equal(desiredOutcome, ArrayUtilities.Min(testArray));
    }

    [Fact]
    public void Test_Case_Min_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double desiredOutcome = 1.1;
        Assert.Equal(desiredOutcome, ArrayUtilities.Min(testArray));
    }

    [Fact]

    public void Test_Case_Sort_Descending_Int() {
        int[] testArray = {1,5,2,3,7};
        int[] desiredOutcome = {7,5,3,2,1};
        Assert.Equal(desiredOutcome, ArrayUtilities.SortDescending(testArray));
    }
    [Fact]
    public void Test_Case_Sort_Descending_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double[] desiredOutcome = {7.2,5.2,3.5,2.5,1.1};
        Assert.Equal(desiredOutcome, ArrayUtilities.SortDescending(testArray));
    }

    [Fact]
    public void Test_Case_Sum_Int() {
        int[] testArray = {1,5,2,3,7};
        int desiredOutcome = 1 +5+2+3+7;
        Assert.Equal(desiredOutcome, ArrayUtilities.Sum(testArray));
    }

    [Fact]
    public void Test_Case_Sum_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double desiredOutcome = 1.1 +5.2+2.5+3.5+7.2;
        Assert.Equal(desiredOutcome, ArrayUtilities.Sum(testArray));
    }

    [Fact]
    public void Test_Case_Product_Int() {
        int[] testArray = {1,5,2,3,7};
        int desiredOutcome = 1*5*2*3*7;
        Assert.Equal(desiredOutcome, ArrayUtilities.Product(testArray));
    }

    [Fact]
    public void Test_Case_Product_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double desiredOutcome = 1.1*5.2*2.5*3.5*7.2;
        Assert.Equal(desiredOutcome, ArrayUtilities.Product(testArray));
    }

    [Fact]

    public void Test_Case_Set_All_Min_Int() {
        int[] testArray = {1,5,2,3,7};
        int[] desiredOutcome = {1,1,1,1,1};
        Assert.Equal(desiredOutcome, ArrayUtilities.SetAllMin(testArray));
    }
    [Fact]
    public void Test_Case_Set_All_Min_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double[] desiredOutcome = {1.1,1.1,1.1,1.1,1.1};
        Assert.Equal(desiredOutcome, ArrayUtilities.SetAllMin(testArray));
    }

    [Fact]

    public void Test_Case_Set_All_Max_Int() {
        int[] testArray = {1,5,2,3,7};
        int[] desiredOutcome = {7,7,7,7,7};
        Assert.Equal(desiredOutcome, ArrayUtilities.SetAllMax(testArray));
    }
    [Fact]
    public void Test_Case_Set_All_Max_Double() {
        double[] testArray = {1.1,5.2,2.5,3.5,7.2};
        double[] desiredOutcome = {7.2, 7.2, 7.2, 7.2, 7.2};
        Assert.Equal(desiredOutcome, ArrayUtilities.SetAllMax(testArray));
    }

    [Fact]
    public void Test_Case_Absolute_Value_Int() {
        int[] testArray = {1,-5,2,-3,-7};
        int desiredOutcome = 1 +5+2+3+7;
        Assert.Equal(desiredOutcome, ArrayUtilities.AbsoluteValue(testArray));
    }

    [Fact]
    public void Test_Case_Absolute_Value_Double() {
        double[] testArray = {-1.1,-5.2,2.5,-3.5,7.2};
        double desiredOutcome = 1.1 +5.2+2.5+3.5+7.2;
        Assert.Equal(desiredOutcome, ArrayUtilities.AbsoluteValue(testArray));
    }


}