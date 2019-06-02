using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class contextTimKiemSanPham
    {
        private TimKiemSanPham timkiem;

        public void Context(TimKiemSanPham Timkiem)
        {
            this.timkiem = Timkiem;
        }

        public DataSet TimKiemSanPhamTheoGT(ref string error, string  giatri)
        {
            return timkiem.TimKiem(ref error, giatri);
        }
    }
}
