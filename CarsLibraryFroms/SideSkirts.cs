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
    public class SideSkirts 
    {
        string _sideskirt_id;
        string _sideskirt_name;
        string _image = "0"; //obraz zderzaka
        decimal _Cx;
        public SideSkirts()
        {
            this._sideskirt_id = "FBI00";
            this._sideskirt_name = "STOCK SIDESKIRTS";
            this._Cx = 0.5m;
        }

        public SideSkirts(string _sideskirt_name, decimal _Cx) : this()
        {
            this._sideskirt_name = _sideskirt_name;
            this._Cx = _Cx;
        }

        public string SideSkirtName
        {
            get => _sideskirt_name;
        }

        public void Display_Info()
        {
            //base.Display_Info();
            System.Console.WriteLine($"Sideskirt: {_sideskirt_name} {_Cx}");
        }
    }

}
