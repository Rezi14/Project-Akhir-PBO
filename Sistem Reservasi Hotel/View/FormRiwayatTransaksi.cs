using Sistem_Reservasi_Hotel.Controller;
using Sistem_Reservasi_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistem_Reservasi_Hotel.View
{
    public partial class FormRiwayatTransaksi : Form
    {
        public FormRiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void FormRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            tampilkanriwayat();
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dasboard dasboard = new Dasboard();
            this.Hide();
            dasboard.ShowDialog();
            this.Close();
        }
        private void tampilkanriwayat()
        {
            var tampilkanriwayat = RiwayatTransaksiController.GetAllRiwayat();

            dataGridViewRiwayatTransaksi.DataSource = tampilkanriwayat;
            TampilkanTotalPendapatan(tampilkanriwayat);


            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDRiwayatTransaksi"))
                dataGridViewRiwayatTransaksi.Columns["IDRiwayatTransaksi"].HeaderText = "ID Riwayat Transaksi";
            dataGridViewRiwayatTransaksi.Columns["IDRiwayatTransaksi"].DisplayIndex = 0;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDReservasi"))
                dataGridViewRiwayatTransaksi.Columns["IDReservasi"].HeaderText = "ID Reservasi";
            dataGridViewRiwayatTransaksi.Columns["IDReservasi"].DisplayIndex = 1;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDAkun"))
                dataGridViewRiwayatTransaksi.Columns["IDAkun"].HeaderText = "ID Akun";
            dataGridViewRiwayatTransaksi.Columns["IDAkun"].DisplayIndex = 2;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaTamu"))
                dataGridViewRiwayatTransaksi.Columns["NamaTamu"].HeaderText = "Nama Tamu";
            dataGridViewRiwayatTransaksi.Columns["NamaTamu"].DisplayIndex = 3;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorIdentitasTamu"))
                dataGridViewRiwayatTransaksi.Columns["NomorIdentitasTamu"].HeaderText = "Nomor Identitas Tamu";
            dataGridViewRiwayatTransaksi.Columns["NomorIdentitasTamu"].DisplayIndex = 4;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorKontakTamu"))
                dataGridViewRiwayatTransaksi.Columns["NomorKontakTamu"].HeaderText = "Nomor Kontak Tamu";
            dataGridViewRiwayatTransaksi.Columns["NomorKontakTamu"].DisplayIndex = 5;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorKamar"))
                dataGridViewRiwayatTransaksi.Columns["NomorKamar"].HeaderText = "Nomor Kamar";
            dataGridViewRiwayatTransaksi.Columns["NomorKamar"].DisplayIndex = 6;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaFasilitas"))
                dataGridViewRiwayatTransaksi.Columns["NamaFasilitas"].HeaderText = "Nama Fasilitas";
            dataGridViewRiwayatTransaksi.Columns["NamaFasilitas"].DisplayIndex = 7;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckIn"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckIn"].HeaderText = "Tanggal Check In";
            dataGridViewRiwayatTransaksi.Columns["TanggalCheckIn"].DisplayIndex = 8;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckOut"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckOut"].HeaderText = "Tanggal Check Out";
            dataGridViewRiwayatTransaksi.Columns["TanggalCheckOut"].DisplayIndex = 9;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TotalBiaya"))
                dataGridViewRiwayatTransaksi.Columns["TotalBiaya"].HeaderText = "Total Biaya";
            dataGridViewRiwayatTransaksi.Columns["TotalBiaya"].DisplayIndex = 10;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("MetodePembayaran"))
                dataGridViewRiwayatTransaksi.Columns["MetodePembayaran"].HeaderText = "Metode Pembayaran";
            dataGridViewRiwayatTransaksi.Columns["MetodePembayaran"].DisplayIndex = 11;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalTransaksi"))
                dataGridViewRiwayatTransaksi.Columns["TanggalTransaksi"].HeaderText = "Tanggal Transaksi";
            dataGridViewRiwayatTransaksi.Columns["TanggalTransaksi"].DisplayIndex = 12;
        }
        private void btnFilterBulan_Click(object sender, EventArgs e)
        {
            int bulan = dtpFilterBulan.Value.Month;
            int tahun = dtpFilterBulan.Value.Year;

            var tampilkanriwayat = RiwayatTransaksiController.GetRiwayatTransaksiByBulan(bulan, tahun);
            dataGridViewRiwayatTransaksi.DataSource = tampilkanriwayat;
            TampilkanTotalPendapatan(tampilkanriwayat);

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDRiwayatTransaksi"))
                dataGridViewRiwayatTransaksi.Columns["IDRiwayatTransaksi"].HeaderText = "ID Riwayat Transaksi";
            dataGridViewRiwayatTransaksi.Columns["IDRiwayatTransaksi"].DisplayIndex = 0;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDReservasi"))
                dataGridViewRiwayatTransaksi.Columns["IDReservasi"].HeaderText = "ID Reservasi";
            dataGridViewRiwayatTransaksi.Columns["IDReservasi"].DisplayIndex = 1;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDAkun"))
                dataGridViewRiwayatTransaksi.Columns["IDAkun"].HeaderText = "ID Akun";
            dataGridViewRiwayatTransaksi.Columns["IDAkun"].DisplayIndex = 2;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaTamu"))
                dataGridViewRiwayatTransaksi.Columns["NamaTamu"].HeaderText = "Nama Tamu";
            dataGridViewRiwayatTransaksi.Columns["NamaTamu"].DisplayIndex = 3;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorIdentitasTamu"))
                dataGridViewRiwayatTransaksi.Columns["NomorIdentitasTamu"].HeaderText = "Nomor Identitas Tamu";
            dataGridViewRiwayatTransaksi.Columns["NomorIdentitasTamu"].DisplayIndex = 4;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorKontakTamu"))
                dataGridViewRiwayatTransaksi.Columns["NomorKontakTamu"].HeaderText = "Nomor Kontak Tamu";
            dataGridViewRiwayatTransaksi.Columns["NomorKontakTamu"].DisplayIndex = 5;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorKamar"))
                dataGridViewRiwayatTransaksi.Columns["NomorKamar"].HeaderText = "Nomor Kamar";
            dataGridViewRiwayatTransaksi.Columns["NomorKamar"].DisplayIndex = 6;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaFasilitas"))
                dataGridViewRiwayatTransaksi.Columns["NamaFasilitas"].HeaderText = "Nama Fasilitas";
            dataGridViewRiwayatTransaksi.Columns["NamaFasilitas"].DisplayIndex = 7;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckIn"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckIn"].HeaderText = "Tanggal Check In";
            dataGridViewRiwayatTransaksi.Columns["TanggalCheckIn"].DisplayIndex = 8;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckOut"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckOut"].HeaderText = "Tanggal Check Out";
            dataGridViewRiwayatTransaksi.Columns["TanggalCheckOut"].DisplayIndex = 9;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TotalBiaya"))
                dataGridViewRiwayatTransaksi.Columns["TotalBiaya"].HeaderText = "Total Biaya";
            dataGridViewRiwayatTransaksi.Columns["TotalBiaya"].DisplayIndex = 10;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("MetodePembayaran"))
                dataGridViewRiwayatTransaksi.Columns["MetodePembayaran"].HeaderText = "Metode Pembayaran";
            dataGridViewRiwayatTransaksi.Columns["MetodePembayaran"].DisplayIndex = 11;

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalTransaksi"))
                dataGridViewRiwayatTransaksi.Columns["TanggalTransaksi"].HeaderText = "Tanggal Transaksi";
            dataGridViewRiwayatTransaksi.Columns["TanggalTransaksi"].DisplayIndex = 12;

            if (dataGridViewRiwayatTransaksi.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada transaksi pada bulan yang dipilih.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tampilkanriwayat();
        }

        private void TampilkanTotalPendapatan(List<RiwayatTransaksi> data)
        {
            decimal total = data.Sum(x => x.TotalBiaya);
            lblTotalPendapatan.Text = $"Total Pendapatan: Rp{total:N0}";
        }

        private void dataGridViewRiwayatTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
