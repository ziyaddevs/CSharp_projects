namespace ThemePreview;

public static class Utilities
{
    public static T Max<T>(T left, T right)
        where T : IComparable<T>
    {
        return left.CompareTo(right) > 0 ? left : right;
    }

    public static void PrintSeparator()
    {
        Console.WriteLine(new string('-', 60));
    }
}