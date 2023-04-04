using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs05_nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            // int는 원래 null값 담을 수 없음 => C# 6.0부터 nullable

            Console.WriteLine(a == null);
            // Console.WriteLine(a.GetType()); 예외발생 => nullable은 타입 제대로 안나옴

            int b = 0;
            Console.WriteLine(b == null);
            Console.WriteLine(b.GetType());

            // byte, short, int, long, float, double, char 등의 값형식은 null을 할당받을 수 없음
            // null 할당할 수 있도록 만드는 방식이 int? 처럼 type+물음표 해주는것

            float? c = null;
            Console.WriteLine(c.HasValue); // HasValue => 값 있는지 물어보는 것

            c = 3.14f;
            Console.WriteLine(c.HasValue);
            Console.WriteLine(c.Value);
            Console.WriteLine(c);

        }
    }
}
