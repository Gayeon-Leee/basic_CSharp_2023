using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace cs11_logiccondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region < IF 구문 >
            // region주석(지역 주석)
            int a = 20;
            // 1. 처리하는 로직이 있으면 if줄 안에 한줄만 쓰더라도 무조건 괄호 쓸 것!
            if (a == 20)
            { 
                Console.WriteLine("20입니다.");
            }
            // 2. 메서드를 완전히 빠져나가는 구문은 괄호 없이 한 줄로 써도 됨
            if (a == 30) return;
            #endregion

            #region < 데이터타입 비교 switch 구문(C# 7.0부터)>
            object obj = null;

            string inputs = Console.ReadLine(); // 콘솔에서 입력
            if (int.TryParse(inputs, out int ioupout))  // 예외 발생하면 0
            {
                obj = ioupout; // 입력한 값이 정수라서 문자열을 정수로 변환
            }
            else if(float.TryParse(inputs, out float foutput)) 
            {
                obj = foutput; // 입력값이 실수라서 문자열을 실수로 변환
            }
            else
            {
                obj = inputs; // 둘다 아닌 경우
            }

            Console.WriteLine(obj);
            switch(obj)
            {
                case int i: // 값이 정수라면
                    Console.WriteLine("{0}는 int 형식입니다.", i);
                    break;
                case float f: // 실수라면
                    Console.WriteLine("{0}는 float 형식입니다.", f);
                    break;
                case string s: // 문자열이면
                    Console.WriteLine("{0}는 float 형식입니다.", s);
                    break;
                default:
                    Console.WriteLine("몰라요,,");
                    break;
            }
            #endregion

            #region <2중 For문 - 구구단>

            for (int x = 2; x <= 9; x++)
                
            {
                for (int y = 1; y <= 9; y++)
                {
                    Console.WriteLine("{0} x {1} = {2}", x, y, x*y);
                        }
                   
            }
            #endregion

            #region <Foreach문>

            int[] ary = { 2, 4, 6, 8, 10 }; // 배열이나 컬렉션(리스트)

            foreach (int i in ary) 
            {
                Console.WriteLine("{0}*2 = {1}", i, i*2);
            }

            // 위의 foreach문과 결과 동일.. foreach문이 좀 더 간결함
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine("{0}*2 = {1}", ary[i], ary[i] * 2);
            }

            #endregion
        }

    }
}
