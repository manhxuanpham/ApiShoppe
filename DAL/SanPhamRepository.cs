using DTO;
namespace DAL
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private IDatabaseHelper _dbHelper;

        public SanPhamRepository(IDatabaseHelper dbhelper)
        {
            this._dbHelper = dbhelper;
        }
        public SanPham GetChiTietSanPham(string masp)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "LayThongTinSanPham",
                     "@MaSP", masp);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<SanPham>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

  

        public bool createsanpham(SanPham sanPham)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "ThemSanPham",
                "@MaSp", sanPham.MaSP,
                "@TenSP", sanPham.TenSP,
                "@SoLuong", sanPham.SoLuong,
                "@DonGia", sanPham.DonGia,
                "@MoTa", sanPham.MoTa,
                "@MaDM", sanPham.MaDM,
                "@HinhAnh", sanPham.HinhAnh,
                "@MaNCC", sanPham.MaNCC);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;

            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }



        public bool updatesanpham(SanPham sanPham)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "CapNhatThongTinSanPham",
                "@MaSP", sanPham.MaSP,
                "@TenSP", sanPham.TenSP,
                 "@SoLuong", sanPham.SoLuong,
                 "@DonGia", sanPham.DonGia,
                 "@MoTa", sanPham.MoTa,
                 "@MaDM", sanPham.MaDM,
                 "@HinhAnh", sanPham.HinhAnh,
                "@MaNCC", sanPham.MaNCC);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool deletesanpham(string masp)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "XoaSanPham",
                "@MaSP", masp);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}