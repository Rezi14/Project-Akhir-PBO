using Sistem_Reservasi_Hotel.Models;

namespace Sistem_Reservasi_Hotel.Controller
{
    public class DaftarController
    {
        public bool Daftar(string username, string password)
        {
            return Akun.Daftar(username, password);
        }
    
    public static List<string> ValidatePendaftaran(string username, string password, string konfirmasi)
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errors.Add("Username dan password harus diisi.");
            }

            if (password != konfirmasi)
            {
                errors.Add("Password dan konfirmasi tidak cocok.");
            }
            if (!string.IsNullOrWhiteSpace(password) && password.Length < 6)
            {
                errors.Add("Password minimal harus 6 karakter.");
            }

            return errors;
        }
    }
}