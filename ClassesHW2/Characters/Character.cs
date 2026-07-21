namespace ThemePreview;

public abstract class Character : IAttack
{
    public string Name { get; set; }

    public int Level { get; set; }

    public int Health { get; set; }

    public CharacterClass Class { get; init; }

    protected Character(string name, CharacterClass characterClass)
    {
        Name = name;
        Class = characterClass;
        Level = 1;
        Health = 100;
    }

    public virtual void LevelUp()
    {
        Level++;
        Health += 25;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Name} reached level {Level}!");
        Console.ResetColor();
    }

    public abstract int Attack();
}