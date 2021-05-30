using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLibrary
{
    public class Engine3 : Engine
    {
        public Engine3()
        {
            this._engine_name = "2JZ-GTE"; //3.0 330KM
            this._liter_capacity = 3.0m;
            this._horsepower = 330;
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
