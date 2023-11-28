using BUS.Interface;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DanhMuc_BUS : IDanhMuc_BUS
    {
        private IDanhMucRepository _res;
        public DanhMuc_BUS( IDanhMucRepository mucRepository)
        {
            _res = mucRepository;
        }

        public bool addDanhMuc(DanhMuc danhMuc)
        {
            return _res.createDanhMuc(danhMuc);
           
        }

        public bool deleteDanhMuc(string madm)
        {
            return _res.deleteDanhMuc(madm);
        }

        public DanhMuc getDanhMucbyId(string madm)
        {
            return _res.getDanhMuc(madm);
        }

        public bool updateDanhMuc(DanhMuc danhMuc)
        {
            return _res.updateDanhMuc(danhMuc);
        }
    }
}
