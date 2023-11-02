class Zombie : Enemy
{
    public Zombie(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
    {

    }

    public override int Attack(Humano target)
    {
        int damage = 2 * Strength; 
        target.Health -= damage;
        return target.Health;
    }

    public int BiteAttack(Humano target)
    {
        int damage = 4 * Strength; // El mordisco de zombie es particularmente peligroso
        target.Health -= damage;
        Console.WriteLine($"{Name} el zombie mordió a {target.Name} y le causó {damage} puntos de daño.");
        return target.Health;
    }

    public int ClawAttack(Humano target)
    {
        int damage = 3 * Strength;
        target.Health -= damage;
        Console.WriteLine($"{Name} el zombie arañó a {target.Name} y le causó {damage} puntos de daño.");
        return target.Health;
    }

    public int GrabAttack(Humano target)
    {
        int damage = 2 * Strength;
        target.Health -= damage;
        Console.WriteLine($"{Name} el zombie agarró a {target.Name} y le causó {damage} puntos de daño.");
        return target.Health;
    }

    public int LungeAttack(Humano target)
    {
        int damage = 3 * Strength;
        target.Health -= damage;
        Console.WriteLine($"{Name} el zombie se lanzó hacia {target.Name} y le causó {damage} puntos de daño.");
        return target.Health;
    }

}