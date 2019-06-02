using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DangNhapBLL
    {
        DAL dal;
        public DangNhapBLL()
        {
            dal = new DAL();
        }
        //Hàm đăng nhập
        public DataSet DangNhap(ref string er, TaiKhoanDTO TaiKhoan)
        {
            return dal.ExecuteQueryDataSet("spDangNhap", CommandType.StoredProcedure, ref er,
                new SqlParameter("@userID", TaiKhoan.userID), new SqlParameter("@password", TaiKhoan.password));
        }
    }
}
