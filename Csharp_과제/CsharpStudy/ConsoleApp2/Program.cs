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

            Zombie zombie = new Zombie();
            Ghoul ghoul = new Ghoul();

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

    //Abstract : 자식들이 정의하는거. 부모는 자식들이 옵션을 써야 한다고 정의만 하는 것. 인스턴스 할 수 없음!!!!
    abstract class DarkMonster
    {
        int attackValue = 10;

        public abstract void AttackPlayer(Player player);
  
    }

    class Zombie : DarkMonster
    {
        public override void AttackPlayer(Player player)
        {
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
