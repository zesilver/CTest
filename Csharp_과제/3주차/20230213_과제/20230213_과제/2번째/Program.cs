using System;
using System.Reflection;
using static System.Reflection.Metadata.BlobBuilder;

namespace consoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            rest restran= new rest();
            restran.order();
        }
    }

    class rest
    {
        public string[] menus;
        public int[] price;

        public void order()
        {
            System.Console.Write("식당을 골라주세요(1.한식 2.양식 3.중식) : ");
            int orderNum = Convert.ToInt32(System.Console.ReadLine());

            resNum(orderNum);


        }
        public void resNum(int restNum)
        {
            System.Console.WriteLine($"고른 식당 번호 : {restNum}");

            korea korean = new korea();
            america american = new america();
            china chineses= new china();

            if (restNum == 1)
            {
                System.Console.WriteLine("한식을 선택했습니다.");
                korean.menu();
            }
            else if (restNum == 2)
            {
                System.Console.WriteLine("양식을 선택했습니다.");
                american.menu();
            }
            else
            {
                System.Console.WriteLine("중식을 선택했습니다.");
                chineses.menu();
            }
        }
        public void showMenu() 
        {
            System.Console.WriteLine("<고른 식당의 메뉴>");
            for (int index = 0; index < menus.Length; index++)
            {
                System.Console.Write($"{menus[index]}");
                if (index < menus.Length)
                {
                    System.Console.Write(" ");
                }
            }

            System.Console.WriteLine("메뉴를 골라주세요(1, 2, 3) : ");
            int choieFood = Convert.ToInt32(System.Console.ReadLine()) - 1;

            showFood(choieFood);
        }

        public void showFood(int food)
        {
            System.Console.Write($"고른 음식은 : {menus[food]} ");
            System.Console.Write($"음식의 값은 : {price[food]}");
        }
    }

    class korea : rest 
    {
        public void menu()
        {
            menus = new string[3] { "김치찌개", "비빔밥", "신선로" };
            price = new int[3] {5000, 6000, 8000};
            showMenu();
        }
    }

    class america : rest 
    {
        public void menu()
        {
            menus = new string[3] { "스파게티", "미트볼", "애플파이" };
            price = new int[3] {9500, 7850, 2000};
            showMenu();
        }
    }

    class china : rest 
    {
        public void menu()
        {
            menus = new string[3] { "짜장면", "탕수육", "팔보채" };
            price = new int[3] {4000, 12000, 20000};
            showMenu();
        }
    }

    /*class rest
    { 
        public string[] menus;
        public int[] price;

        public void choice()
        { 
            System.Console.Write("식당을 입력하세요(한식,중식,양식) : ");
            var a = System.Console.ReadLine();

        }

        public void ShowMenu()
        {
            System.Console.Write($"종류 :");
            for (int index = 0; index < menus.Count(); index++)
            {
                System.Console.Write($"{menus[index]} ");
            }
        }

        public void order() 
        {
           
        }
    }

    class korea : rest
    {
        public void menuSet()
        {
            menus = new string[3];
            menus[0] = "김치찌개";
            menus[1] = "비빔밥";
            menus[2] = "신선로";

            price = new int[3];
            price[0] = 5000;
            price[1] = 6600;
            price[2] = 3580;
        }
    }
    class america : rest
    {
        public void menuSet()
        {
            menus = new string[3];
            menus[0] = "스파게티";
            menus[1] = "미트볼";
            menus[2] = "씨리얼";

            price = new int[3];
            price[0] = 96523;
            price[1] = 852;
            price[2] = 1682;
        }
    }
    class china : rest
    {
        public void menuSet()
        {
            menus = new string[3];
            menus[0] = "탕수육";
            menus[1] = "팔보채";
            menus[2] = "깐풍기";

            price = new int[3];
            price[0] = 1215;
            price[1] = 550;
            price[2] = 89653;
        }
    }*/
}