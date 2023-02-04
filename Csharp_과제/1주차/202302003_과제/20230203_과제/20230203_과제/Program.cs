
string[] Foods = new string[4] { "떡볶이", "김밥", "만두", "튀김" };

System.Console.WriteLine("메뉴를 골라주세요 떡볶이:0, 김밥:1, 만두:2, 튀김:3");
System.Console.Write("메뉴 번호를 입력하세요 : ");
var a = System.Console.ReadLine();
int b = Convert.ToInt32(a);
System.Console.WriteLine($"{Foods[b]}을/를 먹었다");
Foods[b] = "";
System.Console.WriteLine("");
System.Console.WriteLine(Foods[0]);
System.Console.WriteLine(Foods[1]);
System.Console.WriteLine(Foods[2]);
System.Console.WriteLine(Foods[3]);
