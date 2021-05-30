using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLibrary
{
    public class ToyotaSupra : Car
    {  
        public ToyotaSupra(Engine engine) :base()
        {            
            this._vehicle_manufacturer_name = "Toyota";
            this._vehicle_model_name = "Supra";
            this.engine = engine;
        }

        public override void Change_Front_Bumper(FrontBumper customfrontbumper)
        {
            frontbumper = customfrontbumper;
        }

        public override void Change_Rear_Bumper(RearBumper customrearbumper)
        {
            rearbumper = customrearbumper;
        }

        public override void Change_SideSkirt(SideSkirts customsideskirts)
        {
            sideskirts = customsideskirts;
        }

        public override void Change_Spoiler(Spoiler customspoiler)
        {
            spoiler = customspoiler;
        }

        public override void Change_Bonnet(Bonnet custombonnet)
        {
            bonnet = custombonnet;
        }

        public override void Change_Tire(Tire customtire)
        {
            tire = customtire;
        }

        public override void Change_Alloys(Alloys customalloys)
        {
            alloys = customalloys;
        }

        public override void Change_Color(ConsoleColor customcolor)
        {
            color = customcolor;
        }

        public override void Display_Info()
        {
            base.Display_Info();
            engine.Display_Info();
            frontbumper.Display_Info();
            rearbumper.Display_Info();
            sideskirts.Display_Info();
            spoiler.Display_Info();
            bonnet.Display_Info();
            tire.Display_Info();
            alloys.Display_Info();
            Console.WriteLine($"Color: {color}");
        }
    }
}
