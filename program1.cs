using System;

namespace baru
{
    public class program1
    {
        static void Main(string[] args)
        {
            taxi2 taxi = new taxi2();

            taxi.Drivername = "Joko";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();


        }
    }
}