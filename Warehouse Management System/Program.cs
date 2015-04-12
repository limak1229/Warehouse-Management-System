using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        static public String hashPass(String password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] md5data = md5.ComputeHash(bytes);
            return Convert.ToBase64String(md5data);
        }

        static public DaneFirmy pobierzDaneFirmy()
        {
            Int32 lastId = BazaDanych.Polaczenie.DaneFirmies.Max(d => d.Id_firmy);
            return BazaDanych.Polaczenie.DaneFirmies.SingleOrDefault(d => d.Id_firmy == lastId);
        }
    }
}
