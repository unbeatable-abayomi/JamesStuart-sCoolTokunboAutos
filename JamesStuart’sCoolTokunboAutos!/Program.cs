using System;
using System.Collections.Generic;

namespace JamesStuart_sCoolTokunboAutos_
{
    class Program
    {
        static void Main(string[] args)

        {
            //local variables
            string carMake = ""; string carModel  = ""; int carYear = 0; decimal price = 0.0m; string check = "";

            //All Cars List
            List<Car> cars = new List<Car>();
           
            GetCarDetails("=====Welcome to James Stuart’s Cool “Tokunbo” Autos!============");
           
            GetCarDetails(" Enter [Add] to add car\n Enter [List] to view all Cars\n Enter [Quit] to quit\n");
            
            check = Console.ReadLine();
            
            if(check.ToLower() == "list")
            {
             Console.WriteLine("There are currently no cars in the catalog");
            }else if(check.ToLower() == "add")
            {
                string output = "";

                while (check == "add")
                {
                   
                    GetCarDetails("Enter Car Make");
                    carMake = Console.ReadLine();
                    GetCarDetails("Enter Car Model");
                    carModel = Console.ReadLine();
                    GetCarDetails("Enter Car Year");
                    carYear = Convert.ToInt32(Console.ReadLine());
                    GetCarDetails("Enter Price");
                    price = Convert.ToDecimal(Console.ReadLine());
                    Car newcar = new Car(carMake, carModel, carYear, price);
                    cars.Add(newcar);
                    GetCarDetails("Enter: [QUIT] to quit or [LIST] to view all cars or [ADD] to contiue");
                     output = Console.ReadLine();
                    check = output.ToLower();
                }
                if (check.ToLower() == "list")
                {

                    GetCarDetails("====Cars List=====");
                    int count = 0; decimal totalInventory = 0.0M;
                    foreach (Car car in cars)
                    {
                        totalInventory += car.Price;
                        
                       // GetCarDetails(car.ToString());
                        GetCarDetails($"{car.Year} {car.CarMake} {car.CarModel} {car.Price:C} \n");
                        count++;
                    }
                    GetCarDetails($" Number of Cars: {count} \n Total Inventory : {totalInventory:C}");
                }else if(check.ToLower() == "quit") { GetCarDetails("Good Bye"); }
                else
                {
                    GetCarDetails($"Sorry,but '{check}' is not a valid Command.Pls Try Again");
                }
               
                
            }
            else if(check.ToLower() == "quit")
            {
              GetCarDetails("Good Bye");
            }
            else { GetCarDetails($"Sorry,but '{check}' is not a valid Command.Pls Try Again"); }

            
        }


        static void GetCarDetails(string myString)
        {
            Console.WriteLine(myString);
        }
    }
}
