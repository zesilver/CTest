using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            System.Console.WriteLine("내 이름은 서영은 입니다");
            System.Console.WriteLine("나는 28살 입니다");
            System.Console.WriteLine("나는 뮤지컬을 좋아한다");
            System.Console.WriteLine("나는 인천에 살고 있다");
            System.Console.WriteLine("우리 동네에는 공장이 많다");
            System.Console.WriteLine("삶은 계란에 초장 찍어먹으면 맛있다");
            System.Console.WriteLine("횡단보도가 빨간불일 때는 건너지 않는다");
            System.Console.WriteLine("나는 키우는 동물이 없다");
            System.Console.WriteLine("내 MBTI는 ESFP다");

            System.Console.WriteLine("writeline");

            //write 사용법
            System.Console.Write("1");
            //WriteLine 사용법
            System.Console.WriteLine("2");
            System.Console.Write("3");
            System.Console.Write("4");
            System.Console.WriteLine("5");
            System.Console.WriteLine("6");
            System.Console.WriteLine("7");
            System.Console.Write("8");
            System.Console.Write("9");
            System.Console.WriteLine("10");

            //System.Console.Write("30분");


            //데이터 형 - string : 문장 형식

            /* String myAge;
             String myHome;
             String myMbti;
             String myPet;
             //변수형 변수


             myAge = "나는 28살 입니다";
             myHome = "나는 인천에 살고 있다";
             myMbti = "내 MBTI는 ESFP다";
             myPet = "나는 키우는 동물이 없다";*/



            //ReadLine();
            //이름, 주소, 나이, 성별
            /*
            string myName;
            string myAdd;
            string myAge;
            string myGender;

            System.Console.WriteLine("이름을 입력해 주세요");
            myName = System.Console.ReadLine();
            System.Console.WriteLine("주소를 입력해 주세요");
            myAdd = System.Console.ReadLine();
            System.Console.WriteLine("나이를 입력해 주세요");
            myAge = System.Console.ReadLine();
            System.Console.WriteLine("성별을 입력해 주세요");
            myGender = System.Console.ReadLine();

            System.Console.Write("당신의 이름은 : ");
            System.Console.WriteLine(myName);            
            System.Console.Write("당신의 주소는 : ");
            System.Console.WriteLine(myAdd);
            System.Console.Write("당신의 나이는 : ");
            System.Console.WriteLine(myAge);
            System.Console.Write("당신의 성별은 : ");
            System.Console.WriteLine(myGender);

            System.Console.Write($"당신의 이름은 {myName} 이고, 당신의 나이는 {myAge} 입니다");
            System.Console.Write("당신의 이름은 {0} 이고, 당신의 나이는 {1} 입니다.", myName, myAge);
            */

            /* 
            //2장 : 변수

            int MyAge = 36; //정수형
            string MyName = "Xia";
            float toDay = 1.29f; //실수형, 반드시 뒤에 f를 붙여야 함

            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            int i = 0;


            System.Console.WriteLine("준수가 말했다 \"코코넛들아 안녕\" 하고.."); //이스케이프 시퀀스

            string myName = "Xia";

            System.Console.Write(myName);



            string mmm = myName + myAge;

            System.Console.WriteLine(mmm);

            //null : 없다, 비어있다

            string kk = null;


            //캐스팅 : 형식을 바꾸는 것.(예: 문장형식을 숫자로 바꾸는 것)
             string myAge;
             System.Console.WriteLine("나이를 입력해 주세요 : ");
             myAge = System.Console.ReadLine();

            int myAgeNumber = Convert.ToInt32(myAge);

            string nowAge = (myAgeNumber + 3).ToString();


            //나의 태어난 년도 입력
            //받은 입력 후 지금 나이를 도출하기

            string myYear;
            System.Console.WriteLine("태어난 년도를 입력해 주세요");
            myYear = System.Console.ReadLine();

            int myYearNumber = Convert.ToInt32(myYear);

            string nowYear = (2023 - myYearNumber).ToString();

            System.Console.Write(nowYear);
            */

            /*@ 붙이면 작성한 그대로 출력 됨.
            System.Console.WriteLine(@"도리안그레이
모차르트
엑스칼리버");

            System.Console.WriteLine(@"
          **
         ****
        ******
      **********
    **************
       ㅁㅁㅁㅁ
       ㅁㅁㅁㅁ
       ㅁㅁㅁㅁ
");


            //1. 변수형 종류 주석으로 작성 후, 각 변수형들의 최대값 최소값 출력하기

            //int
            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            //float
            System.Console.WriteLine(float.MaxValue);
            System.Console.WriteLine(float.MinValue);

            //Double
            System.Console.WriteLine(double.MaxValue);
            System.Console.WriteLine(double.MinValue);

            //2. string으로 이름 나이 입력 받고, 출력하기
            //나이는 출생년도만 입력받기

            string myName;

            System.Console.Write("이름을 입력하세요 : ");
            myName = System.Console.ReadLine();

            string myYear;
            System.Console.WriteLine("출생연도를 입력해 주세요");
            myYear = System.Console.ReadLine();

            int myYearNumber = Convert.ToInt32(myYear);

            string nowAge = (2023 - myYearNumber).ToString();

            
            System.Console.Write($"당신의 나이는 : {nowAge}");

            //3. @사용해서 별 그리기
            System.Console.WriteLine(@"
         *
        ***
      *******
 *****************
   *************
    **********
    ***    ***
    *        *
");

            //4. int 값을 float 로 캐스팅하기
            int ii = 3;
            System.Console.WriteLine(ii);

            

            //   3.12를 int 값으로 캐스팅하기
            float f = 3.12f;
            System.Console.WriteLine(f);

            int i = Convert.ToInt32(f);
            System.Console.WriteLine(i);


            //이름을 입력받는다.
            //입력받은 이름의 길이를 숫자로 바꾸고
            //받은 숫자를 출력한다.

            System.Console.Write("이름을 입력하세요 : ");
            string str = System.Console.ReadLine();
            int len = str.Length;
            System.Console.WriteLine(len);

            

            string myName = "김준수";
            int ii = 3;
            float ff = 3.12f;

            //값을 가져올건데 int, string, char 형인지 모를 때 var를 사용한다
            //남발은 안하는게 좋음

            var myNameis = "김준수";
            var iii = 3;
            var fff = 3.12f;

        

            //배열 : int 값의 묶음

            int[] intt = new int[3];

            int kk = 1;
            int kkk = 4;
            int kkkk = 100;

            int[] kkkkk = new int[4] { 89, 6, 456, 4 };
            string[] lang = new string[3] { "c#", "c++", "c" };
            long[] lolo = new long[2] { 2, 3 };

            //kkkkk -> 89, 6, 456, 4
            //lang - > c#, c++, c

            System.Console.WriteLine(kkkkk[0]);


            //int형 배열 5칸짜리 5개
            int[] i = new int[5] { 1, 5, 6, 8, 9 };
            int[] ii = new int[5] { 8, 86, 96, 63, 105 };
            int[] iii = new int[5] { 5, 15, 25, 35, 45 };
            int[] iiii = new int[5] { 4, 8, 12, 16, 20 };
            int[] iiiii = new int[5] { 12, 15, 1, 26, 109 };

            //string 형 배열 5칸짜리 5개
            string[] st = new string[5] { "내사랑", "끝이났지만", "삶은", "끝나지", "않아" };
            string[] str = new string[5] { "내사랑", "끝이났지만", "삶은", "끝나지", "않아" };
            string[] strr = new string[5] { "내사랑", "끝이났지만", "삶은", "끝나지", "않아" };
            string[] strrr = new string[5] { "내사랑", "끝이났지만", "삶은", "끝나지", "않아" };
            string[] strrrr = new string[5] { "내사랑", "끝이났지만", "삶은", "끝나지", "않아" };


            int[] LaterArray; //쓰려고 예약 걸어둔 상태

            System.Console.WriteLine("배열의 크기는?");
            string ArraySize;
            ArraySize = System.Console.ReadLine();

            LaterArray = new int[Convert.ToInt32(ArraySize)];
                        string[] food = new string[4];
            food[0] = "떡볶이";
            food[1] = "김밥";
            food[2] = "라면";
            food[3] = "라볶이";

                */

            string[] _lang = new string[3];
            _lang[0] = "c";
            _lang[1] = "c++";
            _lang[2] = "c#";

            System.Console.WriteLine($"0번 값은 {_lang[0]} 입니다.");
            _lang[0] = "요술봉 얍";

            System.Console.WriteLine($"0번 값은 {_lang[0]} 입니다.");

            //식당에 음식이 떡볶이, 김밥, 라면, 라볶이가 있다
            //이중에 숫자를 입력받으면 입력받은 값은 비어있게 된다.

            //최초 음식들과 숫자를 입력받았을 때 음식을 출력하고 비어있게 되었다라는 결과값도 출력하라

            string[] food = new string[4] { "떡볶이", "김밥", "라면", "라볶이" };

            System.Console.WriteLine($"주문한 음식은 {food[0]} 입니다.");
            System.Console.WriteLine($"주문한 음식은 {food[1]} 입니다.");
            System.Console.WriteLine($"주문한 음식은 {food[2]} 입니다.");
            System.Console.WriteLine($"주문한 음식은 {food[3]} 입니다.");

            System.Console.WriteLine("숫자를 입력하세요");

            string foodNum = System.Console.ReadLine();
            int number = Convert.ToInt32(foodNum);

            food[number] = "";

            System.Console.WriteLine($"주문한 음식은 {food[0]} 입니다.");
            System.Console.WriteLine($"주문한 음식은 {food[1]} 입니다.");
            System.Console.WriteLine($"주문한 음식은 {food[2]} 입니다.");
            System.Console.WriteLine($"주문한 음식은 {food[3]} 입니다.");










        }
    }
}
