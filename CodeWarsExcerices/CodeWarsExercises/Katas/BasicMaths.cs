
namespace CodeWarsExercises.Katas;

public static class BasicMaths
{
    public static double BasicOp(char operation, double value1, double value2)
        => operation switch
        {
            '*' => value1 * value2,
            '-' => value1 - value2,
            '+' => value1 + value2,
            '/' => value1 / value2,
            _ => -1
        };

}