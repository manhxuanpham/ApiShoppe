using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface  IDanhMuc_BUS
    {
        DanhMuc getDanhMucbyId(string madm);
        bool addDanhMuc(DanhMuc danhMuc);
        bool updateDanhMuc(DanhMuc danhMuc);
        bool deleteDanhMuc(string madm);

    }
}
