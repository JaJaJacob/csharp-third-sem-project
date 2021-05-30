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
    public class Bonnet 
    {
        string _bonnet_id;
        string _bonnet_name;
        string _image = "0"; //obraz zderzaka
        decimal _Cx;
        public Bonnet()
        {
            this._bonnet_id = "BI00";
            this._bonnet_name = "STOCK BONNET";
            this._Cx = 0.52m;
        }
        public Bonnet(string _bonnet_name, decimal _downforce) : this()
        {
            this._bonnet_name = _bonnet_name;
            this._Cx = _Cx;
        }

        public string BonnetName
        {
            get => _bonnet_name;
        }
        public void Display_Info()
        {
            //base.Display_Info();
            System.Console.WriteLine($"Bonnet: {_bonnet_name} {_Cx}");
        }
    }

}
