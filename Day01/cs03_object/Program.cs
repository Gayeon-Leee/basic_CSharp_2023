using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace cs03_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object형식
            // int == System.Int32
            // long == System.Int64
            long idata = 1024;
            Console.WriteLine(idata);
            Console.WriteLine(idata.GetType());

            object iobj = (object)idata; // 박싱 : 데이터타입 값을 object로 담아라
            Console.WriteLine(iobj);
            Console.WriteLine(iobj.GetType());

            long udata = (long)iobj;    // 언박싱 : object를 원래 데이터타입을 바꿈
            Console.WriteLine(udata);
            Console.WriteLine(udata.GetType());

            double ddata = 3.141592;
            object pobj = (object)ddata;
            double pdata = (double)pobj;

            Console.WriteLine(pobj);
            Console.WriteLine(pobj.GetType());
            Console.WriteLine(pdata);
            Console.WriteLine(pdata.GetType());

            short sdata = 32000;
            int indata = sdata;
            Console.WriteLine(indata);

            long lndata = long.MaxValue;
            Console.WriteLine(lndata);
            indata = (int)lndata;   // overflow
            Console.WriteLine(indata);

            // float double간 형변환
            float fval = 3.141592f;
            Console.WriteLine("fval = " + fval);
            double dval = (double)fval;
            Console.WriteLine("dval = " + dval);
            Console.WriteLine(fval == dval);
            Console.WriteLine(dval == 3.141592);

            // 실무에서 진짜 중요한거!!! 
            // 숫자 -> 문자열
            int numival = 1024;
            string strival = numival.ToString();
            Console.WriteLine(strival);
            Console.WriteLine(numival);
                // Console.WriteLine(numival == strival);
            Console.WriteLine(strival.GetType());

            double numdval = 3.14159265358979;
            string strdval = numdval.ToString();
            Console.WriteLine(strdval);

            // 문자열 -> 숫자로
            string originstr = "3000000"; 
                // 문자열 내에 숫자가 아닌 (특수)문자 or 정수인데 소수점(.) 있거나 하는 등의 경우 조심해야함..예외 발생
            int convval = Convert.ToInt32(originstr);
            Console.WriteLine(convval);
            originstr = "1.2345";
            float convfloat = float.Parse(originstr);
            Console.WriteLine(convfloat);

            //예외발생하지 않도록 형변환 하는 방법
            originstr = "123.0f";
            float ffval;
            float.TryParse(originstr, out ffval);   // 예외 발생하지 않게 숫자 변환
                // TryParse는 예외 발생시 값 0으로 대체(예외 없으면 원래 값으로) 
            Console.WriteLine(ffval);

            // 상수
            const double pi = 3.14159265358979;
            Console.WriteLine(pi);
            // pi = 4.56; const로 상수 선언했기 때문에 pi 값 바꿀 수 없음


        }
    }
}
