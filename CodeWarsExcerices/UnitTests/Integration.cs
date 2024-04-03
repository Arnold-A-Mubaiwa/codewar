using CodeWarsExercises.Services;

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
}