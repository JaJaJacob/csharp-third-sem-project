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
    public class Alloys 
    {
        string _alloy_id;
        string _alloy_name;
        string _image = "0"; //obraz zderzaka
        decimal _weight;
        public Alloys()
        {
            this._alloy_id = "AI00";
            this._alloy_name = "STOCK ALLOY";
            this._weight = 13;
        }

        public Alloys(string _alloy_name, decimal _weight) : this()
        {
            this._alloy_name = _alloy_name;
            this._weight = _weight;
        }

        public string AlloyName
        {
            get => _alloy_name;
        }

        public void Display_Info()
        {
            //base.Display_Info();
            System.Console.WriteLine($"Alloys: {_alloy_name} {_weight}");
        }
    }

}
