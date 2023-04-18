using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace number_3_app
{
    internal class Program
    {
        class Car
        {
            public string Name;
            public string Maker;
            public string Color;
            public int YearModel;
            public int MaxSpeed;
            public string UniqueNumber;

            internal void Start()
            {
                Console.WriteLine($"{Name}의 시동을 겁니다.");
            }

            internal void Accelerate()
            {
                Console.WriteLine($"최대시속 {MaxSpeed}km/h로 가속합니다.");
            }

            internal void TurnRight()
            {
                Console.WriteLine($"{Name}을 우회전 합니다.");
            }

            internal void Brake()
            {
                Console.WriteLine($"{Name}의 브레이크를 밟습니다.");
            }

        }

        class ElectrincCar : Car 
        {
            internal void Recharge() {}
        }

        class HybridCar : ElectrincCar
        {
            internal new void Recharge()
            {
                Console.WriteLine("달리면서 배터리를 충전합니다.");
            }
        }

        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();
        }
    }
}
