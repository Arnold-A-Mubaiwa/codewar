namespace CodeWarsExercises.Katas;

public static class ToJadenCase
{
    public static string MakeJadenCase( this string phrase)
    {
        return phrase.Split(' ')
            .Aggregate("", (current, word) => string.Concat(current, word[0].ToString().ToUpper(), word.AsSpan(1), " "))
            .TrimEnd();
    }
}