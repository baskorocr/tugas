using System; 
namespace baru
{
    public class Printer
    {
        public string Name {get; set;}

        public virtual void PilihPrint()
        {
            Console.WriteLine("Contoh");
        }
        public virtual void DataPrint()
        {
            Console.WriteLine("Contoh");
        }

    }

    public class Epson : Printer
    {
        public override void PilihPrint()
        {
            Console.WriteLine("Epson display dimension 10*11");

        }

        public override void DataPrint()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
    public class Canon : Printer
    {
        public override void PilihPrint()
        {
            Console.WriteLine("Canon display dimension 9.5*12");
            

        }
        public override void DataPrint()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
    public class LaserJet : Printer
    {
         public override void PilihPrint()
        {
           Console.WriteLine("LaserJet display dimension 12*12");

        }    

        public override void DataPrint()
        {
           Console.WriteLine("Epson printer printing....");
        }   
    }

    public class Program
    {
        static void Main(string[] args)
        {
            
            Printer printer = new Printer();

            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.Laser Jet\n");

            Console.WriteLine("Pilih Nomer Printer [1-3]");
            int nomerPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if(nomerPrinter==1)
            {
                Epson epson = new Epson();
                printer = epson;

            }
            else if(nomerPrinter==2)
            {
                
                Canon canon = new Canon();
                printer = canon;
 

            }
            else if(nomerPrinter==3)
            {
                LaserJet laserjet = new LaserJet();
                printer = laserjet;

                
            }
            else
            {
                Console.WriteLine("Printer tidak ada");
            }

            printer.PilihPrint();
            printer.DataPrint();

            Console.ReadKey();
        }

    }
}