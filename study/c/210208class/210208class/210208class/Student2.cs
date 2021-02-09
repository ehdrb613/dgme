using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208class
{
    class Student2
    {
        //인스턴스 변수(속성)
        private string name;
        private string tel;


        //클래스 변수
        public static string CLASS = "Java,C# 응용프로그램 개념?";


        //오버로딩(중복정의)
        public Student2()
        {
            this.name = "박길동";
            this.tel = "010-1111-1111";
        }
        public Student2(string name,string tel)
        {
            this.name = name;
            this.tel = tel;
        }

        //pro tap
        /* public string name { get; set; }*/

        //propfull tab

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public void printStudentInfo()
        {
            Console.WriteLine("과정: "+ Student2.CLASS);
            Console.WriteLine("이름: " + name);
            Console.WriteLine("전화: " + tel);
            Console.WriteLine("----------------");
        }

    }
}
