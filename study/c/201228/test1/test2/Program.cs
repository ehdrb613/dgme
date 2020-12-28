using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("값 1 : ");
            string a = Console.ReadLine();
            Console.Write("값 2 : ");
            string b = Console.ReadLine();
            Console.Write("값 3 : ");
            string c = Console.ReadLine();
            //여기까지 값 a b c 입력 받는 부분

            string abc = (int.Parse(a) * int.Parse(b) * int.Parse(c)).ToString();
            //string으로 입력 받아서 int.Parse 해줘야 곱하기 가능하고  곱하고하고 난뒤 다시 ToString() 이용해서 string 형으로 바꿈
            int[] count = new int[9];
            //0~9개의 수의 갯수를 파악하기 위해 배열로 만들어놓음.. ex)count[0] 에는 숫자 0의 개수가 몇개인지
            //배열 안할려면 변수 9개 만들어야됨

            for (int i = 0; i < 9; i++) // 숫자 0에서 부터 9까지 갯수를 파악하려면 9번 loop 해야됨
            {
                for (int j = 0; j < abc.Length; j++) 
                    //abc.Length는 abc의 길이값을 넣어주는 명령어
                    //ex) abc = 10101010 이면 abc.Length 는 8

                {
                   
                    if (i== abc[j] - '0')
                        // i변수는 int형이고 abc[j]는 char문자 형이기 때문에 - '0'(아스키코드 0은 숫자48) 빼주면 int형과 같아짐
                        // i변수가 0일때 abc[0] 배열이 '0'(숫자 48로 인식)이면 "==" 이거 써도 조건에 맞지 않기 때문에 -'0' 꼭해줘야됨
                        // i가 0이고 abc[0]=0 이면 카운트 하기 위한 조건문
                        // 10101010 이면 0번째가 1이기 때문에 0은 카운트 안되고 1번째에 0이기 때문에 카운트
                    {
                        count[i] += 1;  //카운트
                    }
                    
                }
                
            }
            Console.WriteLine($"숫자의 곱{abc} 에는");
            for (int i = 0; i < count.Length; i++)
                //깔끔하게 보여주기 위해서 한번더 하는 for문
                // 대충하려면 첫번째 for문 안에 출력하면 가능
                //마찬가지로 count 길이 만큼 반복
            {
                if(count[i]!=0)
                    Console.Write($"{i}이 : {count[i]}개 ");
                //count[i]배열 안에 값이 0보다 많으면 출력
                //그냥 0개인데 나오면 지저분하기 때문에 연습문제 출력처럼 나올려면 해야됨
            }
            
            
        }
    }
}
