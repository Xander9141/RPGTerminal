class Ninja : Humano
{
    public Ninja(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
    {

    }

    public override int Attack(Enemy target)
    {
        int damage = Dexterity;
        Random random = new Random();
        if (random.Next(1, 101) <= 20)
        {
            damage += 10; // Añade 10 puntos de daño si el 20% de probabilidad es verdadero
        }
        target.Health -= damage; // Reduce la salud del objetivo
        Console.WriteLine($"{Name} atacó a {target.Name} y causó {damage} puntos de daño.");
        return target.Health;
    }

    public void StealthAttack(Enemy target)
    {
        int damage = 2 * Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} ejecutó un ataque sigiloso a {target.Name} causando {damage} puntos de daño.");
    }

    public void PoisonAttack(Enemy target)
    {
        int damage = Intelligence + 2 * Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} envenenó a {target.Name} y le hizo {damage} puntos de daño.");
    }

    public void ShadowStrike(Enemy target)
    {
        int damage = 3 * Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} realizó un golpe desde las sombras a {target.Name}, causando {damage} puntos de daño.");
    }

    public void PrecisionStrike(Enemy target)
    {
        Random random = new Random();
        int damage = (random.Next(1, 101) <= 30) ? 4 * Dexterity : 0;
        target.Health -= damage;
        Console.WriteLine($"{Name} efectuó un golpe preciso a {target.Name}, infligiendo {damage} puntos de daño.");
    }
}