using Collection.induk;
namespace Collection.anak
{
    public class KaryawanHarian : Karyawan
    {
        public override string Nama{get; set;}
        public override string Nik {get; set;}
        public double UpahPerjam {get; set;}
        public double TotalJamKerja {get; set;}

        public override double TotalGaji()
        {
            return TotalJamKerja*UpahPerjam;
        }
    }
}