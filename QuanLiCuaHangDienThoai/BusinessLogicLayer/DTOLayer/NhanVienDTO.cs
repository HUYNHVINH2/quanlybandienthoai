using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NhanVienDTO
    {
        private string tenNV;
        private string diaChi;
        private string email;
        private int soChungMinh;
        private string sDT;
        int iDNV;

        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public int SoChungMinh { get => soChungMinh; set => soChungMinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public int IDNV { get => iDNV; set => iDNV = value; }
    }
}
