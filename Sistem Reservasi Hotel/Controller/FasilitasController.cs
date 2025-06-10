using Sistem_Reservasi_Hotel.Models;
using System.Collections.Generic;

namespace Sistem_Reservasi_Hotel.Controller
{
    public class FasilitasController
    {
        public static List<Fasilitas> GetAllFasilitas()
        {
            return Fasilitas.GetAllFasilitas();
        }

        public static void InsertFasilitas(Fasilitas fasilitas)
        {
            Fasilitas.InsertFasilitas(fasilitas);
        }

        public static void Update(Fasilitas fasilitas)
        {
            Fasilitas.Update(fasilitas);
        }

        public static void Delete(int id_fasilitas)
        {
            Fasilitas.Delete(id_fasilitas);
        }

        public static List<Fasilitas> GetAllFasilitasTersedia()
        {
            return Fasilitas.GetAllFasilitasTersedia();
        }

        public static List<string> ValidateFasilitas(string namaFasilitas, string biayaTambahanStr)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(namaFasilitas))
            {
                errors.Add("Nama fasilitas wajib diisi.");
            }

            if (string.IsNullOrWhiteSpace(biayaTambahanStr))
            {
                errors.Add("Biaya tambahan wajib diisi.");
            }
            else if (!decimal.TryParse(biayaTambahanStr, out _))
            {
                errors.Add("Biaya tambahan harus berupa angka yang valid.");
            }

            return errors;
        }
    }
}