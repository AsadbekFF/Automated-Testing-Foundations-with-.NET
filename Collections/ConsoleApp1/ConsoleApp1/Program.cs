using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            AddGetRecordsXml.AddRecord();

            List<Vehicle> vehicles = AddGetRecordsXml.GetRecords();

            var capacityOfEngine = from vehicle in vehicles
                                   where vehicle.Engine.Capacity > 1.5
                                   select vehicle;

            Console.WriteLine("Engine of vehicles that is lower than 1.5");
            foreach (var item in capacityOfEngine)
            {
                item.GetInfo();
            }

            Console.WriteLine("\n\n");

            var busAndTruck = from bT in vehicles
                              where bT.GetType().Name == "Bus" || bT.GetType().Name == "Truck"
                              select new
                              {
                                  Type = bT.GetType().Name,
                                  TypeOfEngine = bT.Engine.Type,
                                  SerialNumberOfEngine = bT.Engine.SerialNumber,
                                  PowerOfEngine = bT.Engine.Power
                              };

            Console.WriteLine("Bus and Truck");

            foreach (var item in busAndTruck)
            {
                Console.WriteLine($"Type of Engine of {item.Type} is {item.TypeOfEngine}");
                Console.WriteLine($"Serial number of Engine of {item.Type} is {item.SerialNumberOfEngine}");
                Console.WriteLine($"Power of Engine of {item.Type} is {item.PowerOfEngine}");
            }

            Console.WriteLine("\n\n"
                + "Group by transmission");

            var groupByTransmission = from gr in vehicles
                                      group gr by gr.Transmission.Type into Group
                                      select Group;

            foreach (var item in groupByTransmission)
            {
                Console.WriteLine("Transmission of vehicles that is " + item.Key);
                foreach (var itemm in item)
                {
                    itemm.GetInfo();
                }
            }

            Console.ReadKey();
        }
    }
}
