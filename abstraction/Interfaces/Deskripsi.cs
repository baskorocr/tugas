using System;
namespace baru.Interfaces
{
    public interface IDeskrip
    {
        void View();
    }

    class Baca : IDeskrip
    {
        public void View()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Data Masyarakat Cibarusah");
            Console.WriteLine("Perumahan Cibarusah Indah Jaya");
            Console.WriteLine("================================");
        }
    }

}