using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Reservasi_Hotel.Models
{
    public class TipeKamar
    {
        public int IDTipeKamar { get; set; }
        public string NamaTipeKamar { get; set; }
        public decimal HargaPerMalam { get; set; }

        public static List<TipeKamar> GetAllTipeKamar()
        {
            var listTipeKamar = new List<TipeKamar>();
            try
            {
                using (var conn = DbContext.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_tipe_kamar, nama_tipe_kamar FROM tipe_kamar ORDER BY id_tipe_kamar";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listTipeKamar.Add(new TipeKamar
                            {
                                IDTipeKamar = reader.GetInt32(0),
                                NamaTipeKamar = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal memuat tipe kamar: " + ex.Message);
                throw;
            }
            return listTipeKamar;
        }
    }
}
