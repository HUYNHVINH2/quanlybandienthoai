using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class KhachHangDTO
    {
        string sdt;
        string tenKH;
        string diachi;

        public string Sdt { get => sdt; set => sdt = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
