using Npgsql;
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

namespace Sistem_Reservasi_Hotel.View
{
    public partial class TambahKamar : Form
    {
        public TambahKamar()
        {
            InitializeComponent();
            loadtipekamar();
        }

        private void btnTambahKamar2_Click(object sender, EventArgs e)
        {
            string nomor_kamar = textNomorKamar1.Text;
            var selected_tipe_kamar = comboBoxTipeKamar.SelectedItem;

            
            List<string> validationErrors = KamarController.ValidateKamar(nomor_kamar, selected_tipe_kamar);

            
            if (validationErrors.Any())
            {
                string allErrors = string.Join("\n", validationErrors);
                MessageBox.Show(allErrors, "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            try
            {
                string selected = selected_tipe_kamar.ToString();
                int id_tipe_kamar = int.Parse(selected.Split('-')[0].Trim());
                bool status_kamar = cbStatusKamar.Checked;
                string deskripsi = textDeskripsi1.Text;

                Kamar kamar = new Kamar
                {
                    NomorKamar = nomor_kamar.Trim(),
                    IDTipeKamar = id_tipe_kamar,
                    StatusKamar = status_kamar,
                    Deskripsi = deskripsi
                };

                KamarController.InsertKamar(kamar);

                MessageBox.Show("Kamar berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadtipekamar()
        {
            comboBoxTipeKamar.Items.Clear();
            try
            {
                var daftarTipeKamar = TipeKamarController.GetAllTipeKamar();

                if (daftarTipeKamar.Any())
                {
                    foreach (var tipe in daftarTipeKamar)
                    {
                        comboBoxTipeKamar.Items.Add($"{tipe.IDTipeKamar} - {tipe.NamaTipeKamar}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data tipe kamar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); 
        }

        private void textDeskripsi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TambahKamar_Load(object sender, EventArgs e)
        {

        }
    }
}
