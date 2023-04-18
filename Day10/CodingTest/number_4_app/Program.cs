using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> rainbow = new Dictionary<string, string>();
            rainbow["Red"] = "빨간색";
            rainbow["Orange"] = "주황색";
            rainbow["Yello"] = "노란색";
            rainbow["Green"] = "초록색";
            rainbow["Blue"] = "파란색";
            rainbow["navy"] = "남색";
            rainbow["Purple"] = "보라색";
         

            Console.Write("무지개 색은 ");
            foreach (string value in rainbow.Values)
            { 
                Console.Write($"{value}, ");   
            }
            Console.WriteLine("입니다.");

            Console.WriteLine("");
            Console.WriteLine("Key와 Value 확인");

            string color = "Purple";
            Console.WriteLine($"{color}은 {rainbow[color]}입니다.");
        }
    }
}
