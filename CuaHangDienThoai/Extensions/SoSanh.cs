
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangDienThoai.Extensions
{
    public static class SoSanh
    {
        public static bool TonTai(List<string> danhSach, string chuoi)
        {
            foreach(string a in danhSach)
            {
                if (a == chuoi)
                    return true;
            }
            return false;
        }
    }
}
