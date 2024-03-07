using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devy_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama_depan, nama_belakang, alamat, telepon, email;
            DateTime tanggal_lahir;
            Console.WriteLine("Masukan nama depan:");
            nama_depan = Console.ReadLine();
            Console.WriteLine("Masukan nama belakang:");
            nama_belakang = Console.ReadLine();
            Console.WriteLine("Masukan tanggal lahir:");
            tanggal_lahir = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Masukan alamat:");
            alamat = Console.ReadLine();
            Console.WriteLine("Masukan no. telepon:");
            telepon = Console.ReadLine();
            Console.WriteLine("Masukan email:");
            email = Console.ReadLine();
            Console.WriteLine("\n\n");
            Greeting(nama_depan, nama_belakang, tanggal_lahir, alamat, telepon, email);
        }
        static void Greeting(string nama_depan, string nama_belakang,
                DateTime tanggal_lahir, string alamat, string telepon, string email)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("==                 BIODATA             ==");
            Console.WriteLine("=========================================");
            Console.WriteLine("NAMA         : " + nama_depan + " " + nama_belakang);
            Console.WriteLine("TGL LAHIR    : " + tanggal_lahir.ToString("dddd, d MMMM yyyy"));
            Console.WriteLine("ALAMAT       : " + alamat);
            Console.WriteLine("NO. TELEPON  : " + telepon);
            Console.WriteLine("EMAIL        : " + email);


        }
    }
}
