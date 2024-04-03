namespace CodeWarsExercises.Services;

public static class ToJadenCase
{
    public static string MakeJadenCase( this string phrase)
     => phrase.Split(' ')
         .Aggregate("", (current, word) => current + (word[0].ToString().ToUpper() + word.Substring(1) + ' '))
         .TrimEnd();
}