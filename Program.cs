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
        private string name = "Orc";
        private int hp = 100;
        private int speed = 10;

        //프로퍼티(Property) : 외부에 노출되는 속성(변수)
        public string Name
        {
            get {return name;}
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Enemy orc = new Enemy();
            Console.WriteLine($"Enemy Name is {orc.Name}");

            Enemy goblin = new Enemy();
        }
    }
}
