using CodeWarsExercises.Katas;

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
}