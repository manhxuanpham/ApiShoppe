using DTO;
using DAL;
using BUS.Interface;
namespace BUS
{

    public class SanPham_BUS : ISanPham_BUS
    {   
        private ISanPhamRepository _res;
        public SanPham_BUS(ISanPhamRepository res)
        {
            _res = res;
        }
        public SanPham GetChiTetSanPham(string id)
        {
            return _res.GetChiTietSanPham(id);
        }     

        public bool creatSanPham(SanPham sanPham)
        {
            return _res.createsanpham(sanPham);
        }

        public bool updateSanPham(SanPham sanPham)
        {
            return _res.updatesanpham(sanPham);

        }

        public bool deleteSanPham(string masp)
        {
            return _res.deletesanpham(masp);

        }
        public List<SanPham> GetProductPage(int pageNumber,int pageSize )
        {
            return _res.GetProductPage(pageNumber,pageSize);
        }
    }
}

