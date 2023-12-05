using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IHoaDonRepository
    {
        bool createHoaDon(HoaDon hoaDon);
        bool updateHoaDon(HoaDon hoaDon);
        bool deleteHoaDon(string id);
       public HoaDon getHoaDonByid(string id);
    }
}
