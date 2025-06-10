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
    public partial class TambahFasilitas : Form
    {
        public TambahFasilitas()
        {
            InitializeComponent();
        }


        private void btnTambahFasilitas2_Click(object sender, EventArgs e)
        {
            var errors = FasilitasController.ValidateFasilitas(textNamaFasilitas.Text, textBiayaTambahan.Text);
            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Fasilitas fasilitas = new Fasilitas
            {
                NamaFasilitas = textNamaFasilitas.Text.Trim(),
                BiayaTambahan = decimal.Parse(textBiayaTambahan.Text),
                Deskripsi = textDeskripsi.Text,
                StatusFasilitas = true
            };

            FasilitasController.InsertFasilitas(fasilitas);
            MessageBox.Show("Fasilitas berhasil ditambahkan!", "Sukses");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


