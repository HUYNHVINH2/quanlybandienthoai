using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
        public class TaiKhoanDTO
        {
            private static TaiKhoanDTO inforUer;

            private TaiKhoanDTO() { }

            public static TaiKhoanDTO getInstanceinforUer()
            {
                if (inforUer == null)
                {
                    inforUer = new TaiKhoanDTO();
                }
                return inforUer;
            }
            public string userID;
            public string password;
        }
    }

