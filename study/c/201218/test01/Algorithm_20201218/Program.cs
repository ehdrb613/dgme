using System;

namespace Algorithm_20201218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제풀이시작");
            Console.WriteLine("1번문제");
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                
            }
            Console.WriteLine($"1부터100까지의 수중 3의배수의 합은:{sum}이다");

            Console.WriteLine("2번 문제");
            int inputSecond = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inputSecond/60}분 {inputSecond%60}초");


            Console.WriteLine("3번 문제");
            Console.WriteLine("몇층까지 쌓을 것인가?");
            int floor = int.Parse(Console.ReadLine());
            for (int i = 0; i < floor; i++) //전체 층을 출력
            {
                //공백을 찍는 부분
                for (int j = floor; j>i ; j--) //각 층을 출력(공백)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k < (2*i)+1; k++)
                {
                    Console.Write('*');
                }
                //별을 찍는 부분

                Console.WriteLine();
            }


            Console.WriteLine("4번 문제");

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
            }

            Console.WriteLine("5번 문제");
            int month = int.Parse(Console.ReadLine());
            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine("잘못된값");
                    break;
            }

            Console.WriteLine("6번 문제");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            if (input1>0 && input2>0)
                Console.WriteLine("1");
            else if (input1<0 && input2>0)
                Console.WriteLine("2");
            else if (input1<0 && input2<0)
                Console.WriteLine("3");
            else if (input1>0 && input2<0)
                Console.WriteLine("4");
            else
                Console.WriteLine("0");

            Console.WriteLine("7번 문제");
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0; // 각자리 숫자의 개수
                string end = "";// 문자열을 누적시키는 변수
                Console.WriteLine($"{i+1}번째 : {start}"); //말하기
                char number = start[0]; //내가 가르키는 숫자

                for (int j = 0; j < start.Length; j++) //수열 읽어들이기
                {
                    if (number != start[j])
                    {
                        end = end + number + count;//end = ""+'1'+1
                        number = start[j];//가르키는 숫자를 다른 걸로 바꿈
                        count = 1;//count는 1로 초기화, 왜냐면 다른 숫자가 있어서 이 조건문으로 들어왔으니까
                    }
                    else
                    {
                        count++;
                    }
                
                }
                end = end + number + count;
                start = end;
            }


            //8번
            int input = int.Parse(Console.ReadLine());
            int max = 1; //각 벌집의 최대값
            int counter = 0;
            while (true)
            {
                max = max + (6 * counter);
                if (max < input)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{input}은 {counter + 1}번째 벌집에 속함");
                
                break;
            }

            Console.WriteLine("8문제 (이동준ver)");
            int input3 = int.Parse(Console.ReadLine());
            //패턴정리
            //벌집안의 수        벌집번호 각 벌집 최대값간의 차이
            //1                 - 1번 벌집 -
            //2~7               - 2번 벌집 - 6
            //8~19              - 3번 벌집 - 12
            //20~37              - 4번 벌집 - 18
            //38~61             - 5번 벌집 - 24

            if (input3==1)
                Console.WriteLine("1번 벌집");
          
            else if(input3 <= 7)
                Console.WriteLine("2번 벌집");
            else
            {
                int tempCount = 1;
                int sub = 6;
                while (input3 > 0)
                {
                    input3 = input3 - sub;
                    sub = sub + 6;
                    tempCount++;
                    if (input3 <= 1)
                        break;
                }
                Console.WriteLine(tempCount);
            }
        }
    }
}
