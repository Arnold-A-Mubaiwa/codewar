using CodeWarsExercises.Katas;
using CodeWarsExercises.Rank_Up;

namespace UnitTests;

public static class Integration
{
    [Fact]
    public static void ShouldCheckIfItsInJaden()
    {
        var changeCase = "How can mirrors be real if our eyes aren't real".MakeJadenCase();
        Assert.Equal("How Can Mirrors Be Real If Our Eyes Aren't Real",
            changeCase);
    }

    [Fact]
    public static void ShouldDisplayAGreetingStatement()
    {
        var greet = GreetingStatement.Greet("Arnold");
        Assert.Equal("Hello, Arnold how are you doing today?",greet);
    }

    [Theory]
    [InlineData(new[] { 2, 3 }, 5)]
    [InlineData(new[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75)]
    [InlineData(new[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69)]
    public static void ShouldCalculateAverage(int[] grades, int yourGrade)
    {
        var greater = BetterThanAverage.BetterThanAverageClass(grades, yourGrade);
        Assert.True(greater);
    }

    [Theory]
    [InlineData(155, -1)]
    [InlineData(121, 144)]
    [InlineData(625, 676)]
    [InlineData(319225, 320356)]
    [InlineData(15241383936, 15241630849)]
    public static void ShouldGetNextSquare(long number, long expected)
    {
        var nextSquare = FindNextSquare.NextSquare(number);
        Assert.Equal( expected, nextSquare);
    }

    [Theory]
    [InlineData(true, "Yes")]
    [InlineData(false, "No")]
    public static void ShouldGetBoolInWords(bool word, string expected)
    {
        var boolWord = BoolToWords.BoolToWord(word);
        Assert.Equal(expected, boolWord);
    }

    [Fact]
    public static void ShouldCountNumberOfSheep()
    {
        bool[] sheep = 
        [
            true, true, true, false, true, true, true, true, true, false, true, false, true, false, false, true, true,
            true, true, true, false, false, true, true
        ];
        
        var numberOfSheep = ArrayCount.CountSheep(sheep);
        Assert.Equal(17 ,numberOfSheep);
    }

    [Fact]
    public static void ShouldFindAFriend()
    {
       // Given
       string[] expected = { "Ryan", "Mark" };
       string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
       //When
       var getFriends = FindAFriend.FriendOrFoe(names);
       //Then
       Assert.Equal(expected, getFriends);
    }

    [Theory]
    [InlineData('*', 2, 3, 6)]
    [InlineData('-', 5, 3, 2)]
    [InlineData('+', 2, 3, 5)]
    [InlineData('/', 9, 3, 3)]
    public static void ShouldDoBasicMath(char sign, double val1, double val2, double expected)
    {
        var calculate = BasicMaths.BasicOp(sign, val1, val2);
        Assert.Equal(expected, calculate);
    }

    [Theory]
    [InlineData("a a a  b  c c  d d d d  e e e e e", new [] { "e", "d", "a" })]
    [InlineData("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e", new [] { "e", "ddd", "aa" })]
    [InlineData("  //wont won't won't ", new [] { "won't", "wont" })]
    public static void ShouldTakeTheTop3(string sentence, string[] words)
    {
        var top3 = TopThree.Top3(sentence);
        Assert.Equal(words, top3);
    }

    [Fact]
    public static void ShouldCalculateAtom()
    {
        var atoms = Molecule.ParseMolecule("H2OP4");
        Assert.Equal(1, atoms["4"]);
        Assert.Equal(1, atoms["O"]);
        Assert.Equal(4, atoms["P"]);
    }
}