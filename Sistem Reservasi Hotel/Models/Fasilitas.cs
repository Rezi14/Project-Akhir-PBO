using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistem_Reservasi_Hotel.Models
{
    public class Fasilitas
    {
        public int IDFasilitas { get; set; }
        public string NamaFasilitas { get; set; }
        public decimal BiayaTambahan { get; set; }
        public string Deskripsi { get; set; }
        public bool StatusFasilitas { get; set; }

        public static List<Fasilitas> GetAllFasilitas()
        {
            List<Fasilitas> listfasilitas = new List<Fasilitas>();
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM fasilitas ORDER BY id_fasilitas ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fasilitas fasilitas = new Fasilitas();
                            fasilitas.IDFasilitas = (int)reader["id_fasilitas"];
                            fasilitas.NamaFasilitas = (string)reader["nama_fasilitas"];
                            fasilitas.BiayaTambahan = (decimal)reader["biaya_tambahan"];
                            fasilitas.Deskripsi = (string)reader["deskripsi"];
                            fasilitas.StatusFasilitas = (bool)reader["status_fasilitas"];
                            listfasilitas.Add(fasilitas);
                        }
                    }
                }
            }
            return listfasilitas;
        }

        public static List<Fasilitas> GetAllFasilitasTersedia()
        {
            List<Fasilitas> listfasilitas = new List<Fasilitas>();
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM fasilitas WHERE status_fasilitas = true ORDER BY id_fasilitas ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fasilitas fasilitas = new Fasilitas();
                            fasilitas.IDFasilitas = (int)reader["id_fasilitas"];
                            fasilitas.NamaFasilitas = (string)reader["nama_fasilitas"];
                            fasilitas.BiayaTambahan = (decimal)reader["biaya_tambahan"];
                            fasilitas.Deskripsi = (string)reader["deskripsi"];
                            fasilitas.StatusFasilitas = (bool)reader["status_fasilitas"];
                            listfasilitas.Add(fasilitas);
                        }
                    }
                }
            }
            return listfasilitas;
        }



        public static void InsertFasilitas(Fasilitas fasilitas)
        {
            string query = $"INSERT INTO fasilitas (nama_fasilitas, biaya_tambahan, deskripsi, status_fasilitas) VALUES(@nama_fasilitas, @biaya_tambahan, @deskripsi, @status_fasilitas)";
            try
            {
                using (var conn = DbContext.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_fasilitas", fasilitas.NamaFasilitas);
                        cmd.Parameters.AddWithValue("@biaya_tambahan", fasilitas.BiayaTambahan);
                        cmd.Parameters.AddWithValue("@deskripsi", fasilitas.Deskripsi);
                        cmd.Parameters.AddWithValue("@status_fasilitas", fasilitas.StatusFasilitas);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void Update(Fasilitas fasilitas)
        {
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE fasilitas
                             SET nama_fasilitas = @nama_fasilitas,
                                 biaya_tambahan = @biaya_tambahan,
                                 deskripsi = @deskripsi,
                                 status_fasilitas = @status_fasilitas
                             WHERE id_fasilitas = @id_fasilitas";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_fasilitas", fasilitas.IDFasilitas);
                    cmd.Parameters.AddWithValue("@nama_fasilitas", fasilitas.NamaFasilitas ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@biaya_tambahan", fasilitas.BiayaTambahan);
                    cmd.Parameters.AddWithValue("@deskripsi", fasilitas.Deskripsi ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@status_fasilitas", fasilitas.StatusFasilitas);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id_fasilitas)
        {
            using (var conn = DbContext.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM fasilitas WHERE id_fasilitas = @id_fasilitas";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_fasilitas", id_fasilitas);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}