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
    public partial class EditFasilitas : Form
    {
        private Fasilitas FasilitasToEdit;
        public EditFasilitas(Fasilitas fasilitas)
        {
            InitializeComponent();
            FasilitasToEdit = fasilitas;
        }

        private void EditFasilitas_Load(object sender, EventArgs e)
        {
            if (FasilitasToEdit != null)
            {
                textNamaFasilitas2.Text = FasilitasToEdit.NamaFasilitas;
                textBiayaTambahan2.Text = FasilitasToEdit.BiayaTambahan.ToString();
                textDeskripsi2.Text = FasilitasToEdit.Deskripsi;
                checkBoxStatusFasilitas.Checked = FasilitasToEdit.StatusFasilitas;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var errors = FasilitasController.ValidateFasilitas(textNamaFasilitas2.Text, textBiayaTambahan2.Text);
            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Fasilitas fasilitas = new Fasilitas
            {
                IDFasilitas = FasilitasToEdit.IDFasilitas,
                NamaFasilitas = textNamaFasilitas2.Text.Trim(),
                BiayaTambahan = decimal.Parse(textBiayaTambahan2.Text),
                Deskripsi = textDeskripsi2.Text,
                StatusFasilitas = checkBoxStatusFasilitas.Checked
            };

            FasilitasController.Update(fasilitas);
            MessageBox.Show("Fasilitas berhasil diperbarui!", "Sukses");
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
