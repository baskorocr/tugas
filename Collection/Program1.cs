using Collection.induk;
using Collection.anak;
using System;
using System.Collections.Generic;
namespace Collection
{
    public class Program1
    {
        static void Main(string[] args)
        {
            KaryawanTetap kartap = new KaryawanTetap();
            kartap.Nik="123-1211-31231";
            kartap.Nama="Joko Sansoto";
            kartap.GajiBulanan=6000000;

            KaryawanHarian karhar = new KaryawanHarian();
            karhar.Nik="643-41224-14534";
            karhar.Nama="Dian Anggara";
            karhar.TotalJamKerja=16;
            karhar.UpahPerjam=200000;

            Sales sale = new Sales();
            sale.Nik="412-54545-42342";
            sale.Nama="Anggi Sandoro";
            sale.JumlahPenjualan= 20;
            sale.UpahKomisi=100000;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karhar);
            listkaryawan.Add(kartap);
            listkaryawan.Add(sale);

            int no = 1;
            foreach(Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}",
                no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                no++;
            }
        }
    }
}