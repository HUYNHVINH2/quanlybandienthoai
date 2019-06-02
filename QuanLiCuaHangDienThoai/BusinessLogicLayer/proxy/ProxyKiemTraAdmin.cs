using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ProxyKiemTraAdmin : checkAdmin
    {
        private checkAdmin CheckAdmin;
        public int KiemTraAdmin(int Quyen)
        {
            if (CheckAdmin == null)
            {
                CheckAdmin = new KetQuaDangNhap(Quyen);
            }
           return  CheckAdmin.KiemTraAdmin(Quyen);
        }
        public int KiemTra(int Quyen)
        {
            if (Quyen == 1)
            {
                return 1;
            }
            return 2;
        }
    }
}
