using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs30_filereadwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty; // 텍스트를 읽어와서 출력
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(@".\python.py");

                line = reader.ReadLine(); // 한줄 씩 읽음

                while (line != null)
                {
                    Console.WriteLine(line); // 한 줄 읽은 것 출력

                    line = reader.ReadLine(); // 다음 줄 읽음
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외! {e.Message}");
            }
            finally
            {
                reader.Close(); // 파일을 읽으면 무조건 Close 해줘야함! 예외 발생 상관없이 처리해야해서 finally에 적는 것
            }

            //쓰기
            StreamWriter writer = new StreamWriter(@".\pythonByCsharp.py");

            try
            {
                writer.WriteLine("import sys");
                writer.WriteLine("");
                writer.WriteLine("print(sys.excutable)");
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외! {e.Message}");
            }
            finally
            {
                writer.Close();
            }
            Console.WriteLine("파일생성 완료!");

        }
    }
}
