using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
           


                int[] num = new int[9];//입력받을 숫자 갯수
                int h = 0;//배열 최대값 넣어주는 변수
                int hNum = 0;//최대값 배열 위치 변수


                for (int i = 0; i < 9; i++)
                //숫자 num개 만큼 입력받음
                {
                    num[i] = int.Parse(Console.ReadLine());
                }

                h = num[0];


                for (int i = 0; i < 9; i++)
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
                    
                    }


                }

                Console.WriteLine(h);
                Console.WriteLine(hNum + 1);


        }
    }
}

    

