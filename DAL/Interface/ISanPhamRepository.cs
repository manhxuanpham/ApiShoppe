using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial interface ISanPhamRepository
    {
        DanhMuc GetChiTietSanPham(string ma);
        bool createsanpham(DanhMuc sanPham);
        bool updatesanpham(DanhMuc sanPham);
        bool deletesanpham(string masp);
    }
}
