using System;
using System.IO;

namespace CarsLibrary
{
    public abstract class Car : Vehicle
    {
        public string _vehicle_manufacturer_name;
        public string _vehicle_model_name;
        protected Engine engine;
        protected FrontBumper frontbumper;
        protected Bonnet bonnet;
        protected RearBumper rearbumper;
        protected SideSkirts sideskirts;
        protected Spoiler spoiler;
        protected Tire tire;
        protected Alloys alloys;
        protected ConsoleColor color;

        public Car() : base("car") 
        {            
            frontbumper = new FrontBumper();
            rearbumper = new RearBumper();
            sideskirts = new SideSkirts();
            spoiler = new Spoiler();
            bonnet = new Bonnet();
            tire = new Tire();
            alloys = new Alloys();
            color = ConsoleColor.White;
        }

        public string Vehicle_Manufacturer_Name
        {
            get => _vehicle_manufacturer_name;
        }

        public string Vehicle_Model_Name
        {
            get => _vehicle_model_name;
        }

        public ConsoleColor Color
        {
            get => color;
        }


        public abstract void Change_Front_Bumper(FrontBumper customfrontbumper);
        public abstract void Change_Rear_Bumper(RearBumper customrearbumper);
        public abstract void Change_SideSkirt(SideSkirts customsideskirts);
        public abstract void Change_Spoiler(Spoiler customspoiler);
        public abstract void Change_Bonnet(Bonnet custombonnet);
        public abstract void Change_Alloys(Alloys customalloys);
        public abstract void Change_Tire(Tire customtire);
        public abstract void Change_Color(ConsoleColor customcolor);        
        public virtual void Display_Info()
        {
            System.Console.WriteLine($"Car name: {_vehicle_manufacturer_name} {_vehicle_model_name}");
        }
    }

}
