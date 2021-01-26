using System;
using EnemyManager;

class Program
{
    static void Main(string[] args)
    {
        Orc orc = new Orc();
        orc.Hp = 0;

        Goblin goblin = new Goblin("Goblin", 10, 20);
        goblin.Hp = 0;

    }
}