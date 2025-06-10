using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistem_Reservasi_Hotel.Models
{
    public class Kamar
    {
        public int IDKamar { get; set; }
        public int IDTipeKamar { get; set; }
        public string NomorKamar { get; set; }
        public bool StatusKamar { get; set; }
        public string Deskripsi { get; set; }

        public static List<Kamar> GetAllKamar()
        {
            List<Kamar> listkamar = new List<Kamar>();
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM kamar ORDER BY id_kamar ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kamar kamar1 = new Kamar();
                            kamar1.IDKamar = (int)reader["id_kamar"];
                            kamar1.NomorKamar = (string)reader["nomor_kamar"];
                            kamar1.IDTipeKamar = (int)reader["id_tipe_kamar"];
                            kamar1.StatusKamar = (bool)reader["status_kamar"];
                            kamar1.Deskripsi = (string)reader["deskripsi"];
                            listkamar.Add(kamar1);
                        }
                    }
                }
            }
            return listkamar;
        }

        public static void InsertKamar(Kamar kamar)
        {
            string query = $"INSERT INTO kamar (nomor_kamar, id_tipe_kamar, status_kamar, deskripsi) VALUES(@nomor_kamar, @id_tipe_kamar, @status_kamar, @deskripsi)";
            try
            {
                using (var conn = DbContext.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomor_kamar", kamar.NomorKamar);
                        cmd.Parameters.AddWithValue("@id_tipe_kamar", kamar.IDTipeKamar);
                        cmd.Parameters.AddWithValue("@status_kamar", kamar.StatusKamar);
                        cmd.Parameters.AddWithValue("@deskripsi", kamar.Deskripsi);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void Update(Kamar kamar)
        {
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE public.kamar
                             SET nomor_kamar = @nomor_kamar,
                                 status_kamar = @status_kamar,
                                 deskripsi = @deskripsi,
                                 id_tipe_kamar = @id_tipe_kamar
                             WHERE id_kamar = @id_kamar";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_kamar", kamar.IDKamar);
                    cmd.Parameters.AddWithValue("@nomor_kamar", kamar.NomorKamar);
                    cmd.Parameters.AddWithValue("@id_tipe_kamar", kamar.IDTipeKamar);
                    cmd.Parameters.AddWithValue("@status_kamar", kamar.StatusKamar);
                    cmd.Parameters.AddWithValue("@deskripsi", kamar.Deskripsi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int idKamar)
        {
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM kamar WHERE id_kamar = @id_kamar";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_kamar", idKamar);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateStatusKamar(int idKamar, bool status)
        {
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string query = "UPDATE kamar SET status_kamar = @status WHERE id_kamar = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", idKamar);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<dynamic> GetKamarTersedia()
        {
            List<dynamic> list = new List<dynamic>();
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        k.id_kamar, 
                        k.nomor_kamar,
                        t.nama_tipe_kamar, 
                        t.harga_per_malam,
                        k.status_kamar,
                        k.deskripsi
                    FROM 
                        kamar k
                    JOIN 
                        tipe_kamar t ON k.id_tipe_kamar = t.id_tipe_kamar
                    WHERE 
                        k.status_kamar = true
                    ORDER BY id_kamar ASC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            IDKamar = reader["id_kamar"],
                            NomorKamar = reader["nomor_kamar"].ToString(),
                            NamaTipe = reader["nama_tipe_kamar"].ToString(),
                            HargaPerMalam = Convert.ToDecimal(reader["harga_per_malam"]),
                            StatusKamar = Convert.ToBoolean(reader["status_kamar"]),
                            Deskripsi = reader["deskripsi"]
                        });
                    }
                }
            }
            return list;
        }

        public static decimal GetHargaKamarByNomor(string nomorKamar)
        {
            decimal harga = 0;
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT t.harga_per_malam FROM kamar k JOIN tipe_kamar t ON k.id_tipe_kamar = t.id_tipe_kamar WHERE k.nomor_kamar = @nomor";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nomor", nomorKamar);
                    var result = cmd.ExecuteScalar();
                    if (result != null) harga = Convert.ToDecimal(result);
                }
            }
            return harga;
        }
        
    }
}