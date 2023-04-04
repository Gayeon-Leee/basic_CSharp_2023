using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09_nullcondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo my_foo = null; // new Foo();
            // myfoo.member = 30;

            /*
            int? bar;
            if (my_foo != null)
            {
                bar = my_foo.member;
            }
            else
            {
                bar = null;
            }
            */
            int? bar = my_foo?.member; // myfoo가 null이 아니면 밑에있는 member변수 값을 집어넣으라는 위의 if문을 축약한 것임
        }
    }

    class Foo
    {
        public int member;
    }
}
