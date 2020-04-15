using System;
namespace baru.ResponsiPemrograman2900
{
    
    public class Karyawan
    {   

        public int No{get; set;}       
        public string Nama{get; set;}
        public int NIK{get; set;}
        public int Gaji{get; set;}

        public Karyawan(int no,int nik,string nama, int gaji)
        {
            Nama=nama;
            NIK=nik;
            Gaji=gaji;
            No=no;
        }

        public void DataKaryawan()
        {
            
            Console.WriteLine("{0}. {1} {2}         {3}",No,NIK,Nama,Gaji);
            if(Gaji<0)
            {
                Console.WriteLine("Gaji kurang dari 0");
            }
        }

        public void GajiNaik()
        {
            Console.WriteLine("{0}. {1} {2}         {3}",No,NIK,Nama,Gaji+(Gaji*10/100));
            if(Gaji<0)
            {
                Console.WriteLine("Gaji kurang dari 0");
            }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {   

            string[] nama = new string[2];
            int[] no = new int[2];
            int[] nik= new int[2];
            int[] gaji= new int[2];

            for(int i=0; i<2; i++)
            {   
                no[i]=i+1;

                Console.WriteLine("Masukan nama : ");
                nama[i]=Console.ReadLine();
                Console.WriteLine("Masukan Nik : ");
                nik[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan Gaji : ");
                gaji[i]=int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

            }

            for(int i=0; i<2; i++)
            {
            if(i==0)
            {
            Console.WriteLine("No Nik/Nama               Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            Karyawan karyawan = new Karyawan(no[i],nik[i],nama[i],gaji[i]);
            karyawan.DataKaryawan();
            }
            if(i==1)
            {
            Karyawan karyawan2 = new Karyawan(no[i],nik[i],nama[i],gaji[i]);
            karyawan2.DataKaryawan();
            }
            }
            for(int i=0; i<2; i++)
            {
            if(i==0)
            {
            Console.WriteLine(" ");
            Console.WriteLine("Asyiiikkk Kenaikan Gaji 10%!!");
            Console.WriteLine(" ");
            Console.WriteLine("No Nik/Nama               Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            Karyawan karyawan3 = new Karyawan(no[i],nik[i],nama[i],gaji[i]);
            karyawan3.GajiNaik();
            }
            if(i==1)
            {
            Karyawan karyawan4 = new Karyawan(no[i],nik[i],nama[i],gaji[i]);
            karyawan4.GajiNaik();
            }
            }

        }
        
        
    }

    
}