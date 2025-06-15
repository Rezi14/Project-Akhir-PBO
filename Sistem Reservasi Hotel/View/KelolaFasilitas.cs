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
    public partial class KelolaFasilitas : Form
    {
        public KelolaFasilitas()
        {
            InitializeComponent();
        }

        private void KelolaFasilitas_Load(object sender, EventArgs e)
        {
            tampilkanfasilitas();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dasboard dasboard = new Dasboard();
            this.Hide();
            dasboard.ShowDialog();
            this.Close();
        }

        private void btnTambahFasilitas1_Click(object sender, EventArgs e)
        {
            using (TambahFasilitas formTambah = new TambahFasilitas())
            {
                if (formTambah.ShowDialog() == DialogResult.OK)
                {
                    tampilkanfasilitas();
                }
            }
        }
        private void ResetKolomUrutan()
        {
            if (dataGridViewKelolaFasilitas.Columns.Contains("Edit"))
                dataGridViewKelolaFasilitas.Columns["Edit"].DisplayIndex = dataGridViewKelolaFasilitas.Columns.Count - 1;

            if (dataGridViewKelolaFasilitas.Columns.Contains("Hapus"))
                dataGridViewKelolaFasilitas.Columns["Hapus"].DisplayIndex = dataGridViewKelolaFasilitas.Columns.Count - 1;
        }

        private void dataGridViewKelolaFasilitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridViewKelolaFasilitas.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    Fasilitas selectedFasilitas = new Fasilitas
                    {
                        IDFasilitas = Convert.ToInt32(dataGridViewKelolaFasilitas.Rows[e.RowIndex].Cells["IDFasilitas"].Value),
                        NamaFasilitas = dataGridViewKelolaFasilitas.Rows[e.RowIndex].Cells["NamaFasilitas"].Value.ToString(),
                        BiayaTambahan = Convert.ToDecimal(dataGridViewKelolaFasilitas.Rows[e.RowIndex].Cells["BiayaTambahan"].Value),
                        Deskripsi = dataGridViewKelolaFasilitas.Rows[e.RowIndex].Cells["Deskripsi"].Value.ToString(),
                        StatusFasilitas = Convert.ToBoolean(dataGridViewKelolaFasilitas.Rows[e.RowIndex].Cells["StatusFasilitas"].Value)
                    };

                    using (EditFasilitas editForm = new EditFasilitas(selectedFasilitas))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            tampilkanfasilitas(); 
                        }
                    }
                }
                else if (columnName == "Hapus")
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus Fasilitas ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        int idFasilitas = Convert.ToInt32(dataGridViewKelolaFasilitas.Rows[e.RowIndex].Cells["IDFasilitas"].Value);

                        try
                        {
                            FasilitasController.Delete(idFasilitas);
                            MessageBox.Show("Data Fasilitas berhasil dihapus.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan saat menghapus data kamar: " + ex.Message);
                        }

                        tampilkanfasilitas();
                    }
                }
            }
        }
        private void tampilkanfasilitas()
        {
            List<Fasilitas> listfasilitas = FasilitasController.GetAllFasilitas();

            dataGridViewKelolaFasilitas.DataSource = null;
            dataGridViewKelolaFasilitas.DataSource = listfasilitas;

            if (!dataGridViewKelolaFasilitas.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "Edit";
                btnedit.Name = "Edit";
                btnedit.HeaderText = "Edit";
                btnedit.UseColumnTextForButtonValue = true;
                dataGridViewKelolaFasilitas.Columns.Add(btnedit);
            }

            if (!dataGridViewKelolaFasilitas.Columns.Contains("Hapus"))
            {
                DataGridViewButtonColumn btnhapus = new DataGridViewButtonColumn();
                btnhapus.Text = "Hapus";
                btnhapus.Name = "Hapus";
                btnhapus.HeaderText = "Hapus";
                btnhapus.UseColumnTextForButtonValue = true;
                dataGridViewKelolaFasilitas.Columns.Add(btnhapus);
            }

            if (dataGridViewKelolaFasilitas.Columns.Contains("IDFasilitas"))
                dataGridViewKelolaFasilitas.Columns["IDFasilitas"].HeaderText = "ID Fasilitas";

            if (dataGridViewKelolaFasilitas.Columns.Contains("NamaFasilitas"))
                dataGridViewKelolaFasilitas.Columns["NamaFasilitas"].HeaderText = "Nama Fasilitas";

            if (dataGridViewKelolaFasilitas.Columns.Contains("BiayaTambahan"))
                dataGridViewKelolaFasilitas.Columns["BiayaTambahan"].HeaderText = "Biaya Tambahan";

            if (dataGridViewKelolaFasilitas.Columns.Contains("Deskripsi"))
                dataGridViewKelolaFasilitas.Columns["Deskripsi"].HeaderText = "Deskripsi";

            if (dataGridViewKelolaFasilitas.Columns.Contains("StatusFasilitas"))
                dataGridViewKelolaFasilitas.Columns["StatusFasilitas"].HeaderText = "Status Fasilitas";
            
            ResetKolomUrutan();
        }
    }
}
