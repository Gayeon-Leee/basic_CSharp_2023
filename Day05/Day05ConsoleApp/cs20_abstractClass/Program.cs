using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs20_abstractClass
{
    abstract class AbstractParent
    {
        protected void MethodA()
        {
            Console.WriteLine("AbstractParent.MethodA");
        }

        public void MethodB()   // 클래스와 동일
        {
            Console.WriteLine("AbstractParent.MethodB");
        }

        public abstract void MethodC(); // 인터페이스와 기능 동일
    }

    class Child : AbstractParent    // 추상 메서드인 MethodC 구현해야 함
    {
        public override void MethodC()  // override로 재정의하는 것 처럼 보이지만 사실 구현하는 것임
        {
            Console.WriteLine("Child.MethodC() - 추상클래스 구현!");
            MethodA(); // protected 여기서는 쓸 수 있음
        }
    }

    abstract class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("포유한다.");
        }

        public abstract void Sound();   // Sound 라는 하나의 메서드 생성
    }

    class Dogs : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("멍멍");    // Sound 라는 하나의 메서드로 객체에 따라 다르게 사용
        }
    }

    class Cats : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("야옹");    // Sound 라는 하나의 메서드로 객체에 따라 다르게 사용
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractParent parent = new Child();
            parent.MethodC();
            parent.MethodB();
            // parent.MethodA(); 는 오류 => protected이기 때문에 자식클래스인 Child 내부에서까지만 쓸 수 있음. 밖에서는 X
        }
    }
}
