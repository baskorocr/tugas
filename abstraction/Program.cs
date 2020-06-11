using System;
using baru.abstraction;
using baru.Interfaces;
namespace baru
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDeskrip desk = new Baca();
            Bio bi = new Bio();

            string nama="Joko santoso";
            string alamat="Cibarusah Indah Jaya Blok DA 04";
            string jenis ="laki-laki";
            string ktp ="31234123121";
            string status="Belum menikah";
            string agama="Islam";
            string telp="089654825055";

            desk.View();
            bi.ViewBio(nama,jenis,telp,alamat);
            bi.ViewData(nama,ktp,jenis,status,alamat,agama);


        }
    }
}