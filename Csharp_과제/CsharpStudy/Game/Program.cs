/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    interface Entity
    {
        void Attack(Entity entity); //공격하기
        void TakeDamage(); //공격받기
        void Avoid(); //회피하기
        void ReuseHP(); //피해받기
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();

            while (player.hp != 0 && monster.hp != 0) //둘 다 살아있는 경우에만 while문 실행됨
            {
                player.Attack(monster);
                Thread.Sleep(500);
                System.Console.WriteLine("");
                monster.Attack(player);
                Thread.Sleep(500);
                System.Console.WriteLine("");
                
            }

            if (player.hp == 0)
            {
                System.Console.WriteLine("플레이어가 죽었습니다");
            }

            if (monster.hp == 0)
            {
                System.Console.WriteLine("몬스터가 죽었습니다");
            }
        }
    }

    class Player : Entity
    {
        public int hp = 3;

        public void Attack(Entity entity)
        {
            //this는 플레이어 클래스 그 자체.
            System.Console.WriteLine("플레이어가 몬스터를 공격함!!");
            entity.TakeDamage();
            
        }

        public void Avoid()
        {
            System.Console.WriteLine("플레이어가 회피함");
        }

        public void ReuseHP()
        {
            hp--;
            System.Console.WriteLine($"플레이어가 데미지를 입었다! 플레이어 체력 : {hp}");
        }

        public void TakeDamage()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0)
            {
                Avoid(); //0인 경우 데미지 안받음
            }
            else
            {
                ReuseHP(); //1인 경우 데미지 받음
            }
        }
    }

    class Monster : Entity
    {
        public int hp = 3;

        public void Attack(Entity entity)
        {
            System.Console.WriteLine("몬스터가 플레이어를 공격함!!");
            entity.TakeDamage();
            
        }

        public void Avoid()
        {
            System.Console.WriteLine("몬스터가 회피함");
        }

        public void ReuseHP()
        {
            hp--;
            System.Console.WriteLine($"몬스터가 데미지를 입었다! 몬스터 체력 : {hp}");
        }

        public void TakeDamage()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0)
            {
                Avoid(); //0인 경우 데미지 안받음
            }
            else
            {
                ReuseHP(); //1인 경우 데미지 받음
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Entity
    {
        public virtual void Attack(Entity entity) {
            System.Console.WriteLine("공격했다!!!!");
        } //공격하기
        public virtual void TakeDamage() { } //공격받기
        public virtual void Avoid() { } //회피하기
        public virtual void ReuseHP() { } //피해받기
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();

            while (player.hp != 0 && monster.hp != 0) //둘 다 살아있는 경우에만 while문 실행됨
            {
                player.Attack(monster);
                Thread.Sleep(500);
                System.Console.WriteLine("");
                monster.Attack(player);
                Thread.Sleep(500);
                System.Console.WriteLine("");

            }

            if (player.hp == 0)
            {
                System.Console.WriteLine("플레이어가 죽었습니다");
            }

            if (monster.hp == 0)
            {
                System.Console.WriteLine("몬스터가 죽었습니다");
            }
        }
    }

    class Player : Entity
    {
        public int hp = 3;

        public override void Attack(Entity entity)
        {
            //this는 플레이어 클래스 그 자체.
            System.Console.Write("플레이어가 몬스터를 ");
            base.Attack(entity);
            entity.TakeDamage();

        }

        public override void Avoid()
        {
            System.Console.WriteLine("플레이어가 회피함");
        }

        public override void ReuseHP()
        {
            hp--;
            System.Console.WriteLine($"플레이어가 데미지를 입었다! 플레이어 체력 : {hp}");
        }

        public override void TakeDamage()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0)
            {
                Avoid(); //0인 경우 데미지 안받음
            }
            else
            {
                ReuseHP(); //1인 경우 데미지 받음
            }
        }
    }

    class Monster : Entity
    {
        public int hp = 3;

        public override void Attack(Entity entity)
        {
            System.Console.Write("몬스터가 플레이어를 ");
            base.Attack(entity);
            entity.TakeDamage();

        }

        public override void Avoid()
        {
            System.Console.WriteLine("몬스터가 회피함");
        }

        public override void ReuseHP()
        {
            hp--;
            System.Console.WriteLine($"몬스터가 데미지를 입었다! 몬스터 체력 : {hp}");
        }

        public override void TakeDamage()
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 2);
            if (randInt == 0)
            {
                Avoid(); //0인 경우 데미지 안받음
            }
            else
            {
                ReuseHP(); //1인 경우 데미지 받음
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3];

            List<int> intList = new List<int>() { 6, 2, 4, 6 }; //배열과 같으나 크기를 늘릴 수 있다!!!

            intList.Add(7);
            intList.Add(91);

            for (int index = 0; index < intList.Count; index++)
            {
                //Console.WriteLine(intList[index]);
            }

            intList.Remove(7); //7인 값을 찾아 지움

            for (int index = 0; index < intList.Count; index++)
            {
                //Console.WriteLine(intList[index]);
            }

            intList.Insert(3, 9); //세번째에 9를 넣겠다 0, 1, 2, 3 ... 순서기 때문에 네번째에 들어가는게 맞다
            for (int index = 0; index < intList.Count; index++)
            {
                //Console.WriteLine(intList[index]);
            }

            intList.Clear();
            for (int index = 0; index < intList.Count; index++)
            {
                Console.WriteLine(intList[index]);
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{

    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> intList = new List<int>() { 1, 2, 3};

            intList.Add(4);
            intList.Add(5);
            intList.Add(6);
            intList.Remove(1);

            for (int i = 0; i < intList.Count; i++)
            {
                System.Console.WriteLine(intList[i]);
            }

            List<string> intString = new List<string>() { "가", "나"}; ;
            intString.Add("다");
            intString.Add("라");
            intString.Add("마");
            intString.Remove("나");

            for (int i = 0; i < intString.Count; i++)
            {
                System.Console.WriteLine(intString[i]);
            }

            List<float> intFloat;


            List<City> cityList = new List<City>();

            City Seoul = new City();
            Seoul.name = "Seoul";

            City Dokyo = new City();
            Dokyo.name = "Dokyo";

            City City1 = new City();
            City1.name = "City1";

            City City2 = new City();
            City2.name = "City2";

            City City3 = new City();
            City3.name = "City3";

            cityList.Add(Seoul);
            cityList.Add(Dokyo);
            cityList.Add(City1);
            cityList.Add(City2);
            cityList.Add(City3);

            for (int i = 0; i < cityList.Count; i++)
            {
                cityList[i].IntroduceCity();
            }

        }
    }

    class City
    {
        public string name;

        public void IntroduceCity()
        {
            System.Console.WriteLine($"This city is {name}");   
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDic = new Dictionary<string, string>() //<string(키 값), string(밸류)>
            {
                { "originKey", "originValue"}, //key값을 알면 value값을 찾을 수 있따
                { "originKey2", "originValue2"}
            };

            myDic.Add("addKey", "addValue");
            myDic["theKey"] = "theValue"; //존재 하지 않는 key를 추가해서 넣을 수 있다

            System.Console.WriteLine(myDic["originKey"]); //originKey를 찾으면 originValue 값을 출력
            System.Console.WriteLine(myDic["originKey2"]);
            System.Console.WriteLine(myDic["addKey"]);
            System.Console.WriteLine(myDic["theKey"]);
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Monster> myDic = new Dictionary<string, Monster>();

            Monster zombie = new Monster();
            zombie.name = "Zombie";
            Monster devile = new Monster();
            devile.name = "Devile";
            Monster coffee = new Monster();
            coffee.name = "Coffee";
            Monster ghoul = new Monster();
            ghoul.name = "Ghoul";

            myDic["Zombie"] = zombie;
            myDic["Zombie"].IntroduceMonster();
            myDic["Devile"] = devile;
            myDic["Devile"].IntroduceMonster();
            myDic["Coffee"] = coffee;
            myDic["Coffee"].IntroduceMonster();
            myDic["Ghoul"] = ghoul;
            myDic["Ghoul"].IntroduceMonster();

            Dictionary<string, string> myDictionary = new Dictionary<string, string>();

            myDictionary["Zombie"] = "좀비 입니다.";
            myDictionary["ㄱ"] = "ㄱ 입니다.";
            myDictionary["ㄴ"] = "ㄴ 입니다.";
            myDictionary["ㄷ"] = "ㄷ 입니다.";

            System.Console.Write("검색어를 입력하세요! : ");
            string a = System.Console.ReadLine();
            System.Console.WriteLine(myDictionary[a]);
        }
    }

    class Monster
    {
        public string name;

        public void IntroduceMonster()
        {
            System.Console.WriteLine($"몬스터의 이름은 {name}");
        }
    }
}