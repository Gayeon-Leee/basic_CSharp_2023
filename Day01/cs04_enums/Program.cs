using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs04_enums
{
    internal class Program
    {
        enum Hometown
        {
           SEOUL = 1,
           DAEJEON = 2,
           DAEGU = 4,
           BUSAN = 6,
           JEJU = 9 // 열거형은 숫자로 값 지정할 수 있음. 지정 안하면 default는 순서대로 오름차순
           //ctrl u 소문자 ctrl shift u 대문자

        };
        static void Main(string[] args)
        {
            Hometown myHomeTown;

            myHomeTown = Hometown.BUSAN;

            if (myHomeTown == Hometown.SEOUL)
            {
                Console.WriteLine("서울 출신이시군요!");
            } 
            else if (myHomeTown == Hometown.DAEJEON) 
            {
                Console.WriteLine("충청도에요");
            } 
            else if (myHomeTown == Hometown.DAEGU)
            {
                Console.WriteLine("대구에요");
            }
            else if (myHomeTown == Hometown.BUSAN) 
            {
                Console.WriteLine("부산입니다");
            }

        }
    }
}
