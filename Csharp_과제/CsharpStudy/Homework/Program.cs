using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*public enum thePlayerState
{ 
    //열거형 네임스페이스 밖에 쓰는게 좋음, 상태 패턴값

    idle, //서있기
    walk, //걷기
    run //뛰기
}*/

namespace Homework
{
    interface IInterfaceTest
    {
        void TestInterfaceMethod();
    }
    class InterfafceTEstClassFirst : IInterfaceTest
    {
        public void TestInterfaceMethod()
        {
            System.Console.WriteLine("Hello");
        }
    }
    class InterfafceTEstClassSecond : IInterfaceTest
    {
        public void TestInterfaceMethod()
        {
            System.Console.WriteLine("Hi");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InterfafceTEstClassFirst interfaceFirst = new InterfafceTEstClassFirst();
            interfaceFirst.TestInterfaceMethod();

            InterfafceTEstClassSecond interfaceFirstSecond = new InterfafceTEstClassSecond();
            interfaceFirstSecond.TestInterfaceMethod();

            //프로퍼티
            //get, set
            /*
            thePlayerState myState = thePlayerState.idle;

            switch (myState)
            {
                case thePlayerState.idle:
                    System.Console.WriteLine("I'm idle");
                    break;
                case thePlayerState.walk:
                    System.Console.WriteLine("I'm walking");
                    break;
                case thePlayerState.run:
                    System.Console.WriteLine("I'm running");
                    break;
            }
               
            //1. 학생클래스를 만들어서 학생 하나의 정보를 입력받는다(ReadLine)

            
            Student AStudent = new Student();

            AStudent.name = System.Console.ReadLine();
            AStudent.age = Convert.ToInt32(System.Console.ReadLine());

            AStudent.WritelineStudentInfo();


            //2. 학생클래스를 만들어서 메소드로 학생 하나의 정보를 입력받는다.
            Student AStudent = new Student();
            AStudent.InputStudentInfoData();

            //3.학생 클래스를 만들어서 for문으로 학생 여럿을 입력받는다.


            Student[] students = new Student[2];

            for (int i = 0; i < 2; i++)
            {
                students[i] = new Student();
                students[i].InputStudentInfoData();
            }

            //1. 먹을 것 클래스를 만들어서 음식을 여러개 입력받습니다(Readline)
            //2. 5개의 음식을 입력 받습니다.
            //3. 추가로 음식을 입력받는데, 5개의 음식 중 이미 있는 음식이면 제외
            //4. 예) a,b,c,d,e 가 있는데 추가로 b가 입력됨 -> a,c,d,e가 됨

            Foods food = new Foods();
            food.list();

            //나이에 해당하는 띠를 출력해줄 클래스를 만든다
            //탄생 년도를 입력하면 해당하는 띠를 출력한다
            //출력할 때 나이도 같이 계산되어 출력된다

            nai tiiNai = new nai();
            tiiNai.tti();

            //게임들을 보유하고 있는 게임 클래스를 제작한다
            //게임을 입력하면 배열에 값이 있는지 비교해서 있는지 없는지 유무를 출력한다

            games wow = new games();
            wow.AGame();


            //캡슐화

            //public : 외부에서 자유롭게 쓸 수 있음
            //private : 나만 쓸 수 있음
            //protected : 상속 받은 자식이 쓸 수 있음

            //상속

            classes myNewClass = new classes();
            myNewClass.WriteSchoolInfo("부평초등학교");

            //식당 클래스를 상속 받는 한식/양식/중식
            //식당 클래스가 전체적으로 가질 정보들을 갖는다(돈 받기 / 주문한 음식 주기),
            //각 식당들은 메뉴가 모두 다르다
            //한식은 삼계탕 1만원 등등 다르다
            //가고 싶은 식당을 입력받고, 메뉴를 모두 띄워준다
            //유저는 메뉴를 입력하고, 내야할 가격, 고른 메뉴를 띄워준다

            korean koreanFood = new korean();
            koreanFood.MenuSetting();
            koreanFood.ShowMenu();

            american americaFood = new american();
            americaFood.MenuSetting();
            americaFood.ShowMenu();

            china chinaFood = new china();
            chinaFood.MenuSetting();
            chinaFood.ShowMenu();

            System.Console.WriteLine();
            System.Console.Write("주문할 음식을 적어주세요 : ");
            int inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
            koreanFood.OrderMenu(inputMenu);

            //서점 클래스에 제목, 지은이, 출판사를 입력받아 책 데이터를 쌓는다
            //특정 키를 입력받을때까지 지속되며, 특정 키 입력을 받으면
            //제목을 입력받고 제목에 맞는 지은이, 출판사를 순서대로 출력한다.

            Library library = new Library();

            int countBookNumber = 0;
            do
            {
                library.InputBooksData(countBookNumber);
                countBookNumber++;
            } while (library.AskKeepPutData());

            library.SearchTitle();

            //학생 클래스 이름 반 특정키까지 반복
            //해당 반 학생 이름 출력

            classes student = new classes();
            int countStuNumber = 0;
            do
            {
                student.InputClassData(countStuNumber);
                countStuNumber++;
            } while (student.inputInfo());

            student.searchClass();

            Random rand = new Random();
            int randomInt = rand.Next(0, 10);
            Console.WriteLine("0~10사이 랜덤 : " + randomInt);*/


        }
    }

