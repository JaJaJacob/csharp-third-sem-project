using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsLibrary;

namespace program_zaliczeniowy_forms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

// ------------ /// WKLEPANY KOD /// ------------------------------------------------------------------ //
            /*FrontBumper frontbumper1 = new FrontBumper("Varis", 0.47m);
            RearBumper rearbumper1 = new RearBumper("Varis", 0.49m);
            SideSkirts sideskirt1 = new SideSkirts("Varis", 0.49m);
            Spoiler spoiler1 = new Spoiler("Varis", 144);
            Bonnet bonnet1 = new Bonnet("Varis", 0.47m);
            Alloys alloy1 = new Alloys("Volk TE37", 8);
            Tire tire1 = new Tire("Michelin Pilot Sport 4S CUP", 1m);
            ConsoleColor color1 = ConsoleColor.Red;
            Engine engine1 = new Engine1();
            Engine engine2 = new Engine2();

            Car car1 = new ToyotaSupra(engine2);
            car1.Display_Info();

            Console.WriteLine();
            Console.WriteLine("Po modach:");
            Console.WriteLine();

            ChipTuning chiptuning1 = new ChipTuning();
            //chiptuning1.ChipTunning_Stage(engine1);

            car1.Change_Front_Bumper(frontbumper1);
            car1.Change_Rear_Bumper(rearbumper1);
            car1.Change_SideSkirt(sideskirt1);
            car1.Change_Bonnet(bonnet1);
            car1.Change_Spoiler(spoiler1);
            car1.Change_Alloys(alloy1);
            car1.Change_Tire(tire1);
            car1.Change_Color(color1);
            car1.Display_Info();
            //car1.Save_To_File($"{car1.Vehicle_Manufacturer_Name}{car1.Vehicle_Model_Name}.txt", car1);
            */

            // ------------ /// WKLEPANY KOD /// ------------------------------------------------------------------ //
        }
       
    }

}
