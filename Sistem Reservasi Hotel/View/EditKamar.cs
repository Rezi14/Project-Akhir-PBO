using Npgsql;
using Sistem_Reservasi_Hotel.Controller;
using Sistem_Reservasi_Hotel.Models;
using Sistem_Reservasi_Hotel.View;
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
    public partial class EditKamar : Form
    {
        private Kamar kamarToEdit;
        public EditKamar(Kamar kamar)
        {
            InitializeComponent();
            kamarToEdit = kamar;

        }

        private void EditKamar_Load(object sender, EventArgs e)
        {
            loadtipekamar();
            if (kamarToEdit != null)
            {
                textNomorKamar2.Text = kamarToEdit.NomorKamar;
                cbStatusKamar2.Checked = kamarToEdit.StatusKamar;
                textDeskripsi2.Text = kamarToEdit.Deskripsi;

                foreach (var item in comboBoxTipeKamar2.Items)
                {
                    if (item.ToString().StartsWith(kamarToEdit.IDTipeKamar.ToString()))
                    {
                        comboBoxTipeKamar2.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnBatal2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nomor_kamar = textNomorKamar2.Text;
            var selected_tipe_kamar = comboBoxTipeKamar2.SelectedItem;

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
                bool status_kamar = cbStatusKamar2.Checked;
                string deskripsi = textDeskripsi2.Text;

                Kamar kamar = new Kamar
                {
                    IDKamar = kamarToEdit.IDKamar,
                    NomorKamar = nomor_kamar.Trim(),
                    IDTipeKamar = id_tipe_kamar,
                    StatusKamar = status_kamar,
                    Deskripsi = deskripsi
                };

                KamarController.Update(kamar);
                MessageBox.Show("Kamar berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadtipekamar()
        {
            comboBoxTipeKamar2.Items.Clear();
            try
            {
                var daftarTipeKamar = TipeKamarController.GetAllTipeKamar();
                if (daftarTipeKamar.Any())
                {
                    foreach (var tipe in daftarTipeKamar)
                    {
                        comboBoxTipeKamar2.Items.Add($"{tipe.IDTipeKamar} - {tipe.NamaTipeKamar}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data tipe kamar:\n" + ex.Message);
            }

        }
    }
} 

