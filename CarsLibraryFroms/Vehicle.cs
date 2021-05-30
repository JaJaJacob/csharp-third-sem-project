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
    public abstract class Vehicle
    {
        private int _vehicle_id = 0; //odczyt i zapis do pliku
        protected string _vehicle_type; //car, truck, bike, motorbike

        public Vehicle(string _vehicle_type)
        {
            //System.Console.WriteLine($"Vehicle type: {_vehicle_type} created!"); 
        }
    }

}
