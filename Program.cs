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
        //멤버 - 필드(Field) : OOP 인닉성 특징
        private string name;
        private int hp = 100;
        private int speed = 10;

        //프로퍼티(Property) : 외부에 노출되는 속성(변수)
        public string Name
        {
            get {return this.name;}
            set {this.name = value;}
        }

        public int Hp
        {
            get {return this.hp;}
            set {
                this.hp = value;
                
                if (this.hp <= 0)
                {
                    Console.WriteLine($"{this.name} is died!");
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



            Enemy goblin = new Enemy();
        }
    }
}
