using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace consoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            myAge myAgee = new myAge();
            myAgee.inputAge();

            calc calulation = new calc();
            calulation.inputString();
        }
    }

    class myAge
    {
        public void inputAge()
        {
            System.Console.Write("탄생년도를 입력하세요 : ");
            var Age = Console.ReadLine();
            int AgeNum = Convert.ToInt32(Age);

            tti(AgeNum);
        }

        public static int tti(int ageNumber)
        {
            if (ageNumber % 12 == 0)
            {
                System.Console.WriteLine($"원숭이띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 1)
            {
                System.Console.WriteLine($"닭띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 2)
            {
                System.Console.WriteLine($"개띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 3)
            {
                System.Console.WriteLine($"돼지띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 4)
            {
                System.Console.WriteLine($"쥐띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 5)
            {
                System.Console.WriteLine($"소띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 6)
            {
                System.Console.WriteLine($"호랑이띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 7)
            {
                System.Console.WriteLine($"토끼띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 8)
            {
                System.Console.WriteLine($"용띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 9)
            {
                System.Console.WriteLine($"뱀띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else if (ageNumber % 12 == 10)
            {
                System.Console.WriteLine($"말띠, 나이는 {2023 - ageNumber} 입니다");
            }
            else
            {
                System.Console.WriteLine($"양띠, 나이는 {2023 - ageNumber} 입니다");
            }

            return ageNumber;
        }
    }

    class calc
    {
        public void inputString()
        {
            System.Console.Write("첫번째 숫자를 입력하세요 : ");
            var a = System.Console.ReadLine();
            int aNum = Convert.ToInt32(a);
            System.Console.Write("두번째 숫자를 입력하세요 : ");
            var b = System.Console.ReadLine();
            int bNum = Convert.ToInt32(b);

            System.Console.Write("기호를 입력하세요(+,-,*,/,%) : ");
            string cNum = System.Console.ReadLine();

            if (cNum == "+")
            {
                System.Console.WriteLine($"계산식의 답은 {aNum + bNum} 입니다.");
            }
            else if (cNum == "-")
            {
                System.Console.WriteLine($"계산식의 답은 {aNum - bNum} 입니다.");
            }
            else if (cNum == "*")
            {
                System.Console.WriteLine($"계산식의 답은 {aNum * bNum} 입니다.");
            }
            else if (cNum == "/")
            {
                System.Console.WriteLine($"계산식의 답은 {aNum / bNum} 입니다.");
            }
            else
            {
                System.Console.WriteLine($"계산식의 답은 {aNum % bNum} 입니다.");
            }


        }

    }
}