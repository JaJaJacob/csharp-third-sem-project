using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLibrary
{
    public class Engine1 : Engine
    {
        public Engine1():base()
        {
            this._engine_name = "B58B30"; //3.0 340KM
            this._liter_capacity = 3.0m;
            this._horsepower = 340;  
        }

     
        public override void Display_Info()
        {
            //base.Display_Info();
            {
                Console.WriteLine($"Engine: {_engine_name} {_liter_capacity} {_horsepower} {_is_chip_tuned}");
            }
        }
    }
}
