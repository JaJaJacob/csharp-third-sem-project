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
    public class FrontBumper
    {
        string _front_bumper_id;
        string _front_bumper_name;
        string _image = "0"; //obraz zderzaka
        decimal _Cx;
        public FrontBumper ()
        {
            this._front_bumper_id = "FBI00";
            this._front_bumper_name = "STOCK FRONT BUMPER";
            this._Cx = 0.5m;
        }
        public FrontBumper(string _front_bumper_name, decimal _Cx): this()
        {
            this._front_bumper_name = _front_bumper_name;
            this._Cx = _Cx;
        }

        public string FrontBumperName
        {
            get => _front_bumper_name;
        }

        public void Display_Info()
        {
            //base.Display_Info();
            System.Console.WriteLine($"Front bumper: {_front_bumper_name} {_Cx}");
        }
    }

}
