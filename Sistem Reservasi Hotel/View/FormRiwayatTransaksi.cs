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
            var data = RiwayatTransaksiController.GetAllRiwayat();
            dataGridViewRiwayatTransaksi.DataSource = data;

        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dasboard dasboard = new Dasboard();
            dasboard.Show();
            this.Hide();
        }
        private void tampilkanriwayat()
        {
            var tampilkanriwayat = RiwayatTransaksiController.GetAllRiwayat();

            
            dataGridViewRiwayatTransaksi.DataSource = tampilkanriwayat;
            TampilkanTotalPendapatan(tampilkanriwayat);

            
            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDRiwayatTransaksi"))
                dataGridViewRiwayatTransaksi.Columns["IDRiwayatTransaksi"].HeaderText = "ID Riwayat Transaksi";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDReservasi"))
                dataGridViewRiwayatTransaksi.Columns["IDReservasi"].HeaderText = "ID Reservasi";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDAkun"))
                dataGridViewRiwayatTransaksi.Columns["IDAkun"].HeaderText = "ID Akun";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaTamu"))
                dataGridViewRiwayatTransaksi.Columns["NamaTamu"].HeaderText = "Nama Tamu";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorIdentitasTamu"))
                dataGridViewRiwayatTransaksi.Columns["NomorIdentitasTamu"].HeaderText = "Nomor Identitas Tamu";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorKamar"))
                dataGridViewRiwayatTransaksi.Columns["NomorKamar"].HeaderText = "Nomor Kamar";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaFasilitas"))
                dataGridViewRiwayatTransaksi.Columns["NamaFasilitas"].HeaderText = "Nama Fasilitas";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckIn"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckIn"].HeaderText = "Tanggal Check In";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckOut"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckOut"].HeaderText = "Tanggal Check Out";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TotalBiaya"))
                dataGridViewRiwayatTransaksi.Columns["TotalBiaya"].HeaderText = "Total Biaya";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("MetodePembayaran"))
                dataGridViewRiwayatTransaksi.Columns["MetodePembayaran"].HeaderText = "Metode Pembayaran";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalTransaksi"))
                dataGridViewRiwayatTransaksi.Columns["TanggalTransaksi"].HeaderText = "Tanggal Transaksi";

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

            if (dataGridViewRiwayatTransaksi.Columns.Contains("IDReservasi"))
                dataGridViewRiwayatTransaksi.Columns["IDReservasi"].HeaderText = "ID Reservasi";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaTamu"))
                dataGridViewRiwayatTransaksi.Columns["NamaTamu"].HeaderText = "Nama Tamu";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorIdentitasTamu"))
                dataGridViewRiwayatTransaksi.Columns["NomorIdentitasTamu"].HeaderText = "Nomor Identitas Tamu";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NomorKamar"))
                dataGridViewRiwayatTransaksi.Columns["NomorKamar"].HeaderText = "Nomor Kamar";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("NamaFasilitas"))
                dataGridViewRiwayatTransaksi.Columns["NamaFasilitas"].HeaderText = "Nama Fasilitas";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckIn"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckIn"].HeaderText = "Tanggal Check In";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalCheckOut"))
                dataGridViewRiwayatTransaksi.Columns["TanggalCheckOut"].HeaderText = "Tanggal Check Out";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TotalBiaya"))
                dataGridViewRiwayatTransaksi.Columns["TotalBiaya"].HeaderText = "Total Biaya";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("MetodePembayaran"))
                dataGridViewRiwayatTransaksi.Columns["MetodePembayaran"].HeaderText = "Metode Pembayaran";

            if (dataGridViewRiwayatTransaksi.Columns.Contains("TanggalTransaksi"))
                dataGridViewRiwayatTransaksi.Columns["TanggalTransaksi"].HeaderText = "Tanggal Transaksi";

            if (dataGridViewRiwayatTransaksi.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada transaksi pada bulan yang dipilih.");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var tampilkanriwayat = RiwayatTransaksiController.GetAllRiwayat();
            dataGridViewRiwayatTransaksi.DataSource = tampilkanriwayat;
            TampilkanTotalPendapatan(tampilkanriwayat);
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
