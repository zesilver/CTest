using System;

namespace consoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myMoney = 100;

            Bank Abank = new Bank();
            Bank Bbank = new Bank();

            Abank.choice();
        }
    }

    class Bank
    {
        public int Money;

        public void input(int inputMoney)
        {
            int inmoney = Money + inputMoney;
            System.Console.WriteLine($"현재 계좌 잔액은 : {inmoney}");
            return inputMoney;
        }

        public void output(int outputMoney)
        {
            int outmoney = Money + outputMoney;
            System.Console.WriteLine($"현재 계좌 잔액은 : {Money - outputMoney}");
            return outputMoney;
        }

        public void move()
        {
            
        }

        public void choice()
        {
            System.Console.WriteLine("1. 입금");
            System.Console.WriteLine("2. 출금");
            System.Console.WriteLine("3. 이체");

           
        }

       
        
    }
}