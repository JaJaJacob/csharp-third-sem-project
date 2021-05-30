/* Opis programu
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace CarsLibrary
{
    public class Tire 
    {
        string _tire_id;
        string _tire_name;
        string _image = "0"; //obraz zderzaka
        decimal _grip;
        public Tire()
        {
            this._tire_id = "TI00";
            this._tire_name = "STOCK TIRE";
            this._grip = 110;
        }

        public Tire(string _tire_name, decimal _grip) : this()
        {
            this._tire_name = _tire_name;
            this._grip = _grip;
        }

        public string TireName
        {
            get => _tire_name;
        }
        public void Display_Info()
        {
            //base.Display_Info();
            System.Console.WriteLine($"Tire: {_tire_name} {_grip}");
        }
    }

}
