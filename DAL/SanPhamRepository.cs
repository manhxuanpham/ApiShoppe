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
        public DanhMuc GetChiTietSanPham(string masp)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "LayThongTinSanPham",
                     "@MaSP", masp);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<DanhMuc>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        


        public bool createsanpham(DanhMuc sanPham)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "ThemSanPham",
                "@MaSp", sanPham.maSanPham,
                "@TenSP", sanPham.tenSanPham,
                "@SoLuong", sanPham.soLuong,
                "@DonGia", sanPham.donGia,
                "@MoTa", sanPham.moTa,
                "@MaDM", sanPham.maDM,
                "@HinhAnh", sanPham.hinhAnh,
                "@MaNCC", sanPham.maNCC);

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



        public bool updatesanpham(DanhMuc sanPham)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "CapNhatThongTinSanPham",
                "@MaSP", sanPham.maSanPham,
                "@TenSP", sanPham.tenSanPham,
                 "@SoLuong", sanPham.soLuong,
                 "@DonGia", sanPham.donGia,
                 "@MoTa", sanPham.moTa,
                 "@MaDM", sanPham.maDM,
                 "@HinhAnh", sanPham.hinhAnh,
                "@MaNCC", sanPham.maNCC);

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