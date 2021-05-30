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
    public class RearBumper 
    {
        string _rear_bumper_id;
        string _rear_bumper_name;
        string _image = "0"; //obraz zderzaka
        decimal _Cx;
        public RearBumper()
        {
            this._rear_bumper_id = "RBI00";
            this._rear_bumper_name = "STOCK REAR BUMPER";
            this._Cx = 0.5m;
        }

        public RearBumper(string _rear_bumper_name, decimal _Cx) : this()
        {
            this._rear_bumper_name = _rear_bumper_name;
            this._Cx = _Cx;
        }
        public string RearBumperName
        {
            get => _rear_bumper_name;
        }
        public void Display_Info()
        {
            //base.Display_Info();
            System.Console.WriteLine($"Rear bumper: {_rear_bumper_name} {_Cx}");
        }
    }

}
