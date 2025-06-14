using Npgsql;
using Sistem_Reservasi_Hotel.Controller;
using Sistem_Reservasi_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistem_Reservasi_Hotel.View
{
    public partial class FormReservasi : Form
    {
        private List<Fasilitas> allFasilitas;

        public FormReservasi()
        {
            InitializeComponent();
            LoadNomorKamar();
            LoadFasilitas();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            var selectedKamarItem = cbNomorKamar1.SelectedItem;
            string nama_tamu = textNamaTamu1.Text;
            string nomor_identitas = textNomorIdentitas1.Text;
            string nomor_kontak = textNomorKontak1.Text;
            DateTime tanggal_check_in = dateTimeCheckIn1.Value;
            DateTime tanggal_check_out = dateTimeCheckOut1.Value;

            
            List<string> validationErrors = ReservasiController.ValidateReservasi(
                selectedKamarItem,
                nama_tamu,
                nomor_identitas,
                nomor_kontak,
                tanggal_check_in,
                tanggal_check_out
            );

            
            if (validationErrors.Any()) 
            {
                
                string allErrors = string.Join("\n", validationErrors);
                MessageBox.Show(allErrors, "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            try
            {
                string selectedKamar = selectedKamarItem.ToString();
                int id_kamar = int.Parse(selectedKamar.Split('-')[0].Trim());

                List<Fasilitas> selectedFasilitas = new List<Fasilitas>();
                foreach (object itemChecked in checkedListBoxFasilitas.CheckedItems)
                {
                    string itemText = itemChecked.ToString();
                    int idFasilitas = int.Parse(itemText.Split('-')[0].Trim());
                    Fasilitas f = allFasilitas.FirstOrDefault(fas => fas.IDFasilitas == idFasilitas);
                    if (f != null)
                    {
                        selectedFasilitas.Add(f);
                    }
                }

                Reservasi reservasi = new Reservasi
                {
                    IDKamar = id_kamar,
                    NamaTamu = nama_tamu.Trim(),
                    NomorIdentitasTamu = nomor_identitas.Trim(),
                    NomorKontakTamu = nomor_kontak.Trim(),
                    TanggalCheckIn = tanggal_check_in,
                    TanggalCheckOut = tanggal_check_out,
                    StatusReservasi = checkStatusReservasi1.Checked,
                    FasilitasTambahan = selectedFasilitas
                };

                ReservasiController.Insertreservasi(reservasi);
                KamarController.UpdateStatusKamar(id_kamar, false);

                MessageBox.Show("Reservasi berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Dasboard().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan reservasi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNomorKamar()
        {
            cbNomorKamar1.Items.Clear();
            try
            {
                using (var conn = DbContext.GetConnection())
                {
                    conn.Open();
                    string query = @"
                    SELECT id_kamar, nomor_kamar
                    from kamar
                    where status_kamar = true
                    ORDER BY id_kamar";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbNomorKamar1.Items.Add(reader.GetInt32(0) + " - " + reader.GetString(1));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load nomor kamar:\n" + ex.Message);
            }
        }

        private void LoadFasilitas()
        {
            checkedListBoxFasilitas.Items.Clear();
            allFasilitas = FasilitasController.GetAllFasilitasTersedia();
            foreach (var fasilitas in allFasilitas)
            {
                checkedListBoxFasilitas.Items.Add(fasilitas.IDFasilitas + " - " + fasilitas.NamaFasilitas);
            }
        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            LoadNomorKamar();
            LoadFasilitas();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Dasboard dasboard = new Dasboard();
            dasboard.Show();
            this.Hide();
        }

        private void cbNomorKamar1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxFasilitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}