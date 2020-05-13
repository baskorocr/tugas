using System; 
namespace baru
{
    public interface IPrinterwin
    {

        void PilihPrint()
        {
            Console.WriteLine(" ");
        }
        void DataPrint()
        {
            Console.WriteLine(" ");
        }

    }

    public class Epson : IPrinterwin
    {
        public void PilihPrint()
        {
            Console.WriteLine("Epson display dimension 10*11");

        }

        public void DataPrint()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
    public class Canon : IPrinterwin
    {
        public void PilihPrint()
        {
            Console.WriteLine("Canon display dimension 9.5*12");
            

        }
        public void DataPrint()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
    public class LaserJet : IPrinterwin
    {
         public void PilihPrint()
        {
           Console.WriteLine("LaserJet display dimension 12*12");

        }    

        public void DataPrint()
        {
           Console.WriteLine("Epson printer printing....");
        }   
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.Laser Jet\n");

            Console.WriteLine("Pilih Nomer Printer [1-3]");
            int nomerPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            IPrinterwin tampil = null;

            if(nomerPrinter==1)
            {
                tampil = new Epson();
            }
            else if(nomerPrinter==2)
            {
                

                tampil = new Canon();

            }
            else if(nomerPrinter==3)
            {
                tampil = new LaserJet();
            }
            else
            {
                Console.WriteLine("Printer tidak ada");
            }

            tampil.PilihPrint();
            tampil.DataPrint();

            Console.ReadKey();
        }

    }
}