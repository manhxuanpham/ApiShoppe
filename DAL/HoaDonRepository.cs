using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private IDatabaseHelper _dbHelper;
        public HoaDonRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public bool createHoaDon(HoaDon hoaDon)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadon_create",
                "@MaHD", hoaDon.MaHD,
                "@TrangThai", hoaDon.TrangThai,
                "@NgayTao",hoaDon.NgayTao,
                "@NgayDuyet",hoaDon.NgayDuyet,
                "@HoTen", hoaDon.HoTen,
                "@SDT",hoaDon.SDT,
                "Email", hoaDon.Email,
                "DiaChi", hoaDon.DiaChi,
                "@list_json_chitiethoadon", hoaDon.list_json_chitiethoadon != null ? MessageConvert.SerializeObject(hoaDon.list_json_chitiethoadon) : null);
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

        public bool deleteHoaDon(string id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadon_delete",
                "@MaDH", id);
                
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

        public HoaDon getHoaDonByid(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadon_get_by_id",
                     "@MaHD", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<HoaDon>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool updateHoaDon(HoaDon hoaDon)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadon_update",
                "@MaHD", hoaDon.MaHD,
                "@TrangThai", hoaDon.TrangThai,
                "@NgayTao", hoaDon.NgayTao,
                "NgayDuyet", hoaDon.NgayDuyet,
                "@HoTen", hoaDon.HoTen,
                "@SDT", hoaDon.SDT,
                "@Email", hoaDon.Email,
                "@DiaChi", hoaDon.DiaChi,
                "@list_json_chitiethoadon", hoaDon.list_json_chitiethoadon != null ? MessageConvert.SerializeObject(hoaDon.list_json_chitiethoadon) : null);
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
