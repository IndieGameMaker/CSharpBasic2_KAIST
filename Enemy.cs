using System;

namespace EnemyManager
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
        private int hp;
        private int speed;

        //프로퍼티(Property) : 외부에 노출되는 속성(변수)
        public string Name { get; set; }

        public int Hp
        {
            get {return this.hp;}
            set {
                this.hp = value;
                
                if (this.hp <= 0)
                {
                    EnemyDie();
                }
            }
        }

        public int Speed
        {
            get {return this.speed;}
            set {
                this.speed = value;
                Console.WriteLine("P: Changed Speed");

                if (value >= 100)
                {
                    this.speed = 100;
                    Console.WriteLine("Max Speed !!");
                }

            }
        }
    
        //가상 메소드 - 상속받은 파생클래스에서 재정의 해서 사용할 수 있는 기능
        public virtual void EnemyDie()
        {
            Console.WriteLine($"P: {this.Name} is died!");
        }
    }    

    //파생 클래스
    public class Orc : Enemy
    {
        //생성자
        public Orc()
        {
            this.Name  = "Orc Warrior";
            this.Hp    = 100;
            this.Speed = 5;
        }

        public override void EnemyDie()
        {
            base.EnemyDie();
            Console.WriteLine($"{Name} 사망 = 보석 200");
        }
    }

    //파생클래스
    public class Goblin : Enemy
    {
        //생성자(Constructor)
        public Goblin(string _Name, int _Hp, int _Speed)
        {
            this.Name  = _Name;
            this.Hp    = _Hp;
            this.Speed = _Speed;
        }

        public override void EnemyDie()
        {
            //base.EnemyDie();
            Console.WriteLine($"{Name} 사망 보석 = 50");
        }
    }
}