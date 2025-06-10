using Sistem_Reservasi_Hotel.Models;

namespace Sistem_Reservasi_Hotel.Controller
{
    public class LoginController
    {
        public Akun ValidasiLogin(string username, string password)
        {
            return Akun.ValidasiLogin(username, password);
        }
    }
}