using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf13_bookrentalshop.Helpers
{
    internal class Commons
    {
        // 모든 프로그램상에서 다 사용 가능
        // DB연결 문자열은 여기서만 수정하면 됨
        public static readonly string ConnString = "Server=localhost;" + 
                                                   "Port=3306;" + 
                                                   "Database=Bookrentalshop;" + 
                                                   "Uid=root;" + 
                                                   "Pwd=12345";
    }
}
