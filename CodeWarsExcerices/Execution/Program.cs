using CodeWarsExercises.Katas;
using CodeWarsExercises.Rank_Up;

Console.WriteLine("How can mirrors be real if our eyes aren't real".MakeJadenCase());

Console.WriteLine(GreetingStatement.Greet("Arnold"));

Console.WriteLine(BetterThanAverage.BetterThanAverageClass([2,3], 5));

Console.WriteLine(GreetingStatement.Greet("Arnold").MakeJadenCase());

Console.WriteLine(FindNextSquare.NextSquare(144));

var value = ConvertNumberToString.NumberToString(11);
Console.WriteLine(value.GetType());

Console.WriteLine(BoolToWords.BoolToWord(true)+"\n");

/*
var words = TopThree.Top3(
    "In a village of La Mancha, the name of which I have no desire to call to, mind, there lived not long since one of those gentlemen that keep a lance, in the lance-rack, an old buckler, a lean hack, and a greyhound for, coursing. An olla of rather more beef than mutton, a salad on most, nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra, on Sundays, made away with three-quarters of his income.");*/

var words = TopThree.Top3("  , e   .. ");
var count = 0;
foreach (var word in words)
{
    count++;
    Console.WriteLine(count + " " + word);
}