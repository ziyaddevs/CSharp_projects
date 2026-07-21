namespace ThemePreview;

public class Hero : Character

{
    public List<Item> Inventory { get; } = new();

    public Hero(string name, CharacterClass characterClass)
        : base(name, characterClass)
    {
    }

    public override int Attack()
    {
        Random random = new();

        int damage = random.Next(10, 35);

        Console.WriteLine($"{Name} attacks for {damage} damage.");

        return damage;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);

        Console.WriteLine($"Picked up {item.Name} worth {item.Value} gold.");
    }
}