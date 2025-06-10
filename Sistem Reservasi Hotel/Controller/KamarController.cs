using Sistem_Reservasi_Hotel.Models;
using System.Collections.Generic;

namespace Sistem_Reservasi_Hotel.Controller
{
    public class KamarController
    {
        public static List<Kamar> GetAllKamar()
        {
            return Kamar.GetAllKamar();
        }

        public static void InsertKamar(Kamar kamar)
        {
            Kamar.InsertKamar(kamar);
        }

        public static void Update(Kamar kamar)
        {
            Kamar.Update(kamar);
        }

        public static void Delete(int idKamar)
        {
            Kamar.Delete(idKamar);
        }

        public static void UpdateStatusKamar(int idKamar, bool status)
        {
            Kamar.UpdateStatusKamar(idKamar, status);
        }

        public static List<dynamic> GetKamarTersedia()
        {
            return Kamar.GetKamarTersedia();
        }
        public static List<string> ValidateKamar(string nomorKamar, object selectedTipeKamar)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(nomorKamar))
            {
                errors.Add("Nomor kamar wajib diisi.");
            }

            if (selectedTipeKamar == null)
            {
                errors.Add("Tipe kamar wajib dipilih.");
            }

            return errors;
        }
    }
}