namespace CodeWarsExercises.Katas;

public static class FindNextSquare
{
    public static long NextSquare(long number)
    {
        return Math.Sqrt(number) % (long)Math.Sqrt(number) > 0 ? -1 : (long)Math.Pow(Math.Sqrt(number) + 1, 2);
    }
}