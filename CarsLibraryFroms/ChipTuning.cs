using System;
using System.Collections.Generic;
using System.Text;

namespace CarsLibrary
{
    public class ChipTuning
    {
        protected string _stage_name;

        public ChipTuning()
        {          
            this._stage_name = "Stage 0";
        }

        public string StageName
        {
            get => _stage_name;
            set
            {
                _stage_name = value;
            }
        }

        public void ChipTunning_Stage1(Engine engine)
        {
            //int _choice = 0;
            //Console.WriteLine("Stage 1: +30 KM");
            //Console.WriteLine("Stage 2: +70 KM");
            //Console.WriteLine("Stage 3: +140 KM");
            //_choice = Int16.Parse(Console.ReadLine());
            //switch (_choice)
            //{
                //case 1:
                    engine.Horsepower = 30;
                    engine.Is_Chip_Tuned = true;
                    this.StageName = "Stage 1";
                    //break;
                //case 2:
                    //engine.Horsepower = 70;
                    //engine.Is_Chip_Tuned = true;
                    //break;
               // case 3:
                    //engine.Horsepower = 140;
                    //engine.Is_Chip_Tuned = true;
                    //break;
                //default:
                    //Console.WriteLine("Chipmapping skipped");
                    //break;
            //}                
        }
        public void ChipTunning_Stage2(Engine engine)
        {
            engine.Horsepower = 70;
            engine.Is_Chip_Tuned = true;
            this.StageName = "Stage 2";
        }
        public void ChipTunning_Stage3(Engine engine)
        {
            engine.Horsepower = 140;
            engine.Is_Chip_Tuned = true;
            this.StageName = "Stage 3";
        }
        public void Display_Info()
        {
            Console.WriteLine($"Chip tuning: {_stage_name}");
        }
    }
}
