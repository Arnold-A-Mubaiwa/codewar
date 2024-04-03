namespace CodeWarsExercises.Services;

public static class BetterThanAverage
{
    public static bool BetterThanAverageClass(int[] classPoints, int yourPoints)
         => classPoints.Sum() / classPoints.Length < yourPoints;
}