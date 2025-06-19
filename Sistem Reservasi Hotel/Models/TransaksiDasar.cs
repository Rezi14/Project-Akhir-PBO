using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Reservasi_Hotel.Models
{
    // UBAH: Ini adalah kelas abstract baru sebagai kelas dasar (parent class).
    public abstract class TransaksiDasar
    {
        // Properti yang sama-sama dimiliki oleh Reservasi dan RiwayatTransaksi
        public int IDReservasi { get; set; }
        public int IDAkun { get; set; }
        public string NamaTamu { get; set; }
        public string NomorIdentitasTamu { get; set; }
        public string NomorKontakTamu { get; set; }
        public DateTime TanggalCheckIn { get; set; }
        public DateTime TanggalCheckOut { get; set; }
        public string NomorKamar { get; set; }

        public virtual decimal HitungBiayaTotal(decimal hargaPerMalam)
        {
            int jumlahMalam = (int)Math.Ceiling((TanggalCheckOut - TanggalCheckIn).TotalDays);
            if (jumlahMalam <= 0) jumlahMalam = 1;
            return hargaPerMalam * jumlahMalam;
        }
    }
}