using System;
using System.Collections.Generic;

class Program
{
    static Random random = new Random();
    static List<Humano> allies = new List<Humano>();
    static List<Enemy> enemies = new List<Enemy>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Crear Aliado");
            Console.WriteLine("2. Crear Enemigo");
            Console.WriteLine("3. Ver Personajes");
            Console.WriteLine("4. Jugar");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Opción inválida. Introduce un número.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateAlly();
                    break;
                case 2:
                    CreateEnemy();
                    break;
                case 3:
                    ShowCharacters();
                    break;
                case 4:
                    Play();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del menú...");
                    return;
                default:
                    Console.WriteLine("Opción no reconocida. Introduce un número del 1 al 5.");
                    break;
            }
        }
    }


    static void CreateAlly()
    {
        Console.WriteLine("Elige el tipo de aliado:");
        Console.WriteLine("1. Ninja");
        Console.WriteLine("2. Samurai");
        Console.WriteLine("3. Mago");
        Console.Write("Elige un aliado: ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Opción inválida. Introduce un número.");
            return;
        }

        Console.Write("Introduce el nombre del aliado: ");
        string name = Console.ReadLine();

        int health = random.Next(80, 200);
        int strength = random.Next(1, 20);
        int intelligence = random.Next(1, 10);
        int dexterity = random.Next(1, 10);

        switch (choice)
        {
            case 1:
            Ninja ninjaAlly = new Ninja(name, strength, intelligence, dexterity, health);
            Console.WriteLine("Ninja creado: " + name);
            allies.Add(ninjaAlly); // Agregar el Ninja a la lista de aliados
            break;
        case 2:
            Samurai samuraiAlly = new Samurai(name, strength, intelligence, dexterity, health);
            Console.WriteLine("Samurai creado: " + name);
            allies.Add(samuraiAlly); // Agregar el Samurai a la lista de aliados
            break;
        case 3:
            Mago magoAlly = new Mago(name, strength, intelligence, dexterity, health);
            Console.WriteLine("Mago creado: " + name);
            allies.Add(magoAlly); // Agregar el Mago a la lista de aliados
            break;
            default:
                Console.WriteLine("Opción no reconocida. Introduce 1, 2 o 3.");
                break;
        }
    }

    static void CreateEnemy()
    {
        Console.WriteLine("Elige el tipo de enemigo:");
        Console.WriteLine("1. Zombie");
        Console.WriteLine("2. Spider");
        Console.Write("Elige un enemigo: ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Opción inválida. Introduce un número.");
            return;
        }

        Console.Write("Introduce el nombre del enemigo: ");
        string name = Console.ReadLine();

        int health = random.Next(1, 200);
        int strength = random.Next(1, 20);
        int intelligence = random.Next(1, 10);
        int dexterity = random.Next(1, 10);

        switch (choice)
        {
            case 1:
            Zombie zombieEnemy = new Zombie(name, strength, intelligence, dexterity, health);
            Console.WriteLine("Zombie creado: " + name);
            enemies.Add(zombieEnemy); // Agregar el Zombie a la lista de enemigos
            break;
        case 2:
            Spider spiderEnemy = new Spider(name, strength, intelligence, dexterity, health);
            Console.WriteLine("Spider creado: " + name);
            enemies.Add(spiderEnemy); // Agregar la Spider a la lista de enemigos
            break;
            default:
                Console.WriteLine("Opción no reconocida. Introduce 1 o 2.");
                break;
        }
    }

    static void ShowCharacters()
    {
        Console.WriteLine("Personajes Aliados:");
        foreach (var ally in allies)
        {
            Console.WriteLine($"Nombre: {ally.Name}, Fuerza: {ally.Strength}, Inteligencia: {ally.Intelligence}, Destreza: {ally.Dexterity}, Salud: {ally.Health}");
        }

        Console.WriteLine("Personajes Enemigos:");
        foreach (var enemy in enemies)
        {
            Console.WriteLine($"Nombre: {enemy.Name}, Fuerza: {enemy.Strength}, Inteligencia: {enemy.Intelligence}, Destreza: {enemy.Dexterity}, Salud: {enemy.Health}");
        }
    }


    static void Play()
{
    static bool AllAlliesDefeated(List<Humano> allies)
    {
        return allies.All(ally => ally.Health <= 0);
    }

    static bool AllEnemiesDefeated(List<Enemy> enemies)
    {
        return enemies.All(enemy => enemy.Health <= 0);
    }

    if (allies.Count == 0 || enemies.Count == 0)
    {
        Console.WriteLine("Necesitas crear al menos un aliado y un enemigo para jugar.");
        return;
    }

    int turn = 1;

    while (true)
    {
        Console.WriteLine($"Turno {turn}");

        // Turno de los aliados
        foreach (var ally in allies)
        {
            if (ally.Health > 0)
            {
                Console.WriteLine($"Turno de {ally.Name} (Aliado)");

                Console.WriteLine("Selecciona el ataque para " + ally.Name + ":");
                Console.WriteLine("1. Ataque básico");
                Console.WriteLine("2. Ataque especial");

                if (!int.TryParse(Console.ReadLine(), out int attackChoice))
                {
                    Console.WriteLine("Opción inválida. Introduce un número.");
                    return;
                }

                Enemy targetEnemy = enemies[random.Next(enemies.Count)]; // Obtiene un enemigo aleatorio

                switch (attackChoice)
                {
                    case 1:
                        ally.Attack(targetEnemy);
                        break;
                    case 2:
                        if (ally is Ninja)
                        {
                            ((Ninja)ally).StealthAttack(targetEnemy);
                        }
                        else if (ally is Samurai)
                        {
                            ((Samurai)ally).DrawCut(targetEnemy);
                        }
                        else if (ally is Mago)
                        {
                            ((Mago)ally).Fireball(targetEnemy);
                        }
                        else
                        {
                            Console.WriteLine("El aliado no puede realizar un ataque especial.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no reconocida. Se realizará un ataque básico.");
                        ally.Attack(targetEnemy);
                        break;
                }
            }
        }

        // Turno de los enemigos
        foreach (var enemy in enemies)
        {
            if (enemy.Health > 0)
            {
                Console.WriteLine($"Turno de {enemy.Name} (Enemigo)");

                Humano targetAlly = allies[random.Next(allies.Count)]; // Obtiene un aliado aleatorio
                enemy.Attack(targetAlly);
            }
        }

        // Verifica si algún bando ha sido derrotado
        if (AllAlliesDefeated(allies))
        {
            Console.WriteLine("¡Los aliados han sido derrotados! Los enemigos ganan.");
            break;
        }

        if (AllEnemiesDefeated(enemies))
        {
            Console.WriteLine("¡Los enemigos han sido derrotados! Los aliados ganan.");
            break;
        }

        turn++;
    }
}



}