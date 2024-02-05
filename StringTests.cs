using Xunit;
using GroupUtilities;

public class StringTests
{


    [Fact]
    public void ToUpperStringTestCase()
    {

        string testString = "...Hello!";
        string desiredOutcome = "...HELLO!";
        Assert.Equal(desiredOutcome, StringUtilities.ToUpper(testString));
    }

    [Fact]
    public void ToLowerStringTestCase()
    {
        string testString = "...HELLO!";
        string desiredOutcome = "...hello!";
        Assert.Equal(desiredOutcome, StringUtilities.ToLower(testString));
    }

    [Fact]
    public void LengthStringTestCase()
    {
        string testString = "...hello!";
        int desiredOutcome = 9;
        Assert.Equal(desiredOutcome, StringUtilities.Length(testString));
    }

    [Fact]
    public void ReverseStringTestCase()
    {
        string testString = "woah!";
        string desiredOutcome = "!haow";
        Assert.Equal(desiredOutcome, StringUtilities.Reverse(testString));
    }
    
    [Fact]
    public void CountVowelsStringTestCase()
    {
        string testString = "...hello!";
        int desiredOutcome = 2;
        Assert.Equal(desiredOutcome, StringUtilities.CountVowels(testString));
    }

    [Fact]
    public void CountConsonantsStringTestCase()
    {
        string testString = "...hello!";
        int desiredOutcome = 3;
        Assert.Equal(desiredOutcome, StringUtilities.CountConsonants(testString));
    }

    [Fact]
    public void HasLetterStringTestCase()
    {
        string testString = "...hello!";
        char testChar = 'o';
        bool desiredOutcome = true;
        Assert.Equal(desiredOutcome, StringUtilities.HasLetter(testString, testChar));
    }

    [Fact]
    public void RemoveNullSpaceStringTestCase()
    {
        string testString = " h e l l o ";
        string desiredOutcome = "hello";
        Assert.Equal(desiredOutcome, StringUtilities.RemoveNullSpace(testString));
    }

    [Fact]
    public void AddPunctuationStringTestCase()
    {
        string testString = "hello";
        string desiredOutcome = "hello.";
        Assert.Equal(desiredOutcome, StringUtilities.AddPunctuation(testString));
    }

    [Fact]
    public void RemoveNumbersStringTestCase()
    {
        string testString = "1hello112!";
        string desiredOutcome = "hello!";
        Assert.Equal(desiredOutcome, StringUtilities.RemoveNumbers(testString));
    }

}