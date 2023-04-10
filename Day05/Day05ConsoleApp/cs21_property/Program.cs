using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{
    class Boiler
    {
        private int temp; // 멤버변수
        public int Temp // 프로퍼티(속성)
        {
            get { return temp; }
            set{
                if (value <= 10 || value >= 70)
                {
                    temp = 10; // 제일 낮은 온도로 변경 설정
                } 
                else
                {
                    temp = value;
                }
            }
        }

        // 위의 프로퍼티(get; set;)와 비교. 아래의 Get/Set 메서드는 C#에서는 거의 안쓰고 Java에서만 사용
        public void SetTemp(int temp)
        {
            if (temp < 0 || temp >= 70) 
            {
                //Console.WriteLine("수온 설정값이 너무 낮거나 높습니다. 10도~70도 사이로 지정해주세요");
                //return;
                this.temp = 10;
            }else
            {
                this.temp = temp;
            }
        }

        public int GetTemp(){ return this.temp; }
    }

    class Car
    {
        public string name;
        public string color;
        int year;
        string fuel;
        int door;
        string tireType;
        string company;

        // Alt + Enter '필드캡슐화(그리고 속성을 사용함)' 하면 아래 프로퍼티 생성, 프로퍼티는 대문자로 사용

        public string Name { get; set; }
        public string Color { get; set; }
        public int Door { get; set; }
        public string TireType { get; set; }
        // 필터링 필요 없으면 멤버변수 없이 프로퍼티로 대체. get이나 set 둘 중 하나라도 없으면 안됨!
        public string Company { get; set; } = "현대자동차"; // 프로퍼티 기본값을 현대자동차로 초기화
        public int Year { get => year; // get return year; 을 람다식으로 표현한 것
            set
            {
                if(value <= 1990 || value >= 2023)
                {
                    year = 2023;
                }
                else { year = value; }

            } } 
        public string Fuel { get => fuel; 
            set
            {
                if (value != "휘발유" | value != "경유")
                {
                    fuel = "휘발유";
                } 
                else
                { fuel = value; }           
            }
        } // 들어오는 데이터를 필터링 해야할 때는 private 멤버변수와 public 프로퍼티를 둘 다 사용

        
    }

    interface IProduct
    {
        string ProductName { get; set; }

        void Produce();
    }

    class MyProduct : IProduct
    {
        private string productName;
        public string ProductName {
            get { return productName; }
            set { productName = value; } 
        }

        public void Produce()
        {
            Console.WriteLine("{0}을(를) 생산합니다.", ProductName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            Boiler kitturami = new Boiler();
            /*
            Get/Set 없이 사용하면 이렇게 말도 안되는,, 데이터 넣어서 소스 꼬일 수 있는 것!
            kitturami.temp = 60;

            kitturami.temp = 300000;
            kitturami.temp = -120;
            */
            kitturami.SetTemp(50);
            Console.WriteLine(kitturami.GetTemp()); // Get, Set 메서드 따로따로 만들어서 쓰는 예전 방식

            Boiler navien = new Boiler();
            navien.Temp = 5000;
            Console.WriteLine(navien.Temp);

            Car ioinc = new Car();
            ioinc.Name = "아이오닉";
            Console.WriteLine(ioinc.Name);

            // 생성할 때 프로퍼티로 초기화
            Car genesis = new Car()
            {
                Name = "제네시스",
                Fuel = "휘발유",
                color = "흰색",
                Door = 4,
                TireType = "광폭타이어",
                Year = 0,
            };
            Console.WriteLine("자동차 제조회사는 {0}", genesis.Company);    // 위에서 초기화 시켜놨기때문에 값 따로 안넣어도 출력됨
            Console.WriteLine("자동차 제조년도는 {0}년", genesis.Year);
        }
            
    }
}
