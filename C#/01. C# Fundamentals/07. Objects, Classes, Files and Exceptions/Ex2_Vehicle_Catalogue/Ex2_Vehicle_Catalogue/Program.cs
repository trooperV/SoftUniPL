using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Vehicle_Catalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //{typeOfVehicle} {model} {color} {horsepower}

            //Type: { typeOfVehicle}
            //Model: { modelOfVehicle}
            //Color: { colorOfVehicle}
            //Horsepower: { horsepowerOfVehicle}

            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End") break;

                Vehicle vehicleTemp = new Vehicle();
                vehicleTemp.Type = input[0].ToLower();
                vehicleTemp.Model = input[1];
                vehicleTemp.Color = input[2];
                vehicleTemp.HorsePower = double.Parse(input[3]);

                vehicles.Add(vehicleTemp);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Close the Catalogue") break;

                foreach (Vehicle vehicle in vehicles.Where(a => a.Model == input))
                {
                    string typeVehicle = "";
                    if (vehicle.Type == "car")
                    {
                        typeVehicle = "Car";
                    }
                    else if(vehicle.Type == "truck")
                    {
                        typeVehicle = "Truck";
                    }
                    Console.WriteLine($"Type: {typeVehicle}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
            }

            if (vehicles.Where(a => a.Type == "car").Count() > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(vehicles.Where(a => a.Type == "car").Sum(a => a.HorsePower) / vehicles.Where(a => a.Type == "car").Count()):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (vehicles.Where(a => a.Type == "truck").Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(vehicles.Where(a => a.Type == "truck").Sum(a => a.HorsePower) / vehicles.Where(a => a.Type == "truck").Count()):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
