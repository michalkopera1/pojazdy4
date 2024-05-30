using System;
using System.Collections.Generic;
using ClassLibrary1;
using System.Linq;
using VehiclesLibrary;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            Plane boeing = new Plane(300, Engine.FuelType.Petrol); //samolot

            Car ford = new Car(100, Engine.FuelType.Petrol); // auto 

            Boat arka = new Boat(10000, 20000);  // lodz

            Amphibian amphibian = new Amphibian(200, 500);  // amfibia

            vehicleList.Add(boeing);  // samolot 

            vehicleList.Add(ford);  // auto 

            vehicleList.Add(arka);   // lodz

            vehicleList.Add(amphibian); // amfibia

            
            foreach(var v in vehicleList)
                Console.WriteLine(v);

            Console.WriteLine("-Onground vehicles-\n");

            var groundVehicles = vehicleList.Where(vehicle => vehicle.actualEnv == Environments.OnGround);

            foreach(var v in groundVehicles)
                Console.WriteLine(v);

            Console.WriteLine("-By Speed ascending-\n");

            boeing.Accelerate(100);
            boeing.Fly();                   // samolot
            boeing.Accelerate(150);

            ford.Accelerate(150);  // auto 

            arka.Accelerate(40);            //lodz

            amphibian.Accelerate(100);  // amfibia 
            amphibian.Sail();


            Console.WriteLine();
            var bySpeedAsc = vehicleList.OrderBy(vehicle => Vehicle.UnitConverter(vehicle.ActualSpeed, vehicle.actualUnit, SpeedUnits.KMpH));
            foreach(var v in bySpeedAsc)
                Console.WriteLine(v);

            Console.WriteLine("-Onground vehicles orderder by speed descending-");

            var groundByDesc = vehicleList.Where(vehicle => vehicle.actualEnv == Environments.OnGround).OrderByDescending(vehicle => Vehicle.UnitConverter(vehicle.ActualSpeed, vehicle.actualUnit, SpeedUnits.KMpH));
            foreach (var v in groundByDesc)
                Console.WriteLine(v);

           
        }
    }
}
