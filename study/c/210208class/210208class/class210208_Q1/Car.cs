using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class210208_Q1
{
    class Car
    {
        //클래스 상수 변수
        public const string sName = "동대구 영업소";
        //인스턴스 변수
        private string make;
        private string color;
        private string model;
        private string money;

        public Car()
        {
           this.Make = "기아";
           this.color = "블랙";
           this.model = "K7";
           this.money = "사천만원";
        }

        public Car(string make, string color, string model, string money)
        {
            this.make = make;
            this.color = color;
            this.model = model;
            this.money = money;

           
        }

        /*public Car(string make,string color,string money,string model)
        {

            this.Make = make;
            this.color = color;
            this.money = money;
            this.model = model;
        }*/

        /*public string Make
        {
            get { return make; }
            set { make = value; }
        }*/

        public string Color 
        {
            get { return color; }
            set { color = value; }
        }

        public string Money
        {
            get { return money; }
            set { money = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Make { get => make; set => make = value; }

        public void showViewCar()
        {

            Console.WriteLine("제조사 : " + Make);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("이름 : " + model);
            Console.WriteLine("가격 : " + money);
            Console.WriteLine("대리점명 : " + Car.sName);
            Console.WriteLine("--------------------------------");

        }

    }
}
