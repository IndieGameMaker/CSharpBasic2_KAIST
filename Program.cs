using System;
using EnemyManager;

class Program
{
    static void Main(string[] args)
    {
        Enemy orc = new Enemy();
        orc.Name = "Orc Warrior";
        Console.WriteLine($"Enemy Name is {orc.Name}");
        orc.Hp = 0;
        orc.Speed = 50;
        orc.Speed = 120;
        Console.WriteLine($"{orc.Name} speed = {orc.Speed}");


        Enemy goblin = new Enemy();
        goblin.Name = "Goblin";
        goblin.Speed = 50;
        goblin.Hp = 0;
    }
}

