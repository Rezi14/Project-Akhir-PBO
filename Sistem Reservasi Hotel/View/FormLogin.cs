using Sistem_Reservasi_Hotel.Controller;
using Sistem_Reservasi_Hotel.Models;
using System;
using System.Windows.Forms;

namespace Sistem_Reservasi_Hotel.View
{
    public partial class FormLogin : Form
    {
        private LoginController loginController;

        public FormLogin()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void btnlogin1_Click(object sender, EventArgs e)
        {
            string username = textusername1.Text.Trim();
            string password = textpassword1.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password harus diisi.", "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Akun akunValid = loginController.ValidasiLogin(username, password);

            if (akunValid != null)
            {
                MessageBox.Show($"Login berhasil! Selamat datang, {akunValid.Username}.", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dasboard dasboard = new Dasboard();
                this.Hide();
                dasboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textpassword1.Clear();
                textpassword1.Focus();
            }
        }

        private void btndaftar1_Click(object sender, EventArgs e)
        {
            FormDaftar frmdaftar = new FormDaftar();
            frmdaftar.Show();
            this.Hide();
        }
    }
}