// See https://aka.ms/new-console-template for more information

System.Console.Write("숫자를 입력하세요 : ");
var a = System.Console.ReadLine();
int aNum = Convert.ToInt32(a);

System.Console.Write("숫자를 입력하세요 : ");
var b = System.Console.ReadLine();
int bNum = Convert.ToInt32(b);
int abNum = aNum + bNum;

if (abNum <= 10)
{
    System.Console.WriteLine("10 이하입니다");
}
else if (abNum <= 20)
{
    System.Console.WriteLine("20 이하입니다");
}
else if (abNum <= 30)
{
    System.Console.WriteLine("30 이하 입니다");
}
else
{
    System.Console.WriteLine("30 이상입니다");
}

if (aNum % 2 == 0 && bNum % 2 == 0)
{
    System.Console.WriteLine("짝짝");
}
else if (aNum % 2 == 0 && bNum % 2 == 1)
{
    System.Console.WriteLine("짝홀");
}
else if (aNum % 2 == 1 && bNum % 2 == 0)
{
    System.Console.WriteLine("홀짝");
}
else {
    System.Console.WriteLine("홀홀");
}

System.Console.Write("숫자를 입력하세요(while/for) : ");
var c = System.Console.ReadLine();
int cNum = Convert.ToInt32(c);

while (cNum < 5)
{
    System.Console.WriteLine("while 문장입니다.");
    cNum += 1;
}

for (int i = 0; i < 5; i++)
    {
        System.Console.WriteLine("for 문장입니다.");
        
    }