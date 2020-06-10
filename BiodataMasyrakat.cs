using System;
namespace baru
{

    class Program
    {
        static Bio bi = new Bio(); 
        public static void Main(string[] args)
        {
            string nama="Joko santoso";
            string alamat="Cibarusah Indah Jaya";
            string jenis ="laki-laki";
            string ktp ="31234123121";
            string status="Belum menikah";
            string agama="Islam";
            string telp="089654825055";

            bi.ViewBio(nama,jenis,telp,alamat);
            bi.ViewData(nama,ktp,jenis,status,alamat,agama);

        }
    }

    abstract class Data
    {
        public abstract void ViewBio(string nama, string jenis,string telp, string alamat);
        public void ViewData(string nama, string ktp,string jenis, string status, string alamat,string agama)
        {
            Console.WriteLine("Biodata Diri");
            Console.WriteLine();
            Console.WriteLine("Nama          : {0}",nama);
            Console.WriteLine("No KTP        : {0}",ktp);
            Console.WriteLine("Jenis Kelamin : {0}",jenis);
            Console.WriteLine("Status        : {0}",status);
            Console.WriteLine("Agama         : {0}",agama);
            Console.WriteLine("Alamat        : {0}",alamat);
            Console.WriteLine();
            Console.WriteLine();
        }

    }
    class Bio : Data
    {
        public override void ViewBio(string nama, string jenis, string telp, string alamat)
        {
            Console.WriteLine("Data Masyarakat");
            Console.WriteLine();
            Console.WriteLine("Nama          : {0}",nama);
            Console.WriteLine("Jenis Kelamin : {0}",jenis);
            Console.WriteLine("No Telp       : {0}",telp);
            Console.WriteLine("Alamat        : {0}",alamat);
            Console.WriteLine();
        }
    }
}