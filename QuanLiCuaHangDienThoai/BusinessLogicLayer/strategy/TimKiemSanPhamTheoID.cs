using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TimKiemSanPhamTheoID : TimKiemSanPham
    {
        public DataSet TimKiem(ref string error, string GiaTri)
        {
            SanPhamBLL sanpham = new SanPhamBLL();
            DataSet data = new DataSet();
            int result = Int32.Parse(GiaTri); 
            return sanpham.TimSPTheoID(ref error, result);
        }
    }
}
