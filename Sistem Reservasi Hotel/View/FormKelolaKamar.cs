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
    public partial class FormKelolaKamar : Form
    {
        public FormKelolaKamar()
        {
            InitializeComponent();
        }

        private void FormKelolaKamar_Load(object sender, EventArgs e)
        {
            tampilkankamar();

        }

        private void btnTambahKamar1_Click(object sender, EventArgs e)
        {
            using (TambahKamar formTambah = new TambahKamar())
            {
                DialogResult result = formTambah.ShowDialog();

                if (result == DialogResult.OK)
                {
                    tampilkankamar();
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dasboard dasboard = new Dasboard();
            this.Hide();
            dasboard.ShowDialog();
            this.Close();
        }
        private void ResetKolomUrutan()
        {
            if (dataGridViewKelolaKamar.Columns.Contains("Edit"))
                dataGridViewKelolaKamar.Columns["Edit"].DisplayIndex = dataGridViewKelolaKamar.Columns.Count - 1;

            if (dataGridViewKelolaKamar.Columns.Contains("Hapus"))
                dataGridViewKelolaKamar.Columns["Hapus"].DisplayIndex = dataGridViewKelolaKamar.Columns.Count - 1;
        }

        private void tampilkankamar()
        {
            List<Kamar> listKamar = KamarController.GetAllKamar();
            dataGridViewKelolaKamar.DataSource = null;
            dataGridViewKelolaKamar.DataSource = listKamar;

            if (!dataGridViewKelolaKamar.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "Edit";
                btnedit.Name = "Edit";
                btnedit.HeaderText = "Edit";
                btnedit.UseColumnTextForButtonValue = true;
                dataGridViewKelolaKamar.Columns.Add(btnedit);
            }

            if (!dataGridViewKelolaKamar.Columns.Contains("Hapus"))
            {
                DataGridViewButtonColumn btnhapus = new DataGridViewButtonColumn();
                btnhapus.Text = "Hapus";
                btnhapus.Name = "Hapus";
                btnhapus.HeaderText = "Hapus";
                btnhapus.UseColumnTextForButtonValue = true;
                dataGridViewKelolaKamar.Columns.Add(btnhapus);
            }

            if (dataGridViewKelolaKamar.Columns.Contains("IDKamar"))
                dataGridViewKelolaKamar.Columns["IDKamar"].HeaderText = "ID Kamar";

            if (dataGridViewKelolaKamar.Columns.Contains("NomorKamar"))
                dataGridViewKelolaKamar.Columns["NomorKamar"].HeaderText = "Nomor Kamar";

            if (dataGridViewKelolaKamar.Columns.Contains("IDTipeKamar"))
                dataGridViewKelolaKamar.Columns["IDTipeKamar"].HeaderText = "ID Tipe Kamar";

            if (dataGridViewKelolaKamar.Columns.Contains("StatusKamar"))
                dataGridViewKelolaKamar.Columns["StatusKamar"].HeaderText = "Status Kamar";

            if (dataGridViewKelolaKamar.Columns.Contains("Deskripsi"))
                dataGridViewKelolaKamar.Columns["Deskripsi"].HeaderText = "Deskripsi Kamar";

            ResetKolomUrutan();
        }

        private void dataGridViewKelolaKamar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridViewKelolaKamar.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    Kamar selectedKamar = new Kamar
                    {
                        IDKamar = Convert.ToInt32(dataGridViewKelolaKamar.Rows[e.RowIndex].Cells["IDKamar"].Value),
                        NomorKamar = dataGridViewKelolaKamar.Rows[e.RowIndex].Cells["NomorKamar"].Value.ToString(),
                        IDTipeKamar = Convert.ToInt32(dataGridViewKelolaKamar.Rows[e.RowIndex].Cells["IDTipeKamar"].Value),
                        StatusKamar = Convert.ToBoolean(dataGridViewKelolaKamar.Rows[e.RowIndex].Cells["StatusKamar"].Value),
                        Deskripsi = dataGridViewKelolaKamar.Rows[e.RowIndex].Cells["Deskripsi"].Value.ToString()
                    };

                    using (EditKamar editForm = new EditKamar(selectedKamar))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            tampilkankamar();
                        }
                    }
                }
                else if (columnName == "Hapus")
                {
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus kamar ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        int idKamar = Convert.ToInt32(dataGridViewKelolaKamar.Rows[e.RowIndex].Cells["IDKamar"].Value);

                        try
                        {
                            KamarController.Delete(idKamar);
                            MessageBox.Show("Data kamar berhasil dihapus.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan saat menghapus data kamar: " + ex.Message);
                        }

                        tampilkankamar();
                    }
                }
            }
        } 
    }
}
