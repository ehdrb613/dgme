using System;

namespace _201217_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Java : System.out.prinln("Hello World");
            // Console.WriteLine("hi");
            // Console.WriteLine("Hello World!");

            //string ss = Console.ReadLine();
            //int num = int.Parse(Console.ReadLine());
            
             //3의 배수의 합
            int sum = 0;
            for(int a = 1;a<=100; a++)
            {
                if (a % 3 == 0)
                {
                    sum += a;
                    Console.Write($"{a} " );
                }
            }
            Console.WriteLine($"1부터 100까지 3의배수 들의 합 : {sum}");


            //분초 바꾸기
            Console.Write("숫자입력 :");
            int n = int.Parse(Console.ReadLine());
            int m, s = 0;
            m = n / 60;
            s = n % 60;
            Console.WriteLine($"{m}분 {s}초");
            

            //피라미드

            Console.Write("숫자 입력:");

            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                for(int j = i; j<=num; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (i*2)-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }


            //계절

            Console.Write("달 입력:");
            int dal = int.Parse(Console.ReadLine());

            switch (dal)
            {
                case 3: case 4: case 5:
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니다");
                    break;

                default:
                    Console.WriteLine("잘못입력하였습니다.");
                    break;
            }
            //분면
            Console.Write("숫자1 입력:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("숫자2 입력:");
            int y = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1사분면");
                }
                else
                {
                    Console.WriteLine("4사분면");
                }
               
            }

            else if(x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("2사분면");
                }
                else
                {
                    Console.WriteLine("3사분면");
                }
            }
             else
            {
                Console.WriteLine("0,0입니다");
            }

            //구구단
            for(int i = 2; i <= 9; i++)//단
            {
                for (int j = 1; j <= 9; j++) //숫자
                {
                    Console.WriteLine($"{i}X{j}={i*j}");
                }
            }

            


            //수열 
            int num1 = 1;
            int count = 0;
            int temp = 0;
            //모름



        }
    }
}
