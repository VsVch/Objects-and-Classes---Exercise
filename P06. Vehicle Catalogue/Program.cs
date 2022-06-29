using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                string[] informashion = Console.ReadLine().Split();
                if (informashion[0] == "End")
                {
                    break;
                }

               

                
                string typeOfvehicle = informashion[0];
                string model = informashion[1];
                string color = informashion[2];
                int horsePower = int.Parse(informashion[3]);


                var vehicle = new Vehicle(typeOfvehicle, model, color, horsePower);
                vehicles.Add(vehicle);

            }

            while (true)
            {

                string modelCT = Console.ReadLine();

                if (modelCT == "Close the Catalogue")
                {
                    break;
                }

                Console.WriteLine(vehicles.Find(x => x.Model == modelCT));
            }

                var onlyCars = vehicles.Where(x => x.Type == "car").ToList();
                var onlyTrucks = vehicles.Where(x => x.Type == "truck").ToList();

                double totalCarsHorses = 0;
                double totalTrucksHorses = 0;

                foreach (var car in onlyCars)
                {
                    totalCarsHorses += car.HorsePower;
                }
                foreach (var truck in onlyTrucks)
                {
                    totalTrucksHorses += truck.HorsePower;
                }

                double averageCarsHorses = totalCarsHorses / onlyCars.Count;
                double averageTrucksHorses = totalTrucksHorses / onlyTrucks.Count;
                if (onlyCars.Count > 0)
                {
                    Console.WriteLine($"Cars have average horsepower of: {averageCarsHorses:f2}.");
                }
                else
                {
                    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                }
                if (onlyTrucks.Count > 0)
                {
                    Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorses:f2}.");
                }
                else
                {
                    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                }

            
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        
        
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }


        public override string ToString()
        {
            string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.HorsePower}";
                                

            return vehicleStr;
        }




    }
}
