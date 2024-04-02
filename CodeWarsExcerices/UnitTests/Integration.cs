using ToUperCase.Services;

namespace UnitTests;

public static class Integration
{
    [Fact]
    public static void ShouldCheckIfItsInJaden()
    {
        var changeCase = ToJadenCase.MakeJadenCase("How can mirrors be real if our eyes aren't real");
        Assert.Equal("How Can Mirrors Be Real If Our Eyes Aren't Real",
            changeCase);
    }
}