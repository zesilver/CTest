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
            int myMoney = 100;

            Bank Abank = new Bank();
            Bank Bbank = new Bank();


            while (true)
            {
                System.Console.WriteLine("1. 입금");
                System.Console.WriteLine("2. 출금");
                System.Console.WriteLine("3. 이체");

                int choiceNum = Convert.ToInt32(System.Console.ReadLine());

                switch(choiceNum)
                {
                    case 1:
                        System.Console.Write("입금할 금액을 입력하세요 : ");
                        int putMyMoney = Convert.ToInt32(Console.ReadLine());
                        Abank.input(myMoney + putMyMoney);
                        break;

                    case 2:
                        System.Console.Write("출금할 금액을 입력하세요 : ");
                        int takeMyMoney = Convert.ToInt32(Console.ReadLine());
                        Abank.output(myMoney - takeMyMoney);
                        break;
                    case 3:
                        Abank.Money = 100;
                        System.Console.Write("Bbank로 보낼 금액을 입력하세요 : ");
                        int moveMyMoney = Convert.ToInt32(Console.ReadLine());
                        Abank.move(moveMyMoney);  
                        break;

                    default:
                        break;
                }

            }
        }
    }

    class Bank
    {
        public int Money;

        public void input(int inputMoney)
        {
            int inMoney = Money + inputMoney;
            System.Console.WriteLine($"Abank 계좌 잔액은 : {inMoney}만원 입니다.");
        }

        public void output(int outputMoney)
        {
            int outMoney = Money + outputMoney;
            System.Console.WriteLine($"Abank 계좌 잔액은 : {outMoney}만원 입니다.");
        }

        public void move(int moveMoney)
        {
            int AMoveMoney = Money - moveMoney;
            int BMoveMoney = Money + moveMoney;
            System.Console.WriteLine($"Abank 계좌 잔액은 : {AMoveMoney}만원, Bbank의 잔액은 {BMoveMoney} 입니다.");
        }          
        
    }
}
