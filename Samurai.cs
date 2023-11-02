class Samurai : Humano
{
    public Samurai(string name, int strength, int intelligence, int dexterity, int health) : base(name, strength, intelligence, dexterity, health)
    {

    }

    public override int Attack(Enemy target)
    {
        base.Attack(target); // Llamada al método base de Attack en la clase Humano

        if (target.Health < 50)
        {
            target.Health = 0; // Reducir la salud del objetivo a 0 si tiene menos de 50 puntos de salud
            Console.WriteLine($"{Name} atacó a {target.Name} y redujo su salud a 0.");
        }

        return target.Health;
    }

    public void Meditate(){
        this.Health = 200;
    }

    public void DrawCut(Enemy target)
    {
        int damage = Strength + Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} ejecutó un corte preciso en {target.Name}, infligiéndole {damage} puntos de daño.");
    }

    public void CounterAttack(Enemy target)
    {
        int damage = Dexterity + 3;
        target.Health -= damage;
        Console.WriteLine($"{Name} respondió con un contraataque a {target.Name}, causándole {damage} puntos de daño.");
    }

    public void SwiftStrike(Enemy target)
    {
        int damage = 2 * Dexterity;
        target.Health -= damage;
        Console.WriteLine($"{Name} realizó un golpe veloz a {target.Name}, haciendo {damage} puntos de daño.");
    }

    public void FocusStance()
    {
        Strength += 3;
        Console.WriteLine($"{Name} ha adoptado una postura de enfoque, aumentando su fuerza en 3 puntos.");
    }

}