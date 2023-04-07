using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs19_interface
{
    interface ILogger
    {
        void WriteLog(string log);
    }

    interface IFormattableLogger : ILogger 
    {
        void WriteLog(string format, params object[] args); // args 다중 파라미터
    }

    class ConsoleLogger : ILogger // interface를 받는건 상속X implement(구현)이라고 부름
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    interface IHoverable
    {
        void Hover();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyHoverCar : Car, IFlyable, IHoverable
    {
        public void Fly()
        {
            Console.WriteLine("납니다");
        }

        public void Hover()
        {
            Console.WriteLine("물에서 달립니다");
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Stop()
        {
            Console.WriteLine("정지");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("안녕");

            IFormattableLogger logger2 = new ConsoleLogger2();
            NewMethod();

            void NewMethod()
            {
                // logger.WriteLog("{0} X {1} = {2}", 6, 5, 6 * 5);
            }
        }
    }
}
