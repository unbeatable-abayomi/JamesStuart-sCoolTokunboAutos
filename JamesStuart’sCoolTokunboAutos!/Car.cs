using System;
using System.Collections.Generic;
using System.Text;

namespace JamesStuart_sCoolTokunboAutos_
{
    class Car
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int Year { get; set; }

        public decimal Price { get; set; }
        
        public Car(string carmake, string carmodel,int year,decimal price)
        {
            CarMake = carmake;
            CarModel = carmodel;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $" {Year} {CarMake} {CarModel} {Price:C}";
        }
    }
}
