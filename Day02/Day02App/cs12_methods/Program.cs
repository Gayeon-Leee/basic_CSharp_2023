using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs12_methods
{
    class Calc
    {
        public static int Plus(int a, int b)    // static 이 없으면
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    internal class Program
    { 
        /// <summary>
        /// 실행시 최초로 메모리에 올라가야 하기 때문에 static 사용
        /// 메서드 이름이 Main 이면 실행될 때 제일 처음 시작되는 것
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            #region < static 메서드>

            int result = Calc.Plus(1, 2); // 이 형태로 못쓰고 int result = new Calc().Plus(1,2); 로 써야함
            Console.WriteLine(result);
            // Calc.Minus(3, 2); Minus는 Static 아니기 때문에 접근 불가!
            result = new Calc().Minus(3, 2); // new로 객체 만들어서 접근해야하는 것
            /*
            차이점 
            static은 정적 할당(최초 실행시 메모리에 바로 올라가기때문에 언제든지 접근할 수 있게 해줌) => 클래스 객체 만들 필요 없음
            static 없으면 new로 heap 영역에 할당시켜줘야하기 때문에 int result = new Calc().Plus(1,2); 형태로 쓰는 것
            */

            Console.WriteLine(GetNumber());

            #endregion

            #region < Call by reference / Call by value 비교 >
           
            int x = 10; int y = 3;
            Swap(ref x, ref y); // x, y가 가지고 있는 주소를 전달하겠다는 것(Call by reference == pointer)
            Console.WriteLine("x = {0}, y = {1}", x, y);
            /*
             그냥 Swap(x, y)하면 값 안바뀜 => Call by value
             값을 전달했기 때문에 바뀌지 않는 것!!
             */

            #endregion

            #region < out 매개변수 >

            int divid = 10;
            int divor = 3;

            /*result = Divide(divid, divor);
            Console.WriteLine(result);
            int rem = Reminder(divid, divor);
            Console.WriteLine(rem);*/
            int rem = 0;

            
            Divide(divid, divor, out result, out rem);
            //Divide(divid, divor, ref result, ref rem);
            Console.WriteLine("나누기 값 {0} 나머지 {1}", result, rem);

            (result, rem) = Divide(20, 6);
            Console.WriteLine("나누기 값 {0} 나머지 {1}", result, rem);

            #endregion

            #region < 가변길이 매개변수 >

            Console.WriteLine(Sum(1, 3, 4, 5, 9));

            #endregion

        }


        /*
         static int Divide(int x, int y)
        {
            return x / y;
        }

        static int Reminder(int x, int y)
        {
            return (x % y) + y;
        }
        이렇게 메서드 두 개 만들걸 아래처럼 하나로 만드는 것
         */


        static void Divide(int x, int y, out int val, out int rem)
        //static void Divide(int x, int y, ref int val, ref int rem) 과 동일.. out 사용을 더 권장
        {
            val = x / y; 
            rem = x % y;
        }

        static (int result, int rem) Divide(int x, int y)   // 튜플 사용하는 방식.. 오버로딩으로 동일 이름 함수 O _ 인자 개수가 다름
        {
            return(x / y, x % y);
        }

        static (float result, int rem) Divide(float x, float y)   // 오버로딩 _ 데이터 타입이 다름
        {
            return (x / y, (int)(x % y));
        }

        // Main 메서드와 같은 레벨에 있는 메서드들은 무조건 static 이어야함!
        public static void Swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }
        static int val = 100;
        public static ref int GetNumber()
        {
            return ref val; // static 메서드에 접근 할 수 있는 변수는 static 밖에 없음
        }

        public static int Sum(params int[] args)
        {
            int sum = 0;
            
            foreach (var item in args)
            {
                sum += item;
            }
            
            return sum;
        }
    }
}
