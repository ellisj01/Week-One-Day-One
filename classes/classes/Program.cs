using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program   
    {
        static void Main(string[] args)
        {
            //instrument
            //guitar
            Instrument guitar = new Instrument();

            guitar.HasStrings1 = true;
            Console.WriteLine(guitar.HasStrings1);

            guitar.NumStrings = 7;
            Console.WriteLine(guitar.NumStrings);

            guitar.UsesAmp = true;
            Console.WriteLine(guitar.UsesAmp);

            guitar.UsesCord = true;
            Console.WriteLine(guitar.UsesCord);

            guitar.UsesFingers = true;
            Console.WriteLine(guitar.UsesFingers);

            //instrument
            //drums (elec)
            Instrument drums = new Instrument();

            drums.HasStrings1 = false;
            Console.WriteLine(drums.HasStrings1);

            drums.NumStrings = 0;
            Console.WriteLine(drums.NumStrings);

            drums.UsesAmp = true;
            Console.WriteLine(drums.UsesAmp);

            drums.UsesCord = true;
            Console.WriteLine(drums.UsesCord);

            drums.UsesFingers = false;
            Console.WriteLine(drums.UsesFingers);

            //gameconsole
            //ps4

            GameConsole ps4 = new GameConsole();
            ps4.HasHDMIPort = false;

           // polymorphic example GameConsole xBox = new GameConsole(true);

            ps4.NumControllerport = 2;
            Console.WriteLine(ps4.NumControllerport);
                                                                                                                                                                                                                                                                                                                                                                  

            ps4.OnlineCapability = true;
            Console.WriteLine(ps4.OnlineCapability);

            ps4.OnlineFree = false;
            Console.WriteLine(ps4.OnlineFree);

            ps4.Manufacturer = ("sony");
            Console.WriteLine(ps4.Manufacturer);
            
            //nintendo64

            GameConsole nintendo64 = new GameConsole();

            nintendo64.HasHDMIPort = true;
            Console.WriteLine(nintendo64.HasHDMIPort);

            nintendo64.Manufacturer = ("nintendo");
            Console.WriteLine(nintendo64.Manufacturer);

            nintendo64.OnlineCapability = false;
            Console.WriteLine(nintendo64.OnlineCapability);

            nintendo64.OnlineFree = false;
            Console.WriteLine(nintendo64.OnlineFree);

            nintendo64.NumControllerport = 4;

            //house
            //house1
            Houses house1 = new Houses();

            house1.HasDoors = true;
            Console.WriteLine(house1.HasDoors);

            house1.HasChimney = true;
            Console.WriteLine(house1.HasChimney);

            house1.HasPool = true;
            Console.WriteLine(house1.HasPool);

            house1.NumDoors = 13;
            Console.WriteLine(house1.NumDoors);

            house1.NumRooms = 4;
            Console.WriteLine(house1.NumRooms);

            //house2
            Houses house2 = new Houses();

            house2.HasChimney = false;
            Console.WriteLine(house2.HasChimney);

            house2.HasDoors = true;
            Console.WriteLine(house2.HasDoors);

            house2.HasPool = false;
            Console.WriteLine(house2.HasPool);

            house2.NumDoors = 6;
            Console.WriteLine(house2.NumDoors);

            house2.NumRooms = 2;
            Console.WriteLine(house2.NumRooms);

            



            Console.ReadLine();
        }
    }
}
