namespace CodeWarsExercises.Katas;

public static class BetterThanAverage
{
    public static bool BetterThanAverageClass(int[] classPoints, int yourPoints)
    {
        return classPoints.Sum() / classPoints.Length < yourPoints;
    }
}