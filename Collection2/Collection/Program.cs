using Collection.induk;
using Collection.anak;
using System;



using System.Collections.Generic;


namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<KaryawanTetap> kartap = new List<KaryawanTetap>();
            List<KaryawanHarian> karhar = new List<KaryawanHarian>();
            List<Sales> sale = new List<Sales>();


        menu:
            Console.WriteLine("MENU UTAMA");
			Console.WriteLine("=====================");
			Console.WriteLine("1. Input Data Pegawai");
			Console.WriteLine("2. Lihat Data Pegawai");
            Console.WriteLine("3. Hapus Data Pegawai");
			Console.WriteLine("4. Keluar");
            Console.Write("Masukkan pilihan [1]/[2]/[3]/[4] : ");
			int pil;
            int pil2;
            
            pil= int.Parse(Console.ReadLine());
            if(pil==1)
            {
                Console.WriteLine("1. Input Data Pegawai Tetap");
                Console.WriteLine("2. Input Data Pegawai Kontrak");
                Console.WriteLine("3. Input Data Sales");
                Console.Write("Masukkan pilihan [1]/[2]/[3] : ");
                pil2 = int.Parse(Console.ReadLine());

                if(pil2==1)
                {
                    string nik,nama;
                    double gabul;
                    Console.WriteLine("Masukan Nama : ");
                    nama=Console.ReadLine();
                    Console.WriteLine("Masukan Nik : ");
                    nik=Console.ReadLine();
                    Console.WriteLine("Gaji Bulanan : ");
                    gabul = int.Parse(Console.ReadLine());

                    
                    kartap.Add(new KaryawanTetap() { Nik = nik, Nama = nama, GajiBulanan=gabul });
                    
                }
                else if(pil2==2)
                {
                    string nik,nama;
                    double jam;
                    double upah;
                    Console.WriteLine("Masukan Nama : ");
                    nama=Console.ReadLine(); 
                    Console.WriteLine("Masukan Nik : ");
                    nik=Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Jam : ");
                    jam=int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Upah : ");
                    upah=int.Parse(Console.ReadLine());
                    karhar.Add(new KaryawanHarian() { Nik = nik, Nama = nama, UpahPerjam=upah, TotalJamKerja=jam });


                }
                else if(pil2==3)
                {
                    string nama,nik;
                    double jumlah,komisi;
                    Console.WriteLine("Masukan Nama : ");
                    nama=Console.ReadLine();
                    Console.WriteLine("Masukan Nik : ");
                    nik=Console.ReadLine();
                    Console.WriteLine("Masukan Jumlah Penjualan : ");
                    jumlah=int.Parse(Console.ReadLine()); 
                    Console.WriteLine("Masukan Komisi : ");
                    komisi=int.Parse(Console.ReadLine());

                    sale.Add(new Sales() { Nik = nik, Nama = nama, JumlahPenjualan=jumlah, UpahKomisi=komisi });

                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else if (pil==2)
            {
                Console.WriteLine("List Data Pegawai");
                int no = 1;
                foreach (Karyawan karyawan in kartap)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Tetap",
                    no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                    no++;
                }
                foreach (Karyawan karyawan in karhar)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Karyawan Harian",
                    no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                    no++;
                }
                foreach (Karyawan karyawan in sale)
                {
                    Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}, Sales",
                    no, karyawan.Nik, karyawan.Nama, karyawan.TotalGaji());
                    no++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;

            }
            else if (pil==3)
            {
                Console.WriteLine("Pilihan Hapus Karyawan");
                string hapus;
                Console.WriteLine("Masukan NIK : ");
                hapus = Console.ReadLine();
                int x = 0;
                foreach(Karyawan karyawan in kartap)
                {
                    if (hapus == karyawan.Nik)
                    {
                        kartap.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Karyawan karyawan in karhar)
                {
                    if (hapus == karyawan.Nik)
                    {
                        karhar.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Karyawan karyawan in sale)
                {
                    if (hapus == karyawan.Nik)
                    {
                        sale.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            else
            {
                Console.WriteLine("Terimakasih telah menggunakan Aplikasi ini");
            }

                
            Console.ReadKey(true);
            Console.Clear();
            
        }

 
        
    }
}