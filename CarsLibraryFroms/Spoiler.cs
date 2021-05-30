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
    public class Spoiler 
    {
        string _spoiler_id;
        string _spoiler_name;
        string _image = "0"; //obraz zderzaka
        decimal _downforce;
        public Spoiler()
        {
            this._spoiler_id = "SI00";
            this._spoiler_name = "STOCK SPOILER BUMPER";
            this._downforce = 110;
        }

        public Spoiler(string _spoiler_name, decimal _downforce) : this()
        {
            this._spoiler_name = _spoiler_name;
            this._downforce = _downforce;
        }

        public string SpoilerName
        {
            get => _spoiler_name;
        }
        public void Display_Info()
        {
            //base.Display_Info();
            System.Console.WriteLine($"Spoiler: {_spoiler_name} {_downforce}");
        }
    }

}
