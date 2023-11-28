using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhMucRepository : IDanhMucRepository
    {
        private IDatabaseHelper _dbHelper;
        public DanhMucRepository(IDatabaseHelper dbhelper)
        {
            this._dbHelper = dbhelper;
        }

        public bool createDanhMuc(DanhMuc danhMuc)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "createDanhMuc",
                "@MaDM", danhMuc.MaDM,
                "@tenDM", danhMuc.TenDM,
                "@noidung", danhMuc.NoiDung);

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

        public bool deleteDanhMuc(string maDM)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "deleteDanhMuc",
                "@MaDM", maDM);

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

        public DanhMuc getDanhMuc(string maDM)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getDanhMucById",
                "@MaDM", maDM);

                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<DanhMuc>().FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool updateDanhMuc(DanhMuc danhMuc)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "updateDanhMuc",
                "@MaDM", danhMuc.MaDM,
                "@tenDM", danhMuc.MaDM,
                "@noidung", danhMuc.NoiDung);

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
