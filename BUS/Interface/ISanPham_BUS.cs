using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface ISanPham_BUS
    {
        DanhMuc GetChiTetSanPham(string id);
        bool creatSanPham(DanhMuc sanPham);
        bool updateSanPham(DanhMuc sanPham);
        bool deleteSanPham(string masp);
    }
}
