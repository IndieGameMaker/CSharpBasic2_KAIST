using System;

namespace CSharpBasic2
{
    //클래스의 멤버(Member)
    /*
        필드
        프로퍼티
        메서트
        이벤트
    */
    public class Enemy
    {
        private int hp = 100;
        private int speed = 10;

        //프로퍼티(Property) : 외부에 노출되는 속성(변수)
        public string Name { get; set; }

        public int Hp
        {
            get {return this.hp;}
            set {
                this.hp = value;
                
                if (this.hp <= 0)
                {
                    Console.WriteLine($"{this.Name} is died!");
                }
            }
        }

        public int Speed
        {
            get {return this.speed;}
            set {
                this.speed = value;
                Console.WriteLine("Changed Speed");

                if (value >= 100)
                {
                    this.speed = 100;
                    Console.WriteLine("Max Speed !!");
                }

            }
        }
    }

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
}
