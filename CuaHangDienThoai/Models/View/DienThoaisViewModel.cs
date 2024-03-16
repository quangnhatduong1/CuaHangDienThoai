using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangDienThoai.Models.View
{
    public class DienThoaisViewModel
    {
        public DienThoai DienThoais { get; set; }
        public IEnumerable<ModelDienThoai> ModelDienThoais { get; set; }
    }
}
