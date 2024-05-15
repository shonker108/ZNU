using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_delivery_service_app.src
{
    public class Address
    {
        public string region;
        public string city;
        public string street;
        public int house;
        public int? apartment;

        public Address(string region, string city, string street, int house, int? apartment = null)
        {
            this.region = region;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        
        public override string ToString()
        {
            return $"{region},{city},{street},{house}{(apartment is null ? "" : $",{apartment}")}";
        }

        public static Address ToAddress(string text)
        {
            string[] addressElements = text.Split(',');

            // Якщо без квартири...
            if (addressElements.Length == 4)
            {
                return new Address(
                    addressElements[0],             // Область
                    addressElements[1],             // Місто
                    addressElements[2],             // Вулиця
                    int.Parse(addressElements[3])   // Будинок
                );
            }
            else
            {
                return new Address(
                    addressElements[0],             // Область
                    addressElements[1],             // Місто
                    addressElements[2],             // Вулиця
                    int.Parse(addressElements[3]),  // Будинок
                    int.Parse(addressElements[4])   // Квартира
                );
            }
        }
    };
}
