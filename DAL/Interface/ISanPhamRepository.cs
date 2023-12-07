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
        SanPham GetChiTietSanPham(string ma);
        bool createsanpham(SanPham sanPham);
        bool updatesanpham(SanPham sanPham);
        bool deletesanpham(string masp);
        public List<SanPham> GetProductPage(int pageIndex, int pageSize);
        public List<SanPham> filterProduct()
    }
}
