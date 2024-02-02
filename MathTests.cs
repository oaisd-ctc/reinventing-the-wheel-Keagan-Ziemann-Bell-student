using GroupUtilities;
using Xunit;
public class MathTests
{
    [Fact]
    public void TestRun()
    {
        Assert.Equal(5, MathUtilities.Add(2, 3));
    }
    [Fact]
    public void TestRun2()
    {
        Assert.Equal(2, MathUtilities.Subtract(5, 3));
    }
    [Fact]
    public void TestRun3()
    {
        Assert.Equal(2, MathUtilities.Divide(6, 3));
    }
    [Fact]
    public void TestRun4()
    {
        Assert.Equal(6, MathUtilities.Multiply(2, 3));
    }
    [Fact]
    public void TestRun5()
    {
        Assert.Equal(3, MathUtilities.Min(3, 4));
    }
    [Fact]
    public void TestRun6()
    {
        Assert.Equal(4, MathUtilities.Max(3, 4));
    }[Fact]
    public void TestRun7()
    {
        Assert.Equal(-6, MathUtilities.AbsoluteValue(6));
    }
    [Fact]
    public void TestRun8()
    {
        Assert.Equal(32, MathUtilities.Power(2, 5));
    }
}