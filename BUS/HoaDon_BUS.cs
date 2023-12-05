using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.Interface;
using DTO;
using DAL.Interface;

namespace BUS
{
    public class HoaDon_BUS : IHoaDon_BUS
    {
        private IHoaDonRepository _hoaDonRepository;
        public HoaDon_BUS( IHoaDonRepository hoaDonRepository)
        {
            _hoaDonRepository = hoaDonRepository;
        }
        public bool createHoaDon(HoaDon hoaDon)
        {
            return   _hoaDonRepository.createHoaDon(hoaDon);
        }

        public bool deleteHoaDon(string id)
        {
            return _hoaDonRepository.deleteHoaDon(id);
        }

        public HoaDon getHoaDonById(string id)
        {
            return _hoaDonRepository.getHoaDonByid(id); 
        }

        public bool updateHoaDon(HoaDon hoaDon)
        {
            return _hoaDonRepository.updateHoaDon(hoaDon);
        }
    }
}
