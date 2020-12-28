using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("몇개 입력?");
            int ex = int.Parse(Console.ReadLine());
            int[] num = new int[ex];//입력받을 숫자 갯수
            int h = 0;//배열 최대값 넣어주는 변수
            int low = 0;//배열 최소값 넣어주는 변수
            int hNum = 0;//최대값 배열 위치 변수
            int lowNum = 0;//최소값 배열 위치 변수

            for (int i = 0; i < ex; i++)
                //숫자 num개 만큼 입력받음
            {
                Console.Write($"숫자입력{i + 1}번째");
                num[i] = int.Parse(Console.ReadLine());

            }

            h = num[0];
            low = num[0];
            
            for (int i = 0; i < ex; i++)
            {

                if (h < num[i]) 
                    //h(최대값)
                    //처음 h 초기값이 num[0] 이고 다음 
                    //num[i]값과 비교해서 h가 작으면 num[i]가
                    //큰것이므로 h변수에 num[i]넣고 다음 반복엔
                    //바뀐 값으로 다음 i+1 값과 다시 비교
                {
                    h = num[i];
                    hNum = i;
                    Console.WriteLine(h);
                }
                else if (low > num[i])
                    //위말과 동일 low(최소값)
                {
                    low = num[i];
                    lowNum = i;
                    Console.WriteLine(low);
                }

            }
          
            Console.WriteLine($"최대값:{h},{hNum+1}번째");

            Console.WriteLine($"최소값:{low},{lowNum + 1}번째");
            



        }
    }
}
