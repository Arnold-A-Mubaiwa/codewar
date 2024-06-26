using System.Text.RegularExpressions;

namespace CodeWarsExercises.Rank_Up;

using System.Collections.Generic;
using System.Linq;

public static class TopThree
{
    public static List<string> Top3(string sentence)
    {
        var words = sentence.Split(" ").ToList();
        words.RemoveAll(word=> word.Equals(" ")||word.Equals("")||word.Equals("  ")||word.Equals("   "));

        var wordCount = new Dictionary<string, int>();
        foreach (var newWord in from word in words select Regex.Replace(word, @"[^0-9a-zA-Z']+|[/]", "") into newWord where newWord is not (" " or "") where !wordCount.TryAdd(newWord.ToLower(), 1) select newWord)
        {
            wordCount[newWord.ToLower()] += 1;
        }

        var top3 = wordCount.OrderByDescending(key => key.Value).ThenByDescending(key => key.Key).Select(wordNumber => wordNumber.Key).Where(w=>!Regex.IsMatch(w, @"^[^0-9a-zA-Z]+$")).ToList();

        return top3.Take(3).ToList();
    }
}