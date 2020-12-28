using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Q = new string[5];
            int[] result = new int[5];
            string[] check = new string[5];
            int[] score = new int[5]; // 점수입력
            int sum = 0;
            Q[0] = "1+2 = ";
            Q[1] = "1x3 = ";
            Q[2] = "2+3 = ";
            Q[3] = "1x1 = ";
            Q[4] = "1-1 = ";

            result[0] = 3;
            result[1] = 3;
            result[2] = 5;
            result[3] = 1;
            result[4] = 0;

            score[0] = 10;
            score[1] = 30;
            score[2] = 20;
            score[3] = 30;
            score[4] = 10;

            for (int i = 0; i < Q.Length; i++)
            {
                Console.Write($"문제{i+1}(배점 {score[i]}점) {Q[i]} ");
                int num = int.Parse(Console.ReadLine());
                if (num == result[i])
                {
                    check[i] = "O";
                    sum += score[i];
                }
                else
                {
                    check[i] = "X";
                }

            }

            //출력
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{check[i]}");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"총점 : {sum}");
            
        }
    }
}
