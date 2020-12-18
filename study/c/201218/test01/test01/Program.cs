using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //cw입력tap키 2번
            //프로그램 실행 
            //java : ctrl + F11
            //ctrl : ctrl + F5
            Console.Write("Hellow하고 한줄 안띄움");
            //아무것도 안하고 그냥 한줄 띄우기
            Console.WriteLine();

            //변수
            //java와 동일

            int example = 100;
            //단 String 변수는 string 이랑 String 둘다 동일하게 쓸 수 있음
            //C#에서는 보통 S 소문자로 적는다.
            string ex1 = "하이";
            string ex2 = "헬로";
            string 이런것도됨 = "신기하죠?";
            Console.WriteLine(이런것도됨); //한글 쓰지 마요
            string ex3 = example + "더하기" + example + "은" + (example + example) + "이다";
            string ex4 = $"{example}더하기 {example}은 {example + example}이다";
            string ex5 = string.Format("{0}더하기 {1}는 {2}이다", example, example, example + example);
            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            //조건문
            //java와 동일함

            if (example>50)
            {
                Console.WriteLine("example은 50이상");
            }
            if (example>30)
            {
                Console.WriteLine("30이상");
            }
            else
            {
                Console.WriteLine("30미만");
            }

            if (example==10)
            {
                Console.WriteLine("10");
            }
            else if(example==20)
            {
                Console.WriteLine("20");
            }//*끝에 꼭 else 안붙여도 됨*


            //switch문도 java와 동일
            switch (example)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10이랑 20은 아니다");
                    break;

            }

            //반복문도 Java와 동일
            //단 foreach라는 특수 문법이 있는데 이건 나중에 알려줌
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("같은 말 10번 반복하기");
            }

            int temp = 10;
            while (temp > 0)
            {
                temp--;
            }
            do
            {
                temp++;
            } while (temp<10);

            //값을 입력 받는 경우
            //java
            /*
             * Scanner s = new Scanner(System.in);
             * String test = s.nextLine();
             * int test2 = s.nextInt();
             */

            //c#
            //string test = Console.ReadLine();
            //int test2 = int.Parse(Console.ReadLine());
            //Console.ReadLine은 단축키 없음

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());


        }
    }
}
