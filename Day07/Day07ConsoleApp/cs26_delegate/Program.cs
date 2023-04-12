using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs26_delegate
{
    //대리자 사용 선언
    delegate int CalcDelegate(int a, int b);

    delegate int Compare(int a, int b); // a, b 중에 뭐가 큰지 비교하는 대리자
    #region < 대리자 기본 >
    class Calc
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b) 
            // static은 실행될 때 무조건 최초 메모리에 장착 - 프로그램 끝날 때 까지 남아있음
            // 프로그램 실행 중에는 언제든지 접근 가능(private 쓰면 안됨)
        {
            return a - b;
        }
        
    }
    #endregion
    
    internal class Program
    {
        static int AscendCompare(int a, int b) // 오름차순 비교
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if(a == b) return 0;
            else return -1;
        }

        static void BubbelSort(int[] DataSet, Compare comparer) // 대리자 사용
        {
            int i = 0, j = 0, temp = 0;

            for(i =  0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j+1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        /* 대리자 안쓰면 아래처럼 오름차순, 내림차순 내용 전부 넣어줘야 하는 것!
        static void BubbelSort2(int[] DataSet, bool isAscend)
        {
            int i = 0, j = 0, temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (isAscend = true)
                    {
                        if (DataSet[j] > DataSet[j + 1])
                        {
                            temp = DataSet[j + 1];
                            DataSet[j + 1] = DataSet[j];
                            DataSet[j] = temp;
                        }
                    }
                    else
                    {
                        if (DataSet[j] < DataSet[j + 1])
                        {
                            temp = DataSet[j + 1];
                            DataSet[j + 1] = DataSet[j];
                            DataSet[j] = temp;
                        }
                    }
                }
            }
        }
        */

        static void Main(string[] args)
        {
            #region < 대리자 기본 예>
            // 일반적인 클래스 사용 방식 - 직접 호출
            Calc normalCalc = new Calc();
            int x = 10; int y = 15;
            
            Console.WriteLine(normalCalc.Plus(x, y)); // static 아닌건 이런 형태로 가능하지만
            int res = Calc.Minus(x, y); // static은 무조건 변수에 값을 받고 사용해야함

            // 대리자를 사용하는 방식 - 대리자가 대신 실행
            x = 93; y = 11;
            Calc delCalc = new Calc();
            CalcDelegate CallBack;

            CallBack = new CalcDelegate(delCalc.Plus);
            int res2 = CallBack(x,y); // Clac.Plus() 대신 호출
            Console.WriteLine(res2);

            CallBack = new CalcDelegate(Calc.Minus); // static이라서 호출 형태 다른 것!
            res2 = CallBack(x,y);
            Console.WriteLine(res2);
            #endregion

            int[] origin = { 4, 7, 8, 2, 9, 1 };

            Console.WriteLine("오름차순 버블 정렬");

            BubbelSort(origin, new Compare(AscendCompare));

            foreach (var item in origin) 
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("내림차순 버블 정렬");

            BubbelSort(origin, new Compare(DescendCompare));
            foreach (var item in origin)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }   
    }
}
