using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region < 특정 경로 하위 폴더 / 하위 파일 조회>
            //Directory = Folder
            string curDirectory = @"C:\DEV\Langs\Python311"; // "." 현재 디렉토리(상대경로) ".." 부모폴더(상대경로) "C:\Dev" 절대경로
            // '\'은 특수문자이기 때문에 그냥 쓸 수 없음. 리터럴 형태로 @ 붙여주거나 \\ 로 써야함. 리터럴은 여러 줄 문자열도 가능

            Console.WriteLine("현재 디렉토리 정보");

            var dirs = Directory.GetDirectories(curDirectory); // 무슨 타입 받을지 모르겠으면 일단 var
            foreach ( var dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.Write(dirInfo.Name);
                Console.WriteLine(" [{0}]", dirInfo.Attributes);
            }

            Console.WriteLine("현재 디렉토리 파일정보");
            
            var files = Directory.GetFiles(curDirectory);
            foreach ( var file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.Write(fileInfo.Name);
                Console.WriteLine(" [{0}]", fileInfo.Attributes);
            }
            #endregion

            string path = @"C:\Temp\Csharp_Bank"; // 만들고자 하는 폴더. 경로 쓸 때 \ 말고 / 도 가능함!
            string sfile = "Test2.log"; // 생성할 파일

            if(Directory.Exists(path))
            {
                Console.WriteLine("경로가 존재하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile); // C:\Temp\Csharp_Bank\Test.log
            }
            else
            {
                Console.WriteLine($"해당 경로가 없습니다 {path}, 만듭니다."); // "{0}", path 형태를 $로 변수 바로 사용할 수 있게 하는 것
                Directory.CreateDirectory(path);

                Console.WriteLine("경로를 생성하여 파일을 생성합니다.");
                File.Create(path + @"\" + sfile);
            }

        }
    }
}
