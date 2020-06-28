using Collection.induk;
namespace Collection.anak
{
    public class KaryawanTetap : Karyawan
    {
        public override string Nama {get; set;}
        public override string Nik {get; set; }
        public double GajiBulanan {get; set;}

        public override double TotalGaji()
        {
            return GajiBulanan;
        }
        
    }
}