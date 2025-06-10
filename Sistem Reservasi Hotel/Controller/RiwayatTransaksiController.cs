using Sistem_Reservasi_Hotel.Models;
using System.Collections.Generic;

namespace Sistem_Reservasi_Hotel.Controller
{
    public class RiwayatTransaksiController
    {
        public static List<RiwayatTransaksi> GetAllRiwayat()
        {
            return RiwayatTransaksi.GetAllRiwayat();
        }

        public static List<RiwayatTransaksi> GetRiwayatTransaksiByBulan(int bulan, int tahun)
        {
            return RiwayatTransaksi.GetRiwayatTransaksiByBulan(bulan, tahun);
        }
    }
}