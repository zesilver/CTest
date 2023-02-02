// See https://aka.ms/new-console-template for more information


System.Console.Write("이름을 입력하세요 : ");
var a = System.Console.ReadLine();
System.Console.Write("탄생년도를 입력하세요 : ");
var b = System.Console.ReadLine();
int birth = Convert.ToInt32(b);
System.Console.Write("주소를 입력하세요 : ");
var c = System.Console.ReadLine();
System.Console.Write("성별을 입력하세요 : ");
var d = System.Console.ReadLine();
System.Console.Write("자기소개를 입력하세요 : ");
var e = System.Console.ReadLine();
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine($"저의 이름은 {a} 입니다.");
System.Console.WriteLine($"저는 {birth}년생 입니다.");
System.Console.WriteLine($"사는 곳은 {c} 입니다.");
System.Console.WriteLine($"성별은 {d} 입니다.");
System.Console.WriteLine($"안녕하세요. 저의 이름은 {a} 이고, {birth}년생이며, 사는 곳은 {c}, 성별은 {d} 입니다. {e}");
