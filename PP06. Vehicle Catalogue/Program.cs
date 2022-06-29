using System;
using System.Collections.Generic;
using System.Linq;

namespace PP06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> vehicles = new List<Car>();
            string inputVehicles = Console.ReadLine();
            while (inputVehicles != "End")
            {
                string[] newVehicles = inputVehicles.Split();
                string type = newVehicles[0];
                string model = newVehicles[1];
                string color = newVehicles[2];
                double power = double.Parse(newVehicles[3]);
                var addVehicles = new Car(type, model, color, power);
                vehicles.Add(addVehicles);
                inputVehicles = Console.ReadLine();
            }
            string criteris = Console.ReadLine();
            while (criteris != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.Find(x => x.Model == criteris));
                criteris = Console.ReadLine();
            }
            var onlyCar = vehicles.Where(x => x.Type == "car").ToList();
            var onlyTruck = vehicles.Where(x => x.Type == "truck").ToList();
            double carHorses = 0;
            double truckHorses = 0;
            foreach (var car in onlyCar)
            {
                carHorses += car.HorsePower;
            }
            double averCarHor = carHorses / onlyCar.Count;
            foreach (var truck in onlyTruck)
            {
                truckHorses += truck.HorsePower;
            }
            double averTrackHor = truckHorses / onlyTruck.Count;

            if (onlyCar.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averCarHor:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTruck.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averTrackHor:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }


        }
    }
    public class Car
    { 
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        

        public Car(string typeOfVehicle, string modelOfVehicle, string colorOfVechicle, double horsePowerOfVehicle)
        {
            this.Type = typeOfVehicle;
            this.Model = modelOfVehicle;
            this.Color = colorOfVechicle;
            this.HorsePower = horsePowerOfVehicle;
        
        }
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
