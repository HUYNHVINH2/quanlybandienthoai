using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
   public class KetQuaDangNhap : checkAdmin
    {
        public KetQuaDangNhap(int Quyen)
        {
            KiemTraAdmin(Quyen);
        }

        public int KiemTraAdmin(int Quyen)
        {
            if (Quyen == 1)
            {
                return 1;
            }
            return 2;
        }
    }
}
