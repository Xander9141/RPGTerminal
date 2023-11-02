class Mago : Humano
{
    public Mago(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
    {

    }

    public override int Attack(Enemy target)
    {
        int damage = Intelligence * 3;
        target.Health -= damage;
        Health += damage; // Sanar el Mago por el daño infligido
        Console.WriteLine($"{Name} atacó a {target.Name} y causó {damage} puntos de daño. El Mago se curó {damage} puntos de salud.");
        return target.Health;
    }

    public void Heal(Humano target)
    {
        if (target != null && target is Humano)
        {
            target.Health += Intelligence * 3;
            Console.WriteLine($"{Name} ha curado a {target.Name} por {Intelligence * 3} puntos de salud.");
        }
        else
        {
            Console.WriteLine("El objetivo no es válido para curación.");
        }


    }

    public void Fireball(Enemy target)
    {
        int damage = 2 * Intelligence;
        target.Health -= damage;
        Console.WriteLine($"{Name} lanzó una bola de fuego a {target.Name} infligiendo {damage} puntos de daño.");
    }

    public void FrostNova(Enemy target)
    {
        int damage = Intelligence + Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} desató una Nova de Escarcha sobre {target.Name}, causándole {damage} puntos de daño.");
    }

    public void ArcaneBlast(Enemy target)
    {
        int damage = 3 * Intelligence;
        target.Health -= damage;
        Console.WriteLine($"{Name} invocó una Explosión Arcana a {target.Name}, causándole {damage} puntos de daño.");
    }

    public void SupportHeal(Humano target)
    {
        if (target != null && target is Humano)
        {
            target.Health += 2 * Intelligence;
            Console.WriteLine($"{Name} ha otorgado apoyo curativo a {target.Name}, sanándolo por {2 * Intelligence} puntos de salud.");
        }
        else
        {
            Console.WriteLine("El objetivo no es válido para curación.");
        }
    }
}