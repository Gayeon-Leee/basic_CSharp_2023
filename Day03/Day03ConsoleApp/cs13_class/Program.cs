using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13_class
{

    class Cat // private 이라도 같은 namespace(cx13_class) 안에서는 접근 가능 but Cat 클래스 안의 멤버함수들은 다름!!
    {
        #region < 생성자 >
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Cat() 
        {
            Name = string.Empty;
            Color = string.Empty;
            Age = 0;
        }
        /// <summary>
        /// 사용자 지정 생성자
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="age"></param>
        public Cat(string name, string color = "흰색", sbyte age = 1)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        #endregion

        #region < 멤버변수 - 속성 >
        public string Name; // 고양이 이름
        public string Color; // 색상
        public sbyte Age; // 고양이 나이(sbyte : 0~255)
        #endregion

        #region < 멤버메서드 - 기능>
        public void Meow() // void 앞에 아무것도 안쓰면 기본적으로 private => Cat 클래스 밖에서 접근 불가 public 써야 접근 가능함
        {
            Console.WriteLine("{0} - 야옹", Name);
        }

        public void Run()
        {
            Console.WriteLine("{0} 달린다", Name);
        }
        #endregion

    }
    internal class Program  // internal은 namespace(cs13_class) 어디서든 접근가능 하다는 것
    {
        static void Main(string[] args)
        {
            Cat helloKitty = new Cat(); // helloKitty 라는 이름의 객체를 생성
            helloKitty.Name = "헬로키티";
            helloKitty.Color = "흰색";
            helloKitty.Age = 50;
            helloKitty.Meow();
            helloKitty.Run();

            Cat nero = new Cat() // 객체 생성하면서 속성 초기화
            {
                Name = "검은 고양이 네로",
                Color = "검은색",
                Age = 27
            };
            nero.Meow();
            nero.Run();

            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", helloKitty.Name, helloKitty.Color, helloKitty.Age);
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", nero.Name, nero.Color, nero.Age);


            Cat yaouni = new Cat(); // 기본 생성자
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", yaouni.Name, yaouni.Color, yaouni.Age);

            Cat norangi = new Cat("노랑이", "노란색");    // 사용자 지정 생성자
            Console.WriteLine("{0}의 색상은 {1}, 나이는 {2}세 입니다.", norangi.Name, norangi.Color, norangi.Age);


        }
    }
}
