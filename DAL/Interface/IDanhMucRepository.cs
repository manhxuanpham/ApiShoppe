using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public partial interface IDanhMucRepository
    {
        bool createDanhMuc(DanhMuc danhMuc );
        bool updateDanhMuc(DanhMuc danhMuc);
        bool deleteDanhMuc(string maDM);
        DanhMuc getDanhMuc(string maDM);
    }
}
