using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs23_collection
{
    class CustomEnumerator : IEnumerable // foreach를 쓸 수 있는 객체로 만드는것
    {
        int[] list = { 1, 3, 5, 7, 9 };

        public IEnumerator GetEnumerator()
        {
            yield return list[0]; // 일반 return이랑 달리 메서드를 빠져나가지 않고 값만 돌려줌
            yield return list[1];
            yield return list[2];
            yield return list[3];
            yield break;
            yield return list[4];   // 위에 break 때문에 X

        }

    }

    class MyArrayList : IEnumerator, IEnumerable
    {
        int[] array; // 배열값 집어넣는 곳
        int position = -1; // 인덱스

        public MyArrayList()
        {
            array = new int[3]; // 기본 크기 3으로 초기화
        }

        // 인덱서 프로퍼티
        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("MyArrayList Resize : {0}", array.Length); // 개발시에 보는거기때문에 완료되면 주석처리
                }

                array[index] = value;
            }
        }

        #region <IEnumerable 인터페이스 구현 >
        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
        #endregion

        #region < IEnumerator 인터페이스 구현 >

        public object Current
        {
            get
            {
                return array[position];
            }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        #endregion
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new CustomEnumerator();

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            var myArrayList = new MyArrayList();
            for (var i = 0; i <=5; i++)
            {
                myArrayList[i] = i; // indexer 프로퍼티를 만들었기 때문에 가능
            }

            foreach (var item in myArrayList) // IEnumerable 인터페이스를 구현했기때문에 가능
            {
                Console.WriteLine(item); 
            }
        }
    }
}
