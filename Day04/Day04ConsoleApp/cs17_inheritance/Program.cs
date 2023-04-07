using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cs17_inheritance
{
    // 상속해줄 부모 클래스
    class Parent
    {
        public string Name; // 상속할 때는 private 사용X. protected나 public 사용해야 함

        public Parent(String Name) // 생성자
        {
            this.Name = Name;
            Console.WriteLine("{0} from Parent 생성자", Name);
        }

        public void ParentMethod()  // 메서드도 마찬가지로 protected나 public 써야 자식 클래스에서 접근할 수 있음
        {
            Console.WriteLine("{0} from Parent 메서드", Name);
        }
    }

    // Parent 클래스 상속받는 자식 클래스
    class Child : Parent
    { 
        public Child(string Name) : base(Name) // base => 부모클래스 생성자 먼저 실행하고 본인 생성자 실행함
        {
            Console.WriteLine("{0} from Child 생성자", Name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0} from CHild 메서드", Name);
        }
    }

    // 클래스간 형변환 DB처리, DI
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("포유류 기르다");
        }
    }

    class Dogs : Mammal
    { 
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cats : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }

    class Elephants : Mammal
    {
        public void Poo()
        {
            Console.WriteLine("뿌우");
        }
    }

    class Zookeeper
    {
        /*
        public void Wash(Dogs dogs)
        {
            ///
        }

        public void Wash(Cats cat)
        {
            ///
        }

        public void Wash(Elephants elephants)
        {
            ///
        }
        부모 클래스 승계 받지 않으면 이렇게 필요한 메서드를 모두 만들어줘야 하는데
        승계 받음으로써 아래처럼 하나만 만들어서 사용하는 것
         */

        public void Wash(Mammal mammal)
        {
           if (mammal is Elephants)
            {
                var animal = mammal as Elephants;
                Console.WriteLine("코끼리를 씻깁니다.");
                animal.Poo();
            }
           else if (mammal is Dogs)
            {
                var animal = mammal as Dogs;
                Console.WriteLine("강아지를 씻깁니다.");
                animal.Bark();
            }
           else if (mammal is Cats)
            {
                var animal = mammal as Cats;
                Console.WriteLine("고양이를 씻깁니다.");
                animal.Meow();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region < 기본 상속 개념 >
            Parent p = new Parent("p");
            p.ParentMethod();

            Console.WriteLine("자식클래스 생성");
            Child c = new Child("c");
            /* 
             생성자 호출하면 부모클래스 생성자 먼저 실행 => 자식클래스 생성자 실행
                c from Parent 생성자
                c from Child 생성자
             이렇게 출력됨
            */
            c.ParentMethod(); // 자식 클래스는 부모 클래스의 속성, 기능을 모두 사용할 수 있음(public, protected만)
            c.ChildMethod();
            #endregion

            #region < 클래스간 형식 변환 >

            // Mammal m = new Mammal(); 기본적으로 객체생성. 생성자 호출하는 형태
            Mammal mammal = new Dogs();
            /*
             상속관계에서 자식클래스는 상속받은 부모클래스 + a 
             => 자식클래스는 부모클래스의 모든 것을 가지고 있지만
                부모클래스는 자식클래스의 모든 것을 가지고 있지 않음
             */

            // Dogs dods = new Mammal(); 은 사용 불가하지만.. 형변환 하고싶다면 아래처럼 is-as로 사용할 수 있음
            if (mammal is Dogs)
            {
                Dogs midDog = mammal as Dogs; //Dogs midDog = (Dogs)mamal로도 쓸 수 있음
                midDog.Bark();
            }

            Dogs dog2 = new Dogs();
            Cats cat2 = new Cats();
            Elephants el2 = new Elephants();

            Zookeeper keeper = new Zookeeper();
            keeper.Wash(dog2);
            keeper.Wash(cat2);
            keeper.Wash(el2);

            #endregion
        }
    }
}
