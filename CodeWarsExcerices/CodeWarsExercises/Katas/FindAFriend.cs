namespace CodeWarsExercises.Katas;

public static class FindAFriend
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
        => names.Where(name => name.Length == 4).ToList();
}