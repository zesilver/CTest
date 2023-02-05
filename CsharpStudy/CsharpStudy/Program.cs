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
        {  /*
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

           String myAge;
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



            

            //Null : 값이 비어있다

            //산술이항연술자
            int number1 = 10;
            int number2 = 12;

            int plusResult = number1 + number2;
            int minusResult = number1 + number2;
            int multResult = number1 * number2;
            int quioResult = number1 / number2; //몫
            int reminResult = number1 % number2; //나머지


            System.Console.WriteLine($"Plus result : {plusResult}");
            System.Console.WriteLine($"minusResult result : {minusResult}");
            System.Console.WriteLine($"multResult result : {multResult}");
            System.Console.WriteLine($"quioResult result : {quioResult}");
            System.Console.WriteLine($"reminResult result : {reminResult}");

             

            //할당연산자 : 있는 값에 바로 연산하기
            int number11 = 123;
            int number21 = 532;


            number21 += number11; //=> number21 값에 number11값을 더해 나온 값을 number21에 넣겠다
            System.Console.WriteLine($"PP result : {number21}");

            number21 -= number11; 
            System.Console.WriteLine($"PP result : {number21}");

            number21 *= number11;
            System.Console.WriteLine($"PP result : {number21}");

            number21 /= number11;
            System.Console.WriteLine($"PP result : {number21}");

            number21 %= number11;
            System.Console.WriteLine($"PP result : {number21}");

           
            int value = 123;

            System.Console.WriteLine($"result : {++value}");
            System.Console.WriteLine($"result : {value}");
            System.Console.WriteLine($"result : {value++}");
            System.Console.WriteLine($"result : {value}"); 
          


            int a = 1;
            int b = 2;

            int plus = a + b;
            int minus = a - b;
            int mult = a * b;
            int quio = a / b;
            int remin =  a % b;

            System.Console.WriteLine($"plus : {plus}");
            System.Console.WriteLine($"plus : {minus}");
            System.Console.WriteLine($"plus : {mult}");
            System.Console.WriteLine($"plus : {quio}");
            System.Console.WriteLine($"plus : {remin}");


            int a11 = 2;
            int a12 = 2;
            int a13 = 2;
            int a14 = 2;
            int a15 = 2;

            int b22 = 5;

            a11 += b22;
            a12 -= b22;
            a13 *= b22;
            a14 /= b22;
            a15 %= b22;

            System.Console.WriteLine($"plus : {a11}");
            System.Console.WriteLine($"plus : {a12}");
            System.Console.WriteLine($"plus : {a13}");
            System.Console.WriteLine($"plus : {a14}");
            System.Console.WriteLine($"plus : {a15}");

            int c = 10;

            System.Console.WriteLine($"값 {++c}");
            System.Console.WriteLine($"값 {c}");
            System.Console.WriteLine($"값 {c++}");
            System.Console.WriteLine($"값 {c++}");

           


            // const : 한 번 저장하면 다시 값을 못바꿈
           
            const int theNumber = 10;

            // bool : ture 또는 false 만 넣을 수 있음 보통 변수 앞에 is가 붙음
            // 변수명 앞에 !(느낌표)가 붙으면 값이 반대로 된다.
            bool isName = true;
            bool isYouName = !isName;
            
            bool isTrue = true;
            bool isFalse =false;


            // 비교 연산자
            // == : 같다
            // != : 다르다
            // < : 작다
            // > : 크다
            // <= : 작거나 같다
            // >= : 크거나 같다

            bool isSame = (3 == 3);
            System.Console.WriteLine(isSame); //true

            bool isNo = (4 != 3);
            System.Console.WriteLine(isNo); //true

            bool isS = (5 < 10);
            System.Console.WriteLine(isS); //true

            bool isB = (1 > 3);
            System.Console.WriteLine(isB); //false

            bool isSs = (3 <= 3);
            System.Console.WriteLine(isSs); // true

            bool isBb = (3 >= 8);
            System.Console.WriteLine(isBb); //false

            bool isDif = ("hello" != "hello");
            bool isdiff = (true == false);
            


            //논리연산자!!

            bool isTrue = true;
            bool isFalse = false;

            bool isAnd = (isTrue && isFalse); //둘 중 하나라도 거짓이면 거짓(즉, 둘 다 참이거나 둘 다 거짓이어야 함)
            bool isOr = (isTrue || isFalse); //둘 중 하나만 참이어도 참

            System.Console.WriteLine(true || true); //true
            System.Console.WriteLine(true && false); //false
            System.Console.WriteLine(false && false); //false
            System.Console.WriteLine(false && true); //false


            System.Console.WriteLine(true || true); //true
            System.Console.WriteLine(true || false); //true
            System.Console.WriteLine(false || false); //true
            System.Console.WriteLine(false || true); //false

            

            bool isSame = (3 == 3);
            System.Console.WriteLine(isSame); //true

            bool isNo = (4 != 3);
            System.Console.WriteLine(isNo); //true

            bool isS = (5 < 10);
            System.Console.WriteLine(isS); //true

            bool isB = (1 > 3);
            System.Console.WriteLine(isB); //false

            bool isSs = (3 <= 3);
            System.Console.WriteLine(isSs); // true

            bool isBb = (3 >= 8);
            System.Console.WriteLine(isBb); //false

            bool isDif = ("hello" != "hello");
            bool isdiff = (true == false);

            bool isTrue = true;
            bool isFalse = false;

            bool isAnd = (isTrue && isFalse); 
            bool isOr = (isTrue || isFalse);

            System.Console.WriteLine(true || true); //true
            System.Console.WriteLine(true && false); //false
            System.Console.WriteLine(false && false); //false
            System.Console.WriteLine(false && true); //false

            System.Console.WriteLine(true || true); //true
            System.Console.WriteLine(true || false); //true
            System.Console.WriteLine(false || false); //true
            System.Console.WriteLine(false || true); //false
          

            //if문 
            //if문 안에서 쓰여진 건 외부에서 쓸 수 없다
            //if는 한번 쓰고 else if는 계속 쓸 수 있음 else는 단 한번 else if 전부가 아닌 경우 else 실행

            if(true)
            {
                System.Console.WriteLine("if문 실행");
            }
 

            if (false)
            {
                System.Console.WriteLine("if문 실행");
            }
            else if (number < 2)
            {
                System.Console.WriteLine("elseif01 실행");
            }
            else if (number < 4)
            {
                System.Console.WriteLine("elseif02 실행"); 
            }
            else
            {
                System.Console.WriteLine("else문 실행");
            }
 

            int number = 2 + 3;

            if (number < 0)
            {
                System.Console.WriteLine("0보다 작습니다");
            }
            else if (number < 2)
            {
                System.Console.WriteLine("0보다 크고 2보다 작습니다");
            }
            else if (number < 4)
            {
                System.Console.WriteLine("2보다 크고 4보다 작습니다"); 
            }
            else
            {
                System.Console.WriteLine("4보다 큽니다");
            }
          

            System.Console.Write("첫번째 숫자를 입력하세요 : ");
            var a = System.Console.ReadLine();
            int aNumber = Convert.ToInt32(a);
            System.Console.Write("두번째 숫자를 입력하세요 : ");
            var b = System.Console.ReadLine();
            int bNumber = Convert.ToInt32(b);

            int abNumber = aNumber + bNumber;

            if (abNumber < 10)
            {
                System.Console.WriteLine("10보다 작습니다");
            }
            else if (abNumber < 20)
            {
                System.Console.WriteLine("10보다 크고 20보다 작습니다");
            }
            else if (abNumber < 40)
            {
                System.Console.WriteLine("20보다 크고 40보다 작습니다");
            }
            else
            {
                System.Console.WriteLine("40보다 큽니다");
            }  
           

            //A가 짝수이고 B가 0보다 작흠
            //A가 짝수이고 B가 3보다 작음
            //A가 홀수이고 5보다 작음
            //else
            System.Console.Write("첫번째 숫자를 입력하세요 : ");
            var a = System.Console.ReadLine();
            int aNumber = Convert.ToInt32(a);
            System.Console.Write("두번째 숫자를 입력하세요 : ");
            var b = System.Console.ReadLine();
            int bNumber = Convert.ToInt32(b);

            if (aNumber % 2 == 0 && bNumber < 0)
            {
                System.Console.WriteLine("A는 짝수이고 B가 0보다 작습니다");
            }
            else if (aNumber % 2 == 0 && bNumber < 3)
            {
                System.Console.WriteLine("A는 짝수이고 B가 3보다 작습니다");
            }
            else if (aNumber % 2 == 1 && bNumber < 5)
            {
                System.Console.WriteLine("A는 홀수이고 B가 5보다 작습니다");
            }
            else 
            {
                System.Console.WriteLine("XXXXX");
            }


            //while문 : 반복문, 조건식이 false가 될 때까지 실행함, 조건을 비교하고 실행
            int numberLimit = 10;
            while (numberLimit > 0)
            {
                System.Console.WriteLine("Hi");

                numberLimit--;
            } 


            //dowhile : 일단 실행하고 비교함, 최소 한 번은 실행해야 할 때 사용함.
            do
            {
                System.Console.WriteLine("Hi");
            } while (numberLimit > 5);

            //숫자를 입력받고 그 숫자만큼 문장을 띄우기

            System.Console.Write("숫자를 입력해주세요 : ");
            var a = System.Console.ReadLine();
            int aNum = Convert.ToInt32(a);

            while(aNum > 0)
            {
                System.Console.WriteLine("입력 받은 숫자");

                aNum--;
            }

            //for문(초기식; 조건식; 증감식) : while과 if를 합친거~!

            for (int number = 0; number < 5; number++) 
            {
                System.Console.WriteLine("Hi");
            }

            for (int star = 0; star < 5; star++)
            {
                for (int starr = 0; starr < star + 1; starr++)
                {
                    System.Console.Write("★");
                }

                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");

            for (int star2 = 0; star2 < 5; star2++)
            {
                for (int starr2 = 5; starr2 > star2; starr2--)
                {
                    System.Console.Write("★");
                }

                System.Console.WriteLine("");
            }

            System.Console.WriteLine("");

            //switch(비교대상)
            int myNumber = 3;
            switch (myNumber)
            {
                case 0:
                    System.Console.WriteLine("0");
                    break;
                case 1:
                    System.Console.WriteLine("1");
                    break;
                case 2:
                    System.Console.WriteLine("2");
                    break;
                case 3:
                    System.Console.WriteLine("3");
                    break;
                default:
                    break;
            }


            //게임 끝낼 때 씀!! continue / break
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("0");
                    continue; //위로 올라감
                }
                else if (i == 1)
                {
                    Console.WriteLine("1");
                    Console.WriteLine("11");
                    continue;
                    Console.WriteLine("111");
                }
                else if (i == 2)
                {
                    Console.WriteLine("2");
                    break; //탈출
                }
                else if (i == 3)
                {
                    Console.WriteLine("3");
 
                }
            }
            Console.WriteLine("끝");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("★");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            for (int a = 0; a < 5; a++)
            {
                for (int b = 5; b > a; b--)
                {
                    Console.Write("★");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int q = 0; q < 5; q++)
            {
                for (int w = 4; w > q; w--)
                {
                    Console.Write("　");
                }
                for (int e = 0; e < q+1; e++)
                {
                    Console.Write("★");
                }
                Console.WriteLine("");
            }
            
            for (int z = 0; z < 5; z++)
            {
                for (int x = 5; x > z; x--)
                {
                    Console.Write("★");
                }
                for (int c = 1; c < z + 1; c++)
                {
                    Console.Write("　");
                }
                Console.WriteLine("");
            }

            //메소드
            Console.WriteLine("1");
            ShowUpNewSentence(5);
           int newInt = ShowUpNewSentence(5);
           int newa = ShowUpNewPlus(5);
           int newb = ShowUpNewMinus(5);
           int newd = ShowUpNewDiv(5);
           int newc = ShowUpNewmo(5);

            System.Console.WriteLine(newInt);
            System.Console.WriteLine(newa);
            System.Console.WriteLine(newb);
            System.Console.WriteLine(newd);
            System.Console.WriteLine(newc);

            System.Console.Write("숫자를 입력하세요 : ");
            var a = System.Console.ReadLine();
            int c = Convert.ToInt32(a);
            int hol = holjak(c);

            string s1 = System.Console.ReadLine();
            int s1Number = Convert.ToInt32(s1);

            string s2 = System.Console.ReadLine();
            int s2Number = Convert.ToInt32(s2);

            string s3 = System.Console.ReadLine();

            
            

            if (s3 == "+")
            {
                int newInt1 = plusTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt1);
            }
            else if (s3 == "-")
            {
                int newInt2 = minusTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt2);
            }
            else if (s3 == "*")
            {
                int newInt3 = gobTwoParam(s1Number, s2Number);
                System.Console.WriteLine(newInt3);
            }
            else
            {
                System.Console.WriteLine("다시 입력해주세요");
            }*/

            System.Console.Write("숫자를 입력하세요 : ");
            var a = System.Console.ReadLine();
            int b = Convert.ToInt32(a);

            Sentence(b);
            
        }

   
        private static int Sentence(int Number)
        {
            while (Number > 0)
            {
                System.Console.WriteLine("안녕하세요");

                Number--;
            }

            return Number;
        }
        private static int plusTwoParam(int Number1, int Number2)
        {
            int resultNumber = Number1 + Number2;
            System.Console.WriteLine(resultNumber);

            return resultNumber;
        }
        private static int minusTwoParam(int Number1, int Number2)
        {
            int resultNumber = Number1 - Number2;
            System.Console.WriteLine(resultNumber);

            return resultNumber;
        }
        private static int gobTwoParam(int Number1, int Number2)
        {
            int resultNumber = Number1 * Number2;
            System.Console.WriteLine(resultNumber);

            return resultNumber;
        }
        private static int ShowUpNewSentence(int number)
        {
            int newNumber2 = number * 5;
            System.Console.WriteLine(newNumber2);

            return newNumber2;
        }
        private static int ShowUpNewPlus(int number)
        {
            int newNumber2 = number + 5;
            System.Console.WriteLine(newNumber2);

            return newNumber2;
        }
        private static int ShowUpNewMinus(int number)
        {
            int newNumber2 = number - 5;
            System.Console.WriteLine(newNumber2);

            return newNumber2;
        }
        private static int ShowUpNewDiv(int number)
        {
            int newNumber2 = number / 5;
            System.Console.WriteLine(newNumber2);

            return newNumber2;
        }

        private static int ShowUpNewmo(int number)
        {
            int newNumber2 = number % 5;
            System.Console.WriteLine(newNumber2);

            return newNumber2;
        }

        private static int holjak(int number)
        {
            
            if (number % 2 == 0)
            {
                System.Console.WriteLine("짝수 입니다.");
            }
            else 
            {
                System.Console.WriteLine("홀수 입니다.");
            };

            return number;
        }

    }
}
