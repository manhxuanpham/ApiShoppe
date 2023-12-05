using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Interface
{
    public interface IHoaDon_BUS
    {
        bool createHoaDon(HoaDon hoaDon);
        bool updateHoaDon(HoaDon hoaDon);
        bool deleteHoaDon(string id);
        HoaDon getHoaDonById(string id);
    }
}
