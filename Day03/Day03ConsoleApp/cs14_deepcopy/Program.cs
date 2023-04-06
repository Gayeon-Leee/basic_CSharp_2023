using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs14_deepcopy
{
    class SomeClass
    {
        public int SomeField1;
        public int SomeField2;

        public SomeClass Deepcopy() 
        {
            SomeClass newCopy = new SomeClass();
            newCopy.SomeField1 = this.SomeField1; // Call by value
            newCopy.SomeField2 = this.SomeField2;

            return newCopy;
        }

    }

    class Employee
    {
        private string Name;

        public void SetName(String Name)
        {
            this.Name = Name; // 멤버변수(속성)와 메서드의 매개변수 이름이 대소문자까지 완전히 똑같을 때 구분하기 위해 this 사용
        }
    }

    class ThisClass
    {
        int a, b, c;

        public ThisClass()
        {
            this.a = 1;
        }

        public ThisClass(int b) : this()
        {
            this.b = 2;
        }

        public ThisClass(int b, int c) : this(b)
        {
            this.c = 3;
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("얕은 복사 시작");

            SomeClass source = new SomeClass();
            source.SomeField1 = 100;
            source.SomeField2 = 200;

            SomeClass target = source;
            target.SomeField2 = 300;

            Console.WriteLine("s.SomeField1 => {0}, s.someField2 => {1}", source.SomeField1, source.SomeField2);
            Console.WriteLine("t.SomeField1 => {0}, t.someField2 => {1}", target.SomeField1, target.SomeField2);

            /*
            얕은 복사 : target이 source의 주소를 복사해서 source와 target 값이 공유됨
            => 출력하면 source와 target의 SomeFiled2 값이 다 300으로 나옴
            값이 다 바뀔 수 있기 때문에 조심해야함!!
             */

            SomeClass s = new SomeClass();
            s.SomeField1 = 100;
            s.SomeField2 = 200;

            SomeClass t = s.Deepcopy(); // 깊은 복사
            t.SomeField2 = 300;

            Console.WriteLine("s.SomeField1 => {0}, s.someField2 => {1}", s.SomeField1, s.SomeField2);
            Console.WriteLine("s.SomeField1 => {0}, s.someField2 => {1}", t.SomeField1, t.SomeField2);

        }
    }
}
