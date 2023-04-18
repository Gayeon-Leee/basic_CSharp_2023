using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_1_app
{
    internal class Program
    {
        class Boiler
        {
            public string brand;
            public int voltage;
            public int temperature;

            public string Brand { get; set; }
            public int Voltage { get; set; }
            public int Temperature { get; set; }

            internal void PrintAll()
            {
                Console.WriteLine(Brand);
                Console.WriteLine(Voltage);
                Console.WriteLine(Temperature);
            }
        }
        static void Main(string[] args)
        {
            Boiler Kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            Kitturami.PrintAll();
        }
    }
}
