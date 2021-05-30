using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLibrary
{
    public abstract class Engine
    {
        protected string _engine_name;
        protected decimal _horsepower;
        protected decimal _liter_capacity;
        protected bool _is_chip_tuned;
        static protected string _code = "0XY54z6ter";

        public Engine()
        {
            this._engine_name = "STOCK ENGINE";
            this._horsepower = 0;
            this._liter_capacity = 0;
            this._is_chip_tuned = false;
        }     
       
        public decimal Horsepower
        {
            get => _horsepower;
            set
            {
                _horsepower += value;
                _is_chip_tuned = true;
                /*
                Console.WriteLine("Insert engine code to increase power:");
                string tmp = Console.ReadLine();
                if (tmp == _code)
                {
                    _horsepower += value;
                }
                else
                {
                    Console.WriteLine("Incorrect code!");
                }   
                */
            }
        }

        public decimal Horsepower2
        {
            set
            {
                _horsepower = value;
            }
        }
        
        public string EngineName
        {
            get => _engine_name;
        }
        
        public decimal LiterCapacity
        {
            get => _liter_capacity;
        }
        public bool Is_Chip_Tuned
        {
            get => _is_chip_tuned;
            set
            {
                _is_chip_tuned = value;
            }
        }

        public virtual void Display_Info()
        {
            Console.WriteLine($"Engine: {_engine_name} {_liter_capacity} {_horsepower} {_is_chip_tuned}");
        }
    }
}
