using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2__app
{
    internal class Program
    {
        class Boiler
        {
            public string brand;
            public int voltage;
            public int temperature;

            public string Brand { get; set; }
            public int Voltage 
            {
                get { return this.voltage; }
                set
                {
                    if(value == 110 || value == 220)
                {
                        voltage = value;
                    }
                else
                    {
                        voltage = 220;
                    }
                } 
            }
            public int Temperature
            {
                get { return this.temperature; }
                set
                {
                    if (value <= 5)
                    {
                        temperature = 5; 
                    }
                    else if (value >= 70)
                    {
                        temperature = 70;
                    }
                    else
                    {
                        temperature = value;
                    }
                }
            }

            internal void PrintAll()
            {
                Console.WriteLine(Brand);
                Console.WriteLine(Voltage);
                Console.WriteLine(Temperature);
            }
        }
        static void Main(string[] args)
        {
            Boiler Kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 120, Temperature = 75 };
            Kitturami.PrintAll();
        }
    }
}
