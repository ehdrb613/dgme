using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class210208_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.showViewCar();
            Car c2 = new Car("현대", "흰색", "소나타", "이천만원");
            c2.showViewCar();

            Console.Write("이름입력: ");
            string name = Console.ReadLine();
            Console.WriteLine("이름 : " + name);

            Console.Write("나이 입력: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("이름 : " + age);
        }
    }
}
