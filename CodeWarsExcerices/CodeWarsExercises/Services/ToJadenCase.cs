namespace CodeWarsExercises.Services;

public static class ToJadenCase
{
    public static string MakeJadenCase( this string phrase)
    {
        var sentence = "";
        foreach (var word in phrase.Split(' '))
        {
            sentence += word[0].ToString().ToUpper() + word.Substring(1)+ ' ';
        }
        return sentence.TrimEnd();
    }
}