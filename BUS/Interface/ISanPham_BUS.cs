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
        SanPham GetChiTetSanPham(string id);
        bool creatSanPham(SanPham sanPham);
        bool updateSanPham(SanPham sanPham);
        bool deleteSanPham(string masp);
        public List<SanPham> GetProductPage(int pageIndex, int pageSize);
    }
}
