using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class TimKiemTheoTen : TimKiemSanPham
    {
        public DataSet TimKiem(ref string error, string GiaTri)
        {
            SanPhamBLL sanpham = new SanPhamBLL();
            DataSet data = new DataSet();
              
            return sanpham.DSSanPhamTheoTen(ref error, GiaTri); 
        }
    }
}
