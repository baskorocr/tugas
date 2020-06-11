using System;
namespace baru.abstraction
{

    class Program
    {

    }

    abstract class Data
    {
        public abstract void ViewBio(string nama, string jenis,string telp, string alamat);
        public void ViewData(string nama, string ktp,string jenis, string status, string alamat,string agama)
        {
            Console.WriteLine("Data Lengkap");
            Console.WriteLine("Nama          : {0}",nama);
            Console.WriteLine("No KTP        : {0}",ktp);
            Console.WriteLine("Jenis Kelamin : {0}",jenis);
            Console.WriteLine("Status        : {0}",status);
            Console.WriteLine("Agama         : {0}",agama);
            Console.WriteLine("Alamat        : {0}",alamat);
            Console.WriteLine("================================");
        }

    }
    class Bio : Data
    {
        public override void ViewBio(string nama, string jenis, string telp, string alamat)
        {
            Console.WriteLine("Data Singkat");
            Console.WriteLine("Nama          : {0}",nama);
            Console.WriteLine("Jenis Kelamin : {0}",jenis);
            Console.WriteLine("No Telp       : {0}",telp);
            Console.WriteLine("Alamat        : {0}",alamat);
            Console.WriteLine();
        }
    }
}