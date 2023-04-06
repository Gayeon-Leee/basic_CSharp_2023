using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs16_inheritance
{
    class Base // 기반(부모) 클래스    
    {
        protected string Name;  // protected는 자식 클래스에서 사용 자체는 가능하지만 private와 같은 기능으로 보기 때문에 사용 어려움
        private string Color;   // 자식 클래스에서 상속 받으려면 private은 안써야함 => 상속 할거면 protected로 변경할 것!
        public int Age;

        public Base(string Name, string Color, int Age) 
        {
            this.Name = Name;
            this.Color = Color;
            this.Age = Age;
            Console.WriteLine("{0}.Base()", Name);
        }

        public void BaseMethod() 
        {
            Console.WriteLine("{0}.BaseMethod()", Name);
        }

        public void GetColor()
        { 
            Console.WriteLine("{0}.Base() {1}", Name, Color); 
        }
    }

    class Child : Base // 상속 받은 이후에 Base의 Name, Color, Age를 새로 만들지 않았음
    { 
        public Child(string Name, string Color, int Age) : base(Name, Color, Age)
        {
            Console.WriteLine("{0}.Child()", Name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0}.ChildMethod", Name);
        }

        public void GetColor()
        {
            // Console.WriteLine(Color); Color 접근 불가
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base("NameB", "White", 1);
            b.BaseMethod();
            b.GetColor();

            Child c = new Child("NameC", "Black", 2);
            c.BaseMethod();
            c.ChildMethod();
            c.GetColor();   // Base클래스의 GetColor() 실행되고 Black받지만.. c에서 Color에 접근 불가
        }
    }
}
