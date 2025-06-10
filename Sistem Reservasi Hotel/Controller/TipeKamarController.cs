using Sistem_Reservasi_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Reservasi_Hotel.Controller
{
    public class TipeKamarController
    {
        public static List<TipeKamar> GetAllTipeKamar()
        {
            return TipeKamar.GetAllTipeKamar();
        }
    }
}
