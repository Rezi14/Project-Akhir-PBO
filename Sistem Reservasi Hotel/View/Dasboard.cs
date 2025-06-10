using Sistem_Reservasi_Hotel.Controller;
using Sistem_Reservasi_Hotel.Models;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sistem_Reservasi_Hotel.View
{
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
        }

        private void Dasboard_Load(object sender, EventArgs e)
        {
            tampilkanreservasi();
            TampilkanKamarTersedia();
        }

        private void btnKelolaKamar_Click(object sender, EventArgs e)
        {
            new FormKelolaKamar().Show();
            this.Hide();
        }

        private void btnKelolaFasilitas_Click(object sender, EventArgs e)
        {
            new KelolaFasilitas().Show();
            this.Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            new FormReservasi().Show();
            this.Hide();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            new FormRiwayatTransaksi().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }



        private void tampilkanreservasi()
        {
            dataGridViewReservasi.AllowUserToAddRows = false;
            dataGridViewReservasi.DataSource = ReservasiController.GetReservasi();

            if (!dataGridViewReservasi.Columns.Contains("CheckOut"))
            {
                DataGridViewButtonColumn btncheckout = new DataGridViewButtonColumn
                {
                    Text = "Check Out",
                    Name = "CheckOut",
                    HeaderText = "Check Out",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewReservasi.Columns.Add(btncheckout);
            }

            // Ganti header kolom
            if (dataGridViewReservasi.Columns.Contains("id_reservasi"))
                dataGridViewReservasi.Columns["id_reservasi"].HeaderText = "ID Reservasi";

            if (dataGridViewReservasi.Columns.Contains("id_akun"))
                dataGridViewReservasi.Columns["id_akun"].HeaderText = "ID Akun";

            if (dataGridViewReservasi.Columns.Contains("nomor_kamar"))
                dataGridViewReservasi.Columns["nomor_kamar"].HeaderText = "Nomor Kamar";

            if (dataGridViewReservasi.Columns.Contains("nama_fasilitas_list"))
                dataGridViewReservasi.Columns["nama_fasilitas_list"].HeaderText = "Daftar Fasilitas"; // Sesuaikan dengan nama alias di query

            if (dataGridViewReservasi.Columns.Contains("nama_tamu"))
                dataGridViewReservasi.Columns["nama_tamu"].HeaderText = "Nama Tamu";

            if (dataGridViewReservasi.Columns.Contains("nomor_identitas_tamu"))
                dataGridViewReservasi.Columns["nomor_identitas_tamu"].HeaderText = "Nomor Identitas";

            if (dataGridViewReservasi.Columns.Contains("nomor_kontak_tamu"))
                dataGridViewReservasi.Columns["nomor_kontak_tamu"].HeaderText = "Nomor Kontak";

            if (dataGridViewReservasi.Columns.Contains("tanggal_checkin"))
                dataGridViewReservasi.Columns["tanggal_checkin"].HeaderText = "Tanggal Check-In";

            if (dataGridViewReservasi.Columns.Contains("tanggal_checkout"))
                dataGridViewReservasi.Columns["tanggal_checkout"].HeaderText = "Tanggal Check-Out";

            if (dataGridViewReservasi.Columns.Contains("status_reservasi"))
                dataGridViewReservasi.Columns["status_reservasi"].HeaderText = "Status Reservasi";
        }
        private void TampilkanKamarTersedia()
        {
            var kamarTersedia = KamarController.GetKamarTersedia();
            dataGridViewKamarTersedia.DataSource = kamarTersedia;

            if (kamarTersedia != null && dataGridViewKamarTersedia.Columns.Count > 0)
            {
                if (dataGridViewKamarTersedia.Columns.Contains("IDKamar"))
                    dataGridViewKamarTersedia.Columns["IDKamar"].HeaderText = "ID Kamar";

                if (dataGridViewKamarTersedia.Columns.Contains("NomorKamar"))
                    dataGridViewKamarTersedia.Columns["NomorKamar"].HeaderText = "Nomor Kamar";

                if (dataGridViewKamarTersedia.Columns.Contains("NamaTipe"))
                    dataGridViewKamarTersedia.Columns["NamaTipe"].HeaderText = "Tipe Kamar";

                if (dataGridViewKamarTersedia.Columns.Contains("HargaPerMalam"))
                    dataGridViewKamarTersedia.Columns["HargaPerMalam"].HeaderText = "Harga / Malam";

                if (dataGridViewKamarTersedia.Columns.Contains("StatusKamar"))
                    dataGridViewKamarTersedia.Columns["StatusKamar"].HeaderText = "Status Kamar";

                if (dataGridViewKamarTersedia.Columns.Contains("Deskripsi"))
                    dataGridViewKamarTersedia.Columns["Deskripsi"].HeaderText = "Deskripsi Kamar";
            }
        }

        private void dataGridViewReservasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewReservasi.Columns[e.ColumnIndex].Name == "CheckOut" && e.RowIndex >= 0)
            {
                var cellValue = dataGridViewReservasi?.Rows[e.RowIndex]?.Cells["id_reservasi"]?.Value;

                if (cellValue == null)
                {
                    MessageBox.Show("ID Reservasi tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idReservasi = Convert.ToInt32(cellValue);

                string metodePembayaran = Microsoft.VisualBasic.Interaction.InputBox(
                    "Masukkan metode pembayaran (Cash / QRIS):",
                    "Metode Pembayaran",
                    "Cash"
                );

                if (string.IsNullOrWhiteSpace(metodePembayaran))
                {
                    MessageBox.Show("Metode pembayaran wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalBayar = ReservasiController.Checkout(idReservasi, metodePembayaran);

                MessageBox.Show(
                    $"===== TOTAL BAYAR =====\n\nRp {totalBayar:N0}\n\n========================",
                    "TOTAL BAYAR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                tampilkanreservasi();
                TampilkanKamarTersedia();
            }

        }
    }
}
