using System;

namespace CarsLibrary
{
    public class Engine2 : Engine
    {
        public Engine2()
        {
            this._engine_name = "B48B20"; //3.0 340KM
            this._liter_capacity = 2.0m;
            this._horsepower = 258;
        }


        public override void Display_Info()
        {
            //base.Display_Info();
            {
                Console.WriteLine($"Engine: {_engine_name} {_liter_capacity} {_horsepower}");
            }
        }
    }
}