    class stuInfo
    {
        public string name;
        public string classNum;
    }

    class classes
    { 
        stuInfo[] nameClass = new stuInfo[99];

        public void InputClassData(int numCla)
        {

            nameClass[numCla] = new stuInfo();

            System.Console.Write($"이름을 입력하세요 : ");
            nameClass[numCla].name = System.Console.ReadLine();

            System.Console.Write($"반을 입력하세요 : ");
            nameClass[numCla].classNum = System.Console.ReadLine();
        }

        public bool inputInfo()
        {
            System.Console.Write("계속 입력할까요?(y/n) : ");
            string userA = System.Console.ReadLine();

            if (userA == "y" || userA == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void searchClass()
        {
            System.Console.Write("찾고 싶은 반을 입력하세요 : ");
            string userAnser = System.Console.ReadLine();

            for (int indexNum = 0; indexNum < nameClass.Count(); indexNum++)
            {
                if (nameClass[indexNum] == null)
                {
                    System.Console.WriteLine("모두 찾았습니다");
                    break;
                }
                else if (nameClass[indexNum].classNum == userAnser)
                {
                   System.Console.Write($"이름 : {nameClass[indexNum].name} ");
                }
            }
        }


    }

    class Book
    {
        public string title;
        public string writer;
        public string publisher;
    }

    class Library
    { 
        Book[] books = new Book[99];

        public void InputBooksData(int BookCount)
        { 
            books[BookCount] = new Book();

            System.Console.Write("제목 : ");
            books[BookCount].title = System.Console.ReadLine();

            System.Console.Write("지은이 : ");
            books[BookCount].writer = System.Console.ReadLine();

            System.Console.Write("출판사 : ");
            books[BookCount].publisher = System.Console.ReadLine();

            System.Console.WriteLine("------------");
        }

        public bool AskKeepPutData()
        {
            System.Console.Write("계속 입력할까요? (y/n) : ");
            string userAnser = System.Console.ReadLine();

            if (userAnser == "y" || userAnser == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SearchTitle()
        {
            System.Console.Write("찾고싶은 제목 입력 : ");
            string userAnser = System.Console.ReadLine();

            for (int indexNum = 0; indexNum < books.Count(); indexNum++)
            {
                if (books[indexNum] == null)
                {
                    System.Console.WriteLine("못찾았습니다");
                    break;
                }
                else if (books[indexNum].title == userAnser)
                {
                    System.Console.WriteLine($"제목 : {books[indexNum].title}");
                    System.Console.WriteLine($"지은이 : {books[indexNum].writer}");
                    System.Console.WriteLine($"출판사 : {books[indexNum].publisher}");
                    break;
                }
            }   
        }
    }


    class Rest
    {
        public string[] menus;
        public int[] menusPrice;

        public void TakeMoney(int money)
        {
            System.Console.Write($"돈 내기: {money} ");
        }

        public void OrderMenu(int number)
        {
            System.Console.Write($" 주문 : {menus[number]} ");
            TakeMoney(menusPrice[number]);
        }
        public void ShowMenu()
        {
            System.Console.Write($"종류 :");
            for (int index = 0; index < menus.Count(); index++)
            {
                System.Console.Write($"{menus[index]} ");
            }
        }
        
    }

    class korean : Rest
    {
        public void MenuSetting()
        {
            menus = new string[2];
            menus[0] = "밥";
            menus[1] = "국";

            menusPrice = new int[2];
            menusPrice[0] = 1000;
            menusPrice[1] = 800;
        }
    }

    class american : Rest
    {
        public void MenuSetting()
        {
            menus = new string[2];
            menus[0] = "피자";
            menus[1] = "스파게티";

            menusPrice = new int[2];
            menusPrice[0] = 500;
            menusPrice[1] = 9000;
        }
    }

     class china : Rest
    {
        public void MenuSetting()
        {
            menus = new string[2];
            menus[0] = "짜장면";
            menus[1] = "유린기";

            menusPrice = new int[2];
            menusPrice[0] = 4000;
            menusPrice[1] = 12000;
        }
    }



    class School
    {
        protected string SchoolName;

        protected void WriteSchoolName()
        {
            System.Console.WriteLine($"학교 이름 : {SchoolName}");
        }
    }

    class classess : School //상속 받음
    {
        private string ClassName = "3반";

        public void WriteSchoolInfo(string _schoolName)
        {
            SchoolName = _schoolName;

            WriteSchoolName();
            System.Console.WriteLine($"내 반은 {ClassName}");
        }
    }

    class games
    {
        public string[] Game1 = new string[3] {"a", "b", "c" };

        public void AGame()
        {
            string a = System.Console.ReadLine();
            for (int index = 0; index < 3; index++)
            {
                if (Game1[index] == a)
                {
                    System.Console.WriteLine("있습니다.");
                    break;
                }

                if (index == 2)
                {
                    System.Console.WriteLine("없습니다.");
                    break;
                }
            }
            
        }
    }

    class nai
    {

        public void tti()
        {
            System.Console.Write("탄생년도를 입력하세요 : ");
            var a = System.Console.ReadLine();
            int yearNum = Convert.ToInt32(a);

            sap(yearNum);
        }

        public static int sap(int number)
        {
            if (number % 12 == 0)
            {
                System.Console.WriteLine($"원숭이띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 1)
            {
                System.Console.WriteLine($"닭띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 2)
            {
                System.Console.WriteLine($"개띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 3)
            {
                System.Console.WriteLine($"돼지띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 4)
            {
                System.Console.WriteLine($"쥐띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 5)
            {
                System.Console.WriteLine($"소띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 6)
            {
                System.Console.WriteLine($"호랑이띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 7)
            {
                System.Console.WriteLine($"토끼띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 8)
            {
                System.Console.WriteLine($"용띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 9)
            {
                System.Console.WriteLine($"뱀띠, 나이는 {2023 - number} 입니다");
            }
            else if (number % 12 == 10)
            {
                System.Console.WriteLine($"말띠, 나이는 {2023 - number} 입니다");
            }
            else
            {
                System.Console.WriteLine($"양띠, 나이는 {2023 - number} 입니다");
            }

            return number;
        }
    }

    class Foods
    {
        public string[] foodList; 

        public void list()
        {
            foodList = new string[5];
            for (int index = 0; index < 5; index++)
            {
                System.Console.Write("음식 이름: ");
                foodList[index] = System.Console.ReadLine();
            }

            System.Console.WriteLine("");

            string newFood;
            System.Console.Write("추가 음식 이름 : ");
            newFood = System.Console.ReadLine();

            for (int index = 0; index < 5; index++)
            {
                if (foodList[index] == newFood)
                {
                    foodList[index] = "";
                    break;
                }  
            }
           System.Console.Write($"남은 음식 : ");
            for (int index = 0; index < 5; index++)
            {
                System.Console.Write($"{foodList[index]}, ");
            }

        }

        
    }

    class Student
    {
        public string name;
        public int age;
        public void WritelineStudentInfo()
        {
            System.Console.WriteLine($"학생의 이름은 {name}");
            System.Console.WriteLine($"학생의 나이는 {age}");
        }

        public void InputStudentInfoData()
        {
            name = System.Console.ReadLine();
            age = Convert.ToInt32(System.Console.ReadLine());

            WritelineStudentInfo();
        }
    }
}

   
