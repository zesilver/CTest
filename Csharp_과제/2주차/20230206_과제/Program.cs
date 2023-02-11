// See https://aka.ms/new-console-template for more information
System.Console.Write("첫번째 숫자를 입력하세요(연산자) : ");
var a = System.Console.ReadLine();
System.Console.Write("두번째 숫자를 입력하세요(연산자) : ");
var b = System.Console.ReadLine();

int aNum = Convert.ToInt32(a);
int bNum = Convert.ToInt32(b);

int plus =  aNum + bNum;
Console.WriteLine(plus);

int minus = aNum - bNum;
System.Console.WriteLine(minus);

int mult = aNum * bNum;
Console.WriteLine(mult);

int quot = aNum / bNum;
Console.WriteLine(quot);

int rema = aNum % bNum;
Console.WriteLine(rema);

System.Console.WriteLine("");
System.Console.WriteLine("");

System.Console.Write("숫자를 입력하세요(할당연산자) : ");
var c = System.Console.ReadLine();
int cNum = Convert.ToInt32(c);

cNum += 2;
System.Console.WriteLine($"+= : {cNum}");

cNum -= 2;
System.Console.WriteLine($"-= : {cNum}");

cNum *= 2;
System.Console.WriteLine($"*= : {cNum}");

cNum /= 2;
System.Console.WriteLine($"/= : {cNum}");

cNum %= 2;
System.Console.WriteLine($"%= : {cNum}");

System.Console.WriteLine($"증감연산자: {cNum++}");
System.Console.WriteLine($"증감연산자: {cNum++}");
System.Console.WriteLine($"증감연산자: {++cNum}");
System.Console.WriteLine($"증감연산자: {cNum++}");
System.Console.WriteLine($"증감연산자: {++cNum}");