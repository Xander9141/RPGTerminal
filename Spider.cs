class Spider : Enemy
{

    public Spider(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
    {

    }

    public override int Attack(Humano target)
    {
        int damage = 4 * Strength; // Por ejemplo, la araña hace más daño
        target.Health -= damage;
        return target.Health;
    }

    public int PoisonAttack(Humano target)
    {
        int damage = 3 * Intelligence;
        target.Health -= damage;
        Console.WriteLine($"{Name} la araña envenenó a {target.Name} y le causó {damage} puntos de daño por veneno.");
        return target.Health;
    }

    public int WebAttack(Humano target)
    {
        int damage = 2 * Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} la araña envolvió a {target.Name} en telaraña y le causó {damage} puntos de daño.");
        return target.Health;
    }

    public int BiteAttack(Humano target)
    {
        int damage = 5 * Strength;
        target.Health -= damage;
        Console.WriteLine($"{Name} la araña mordió a {target.Name} y le causó {damage} puntos de daño.");
        return target.Health;
    }

    public int StringShot(Humano target)
    {
        int damage = 4 * Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} la araña disparó una cuerda de seda a {target.Name} y le causó {damage} puntos de daño.");
        return target.Health;
    }
}