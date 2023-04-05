using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비트연산.. 실무에서 많이 사용하지는 않지만 알고있어야함
            int firstval = 15; // 15의 이진수 1111
            int secondval = firstval << 1;  // 비트를 한 칸 옆으로(왼쪽으로) 당기는 연산 11110 => 16+8+4+2 =30
            Console.WriteLine(secondval);

            // 15 == 1111 / 13 == 1101
            // 1111 & 1101 => 1101
            // 1111 | 1101 => 1111
            firstval = 15;
            secondval = 13;
            Console.WriteLine(firstval & secondval);
            firstval = 10;
            secondval = 5;
            Console.WriteLine(firstval | secondval);
            Console.WriteLine(firstval ^ secondval); // XOR
            Console.WriteLine(~secondval); // 보수 


            // Null 병합 연산자
            int? checkval = null;
            Console.WriteLine(checkval == null ? 0 : checkval); // 3항 연산자
            Console.WriteLine(checkval ?? 0); // null병합 연산자 -> 위의 3항 연산자와 결과 같음.. 3항 연산자를 더 줄인 것

            checkval = 25;
            Console.WriteLine(checkval == null ? 0 : checkval);
            Console.WriteLine(checkval.HasValue ? checkval.Value : 0); // 결과값 같음
            Console.WriteLine(checkval ?? 0);
        }
    }
}
