class Enemy {
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    public Enemy(string name, int strength, int intelligence, int dexterity, int health) {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health =health;
    }

    public virtual int Attack(Humano target) {
        int damage = 3 * Strength; // Calcula el daño basado en la fuerza del atacante
        target.Health -= damage;   // Reduce la salud del objetivo según el daño
        return target.Health;      // Devuelve la salud restante del objetivo
    }
}