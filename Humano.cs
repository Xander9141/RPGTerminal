
class Humano{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;


    //Metodo

    public Humano(string n, int s, int i, int d, int h) {
        Name = n;
        Strength = s;
        Intelligence = i;
        Dexterity = d;
        Health = h;
    }

    


    public virtual int Attack(Enemy target)
    {
        int damage = 3 * Strength; // Calcula el daño basado en la fuerza del atacante
        target.Health -= damage;   // Reduce la salud del objetivo según el daño
        return target.Health;      // Devuelve la salud restante del objetivo
    }
}