using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs27_delegatechain
{
    delegate void ThereIsAFire(string location); // 불났을 때 대신해주는 대리자

    delegate int Calc(int a, int b);

    delegate string Concatenate(string[] args);


    class Sample
    {
        private int valueA; // 멤버변수 - 외부에서 접근 불가

        public int ValueA // 프로퍼티
        {
            //   get { return valueA; }
            //   set { valueA = value; }

            get => valueA;
            set => valueA = value;
        }
    }

    internal class Program
    {
        static void Call119(string location)
        {
            Console.WriteLine("소방서죠? {0}에 불났어요", location);
        }

        static void Shoutout(string location)
        {
            Console.WriteLine("{0}에 불났어요", location);
        }

        static void Escape(string location)
        {
            Console.WriteLine("{0}에서 탈출합니다", location);
        }

        static string ProcConcate(string[] args)
        {
            string result = string.Empty; // == ""; 
            foreach (string s in args)
            {
                result += s + "/";
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region < 대리자 체인 영역>
            /*
             // 전화 - 소리지르고 - 탈출 을 하나하나씩 직접 호출해야함
             var loc = "우리집";
             Call119(loc);
             Shoutout(loc);
             Escape(loc);

             // 대리자 체인 : 미리 준비해놓고 fire을 호출하면 전부 실행됨
             var otehrloc = "경찰서";
             ThereIsAFire fire = new ThereIsAFire(Call119);
             fire += new ThereIsAFire(Shoutout);
             fire += new ThereIsAFire(Escape);

             fire(otehrloc);

             fire -= new ThereIsAFire(Shoutout); // 대리자 체인에서 Shoutout 메서드 뺀 것
             fire("다른 집");


             //익명함수
             Calc plus = delegate (int a, int b)
             {
                 return a + b;
             };

             Console.WriteLine(plus(6, 7));

             Calc minus = (a, b) => { return a - b; }; // 람다식 쓰면 더 줄여서도 쓸 수 있음!!

             Console.WriteLine(minus(93, 11));*/
            #endregion


            Concatenate concat = new Concatenate(ProcConcate);
            var result = concat(args);
            Console.WriteLine(result);

            Concatenate concat2 = (arr) =>
            {
                string res = concat(args);
                foreach (string s in args)
                {
                    result += s + "/";
                }
                return res;
            };

        }
    }
}
