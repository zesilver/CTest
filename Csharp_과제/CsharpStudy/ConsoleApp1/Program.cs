using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            DarkMonter darkmonster = new DarkMonter();
            LightMonster lightmonster = new LightMonster();


           player.AttackMonster(darkmonster);
           player.AttackMonster(lightmonster);
        }
    }

    interface monster
    {
        void HitFromPlayer(int damage); //몬스터의 기본정보, 이 값은 바꾸지 않아도 된다.
    }

    class DarkMonter : monster
    {
        int hp = 100;  //다크몬스터의 정의

        public void HitFromPlayer(int damage)
        {
            hp = hp - damage;
            System.Console.WriteLine($"Monster : I'm Hit! my Hp is {hp}");
        }
    }

    class LightMonster : monster
    {
        int hp = 100;

        public void HitFromPlayer(int damage)
        {
            hp = hp - (damage / 2);
            System.Console.WriteLine($"LightMonster : I'm Hit! but half, my Hp is {hp}");
        }
    }

    class Player
    {
        int AttackDamage = 15;

        public void AttackMonster(monster monster) //플레이어 입장에서 몬스터의 종류와 상관없이 데미지를 준다 여기서 monster는 인터페이스의 monster
        {
            System.Console.WriteLine("Player : i'm Attacking Monster!");
            monster.HitFromPlayer(AttackDamage);
        }
    }
}
