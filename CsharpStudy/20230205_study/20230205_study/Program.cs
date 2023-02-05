using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230205_study
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 이름 입력받기
            System.Console.Write("이름을 입력하세요 : ");
            string myName = System.Console.ReadLine();
            System.Console.WriteLine(myName);

            //2. 생년월일 입력받기
            System.Console.Write("생년을 입력하세요 : ");
            var myBirth = System.Console.ReadLine();
            int birth = Convert.ToInt32(myBirth);
            System.Console.WriteLine(birth);

            //3. 자기소개 입력받기(1줄)
            System.Console.Write("자기소개를 써주세요 : ");
            string myIntro = System.Console.ReadLine();
            System.Console.WriteLine(myIntro);

            //4. writeline으로 출력하기(생년월일 -> 나이로)
            string nowAge = (2023 - birth).ToString();
            System.Console.WriteLine(nowAge);

            //5. $ 넣어서 표현하기
            System.Console.WriteLine($"저의 이름은 {myName}이고, 태어난 년도는 {birth}년 입니다. 저를 소개하자면 {myIntro} 마지막으로 나이는 {nowAge}살 입니다.");

            //6. @를 넣어서 사각형 그리기
            System.Console.WriteLine(@"
@@@@@@@@@@@@@@@@@
@               @
@               @
@               @
@               @
@@@@@@@@@@@@@@@@@

@--->----...장미교실
");

            //7. 1 2 3 string 배열에 넣기
            string[] array = new string[3] { myName, myBirth, myIntro };

            //8. string 배열값은 4번과 같은 방식으로 출력하기
            System.Console.WriteLine(array[0]);
            System.Console.WriteLine(array[1]);
            System.Console.WriteLine(array[2]);

            //9. string 배열값은 5번과 같은 방식으로 출력하기
            System.Console.WriteLine($"저의 이름은 {array[0]}이고, 탄생년도는 {array[1]}년이고, 저를 소개하면 {array[2]}");
        }
    }
}
