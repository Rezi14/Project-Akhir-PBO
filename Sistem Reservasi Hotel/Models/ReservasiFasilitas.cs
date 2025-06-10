using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Reservasi_Hotel.Models
{
    public class ReservasiFasilitas
    {
        public int IDReservasiFasilitas { get; set; }
        public int IDReservasi { get; set; }
        public int IDFasilitas { get; set; }
    }
}