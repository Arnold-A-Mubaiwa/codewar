using System.Text.RegularExpressions;

namespace CodeWarsExercises.Rank_Up;

using System.Collections.Generic;
using System.Linq;

public static partial class TopThree
{
    public static List<string> Top3(string sentence)
    {
        var words = SplitSentenceUsingSpecialChar().Split(sentence).ToList();;
        words.RemoveAll(word=> word.Equals(" ")||word.Equals("")||word.Equals("  ")||word.Equals("   "));

        var wordCount = new Dictionary<string, int>();
        foreach (var word in words)
        {
            var newWord = CheckIfWordHasChars().Replace(word, "");
            if (newWord is not (" " or ""))
            {
                if (!wordCount.TryAdd(newWord.ToLower(), 1))
                {
                    wordCount[newWord.ToLower()] += 1;
                }
            }
        }

        var top3 = wordCount
            .OrderByDescending(key => key.Value)
            .ThenByDescending(key => key.Key)
            .Select(wordNumber => wordNumber.Key)
            .Where(w=>!MyRegex().IsMatch(w)).ToList();

        return top3.Take(3).ToList();
    }

    [GeneratedRegex(@"^[^0-9a-zA-Z]+$")]
    private static partial Regex MyRegex();
    
    [GeneratedRegex(@"[^0-9a-zA-Z']+|[/]")]
    private static partial Regex CheckIfWordHasChars();
    
    [GeneratedRegex("[^a-zA-Z0-9']+")]
    private static partial Regex SplitSentenceUsingSpecialChar();
}