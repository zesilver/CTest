using System;

namespace consoleApp2
{
    class Program
    { 
        static void Main(string[] args) 
        {
            System.Console.Write("1번 숫자 입력하세요 : ");
            var a = Console.ReadLine();
            int aNum = Convert.ToInt32(a);

            System.Console.Write("2번 숫자 입력하세요 : ");
            var b = Console.ReadLine();
            int bNum = Convert.ToInt32(b);

            Add(aNum, bNum);


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    System.Console.Write("★");
                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");
            for (int r = 0; r < 5; r++)
            {
                for (int t = 5; t > r; t--)
                {
                    System.Console.Write("★");
                }
                System.Console.WriteLine("");
            }
        }

        private static int Add(int Num1, int Num2)
        {
            int abNum = Num1 + Num2;
            System.Console.WriteLine($"합은 : {abNum}");
            return abNum;
        }
    }
}