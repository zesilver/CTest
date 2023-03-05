using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            DarkMonster dark = new DarkMonster();
            Zombie zombie = new Zombie();
            Ghoul ghoul = new Ghoul();

            dark.AttackPlayer(player);
            System.Console.WriteLine();

            zombie.AttackPlayer(player);
            System.Console.WriteLine();

            ghoul.AttackPlayer(player);
            System.Console.WriteLine();
        }
    }

    class Player
    {
        int hp = 100;
        public void HitFromMonster(int AttackValue)
        {
            hp = hp - AttackValue;
            System.Console.WriteLine($"Player : I'm Hit! my Hp is {hp}");
        }
    }

    class DarkMonster
    {
        int attackValue = 10;

        public virtual void AttackPlayer(Player player)
        {
            System.Console.WriteLine("Monster : Player Attack!");
            player.HitFromMonster(attackValue);
        }
    }

    class Zombie : DarkMonster
    {
        public override void AttackPlayer(Player player)
        {
            base.AttackPlayer(player); //부모의 내용을 실행할거다
            System.Console.WriteLine("Monste(Zombie) : Player Bleeding!");
        }
    }

    class Ghoul : DarkMonster
    {
        public override void AttackPlayer(Player player)
        {
            System.Console.WriteLine("Monster(Ghoul) : Player Curse!");
        }
    }

}
