using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs24_generic
{
    #region < 일반화 클래스 >
    class MyArray<T> where T : class // 일반화 클래스 // where T : class는 자주 사용하지는 않지만 알아둘 것 클래스 타입에서만 사용가능
    {
        T[] array;
    }
    /*
    class MyArray_float
    {
        float[] array;
    }

    class MyArray_double
    {
        double[] array;
    }*/
    #endregion


    internal class Program
    {
        #region < 일반화 메서드 >
        // 하나로 일반화
        static void CopyArray<T>(T[] source, T[] target)
        { 
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        /*
        T 써서 모든 타입 쓸 수 있게 하는 것! 아니면 이렇게 하나하나 타입마다 메서드 만들어줘야함
        static void CopyArray(long[] source, long[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void CopyArray(float[] source, float[] target)
        {
            for (var i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }*/
        #endregion

        static void Main(string[] args)
        {
            #region < 일반화 시키기 >
            int[] source = {2, 4, 6, 8, 10};
            int[] target = new int[source.Length];
            
            CopyArray(source, target);
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            long[] source2 = { 2100000, 2300000, 3300000, 5600000, 7800000 };
            long[] target2 = new long[source2.Length];

            CopyArray(source2, target2);
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }

            float[] source3 = { 3.14f, 3.15f, 3.16f, 3.17f, 3.18f, 3.19f };
            float[] target3 = new float[source3.Length];

            CopyArray(source3, target3);
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }
            #endregion

            // 일반화 컬렉션
            List<int> list = new List<int>();
            for (var i = 10; i > 0; i--)
            {
                list.Add(i);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(3); // 7 삭제

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //아래와 같은 일반화 컬렉션 실무에서 자주 볼 수 있음!  -- 제일 많이 사용
            List<MyArray<string>> myStringArray = new List<MyArray<string>>();

            //일반화 스택
            Stack<float> stFloats = new Stack<float>();
            stFloats.Push(3.15f);
            stFloats.Push(4.28f);
            stFloats.Push(7.25f);

            while (stFloats.Count > 0)  // foreach(var item in stFloats)도 출력되긴 하지만 스택은 push-pop이 기본
            {
                Console.WriteLine(stFloats.Pop());
            }

            //일반화 큐
            Queue<string> qString = new Queue<string>();
            qString.Enqueue("Hello");
            qString.Enqueue("World");
            qString.Enqueue("My");
            qString.Enqueue("C#");

            while (qString.Count > 0) // 마찬가지로 큐는 Enqueue-Dequeue
            {
                Console.WriteLine(qString.Dequeue());
            }

            // 일반화 딕셔너리 -- 일반화 컬렉션 다음으로 많이 사용
            Dictionary<string, int> dicNumbers = new Dictionary<string, int>();
            dicNumbers["하나"] = 1;
            dicNumbers["둘"] = 2;
            dicNumbers["셋"] = 3;
            dicNumbers["넷"] = 4;

            Console.WriteLine(dicNumbers["셋"]);
        }
    }
}
