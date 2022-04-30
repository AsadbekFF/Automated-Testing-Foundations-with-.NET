using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collections
{
    public static class AddGetRecordsXml
    {
        private static readonly XmlSerializer xmlSerializer = new(typeof(List<Vehicle>));

        public static void AddRecord()
        {
            Engine engine1 = new()
            {
                Power = 200,
                Capacity = 2,
                SerialNumber = 123,
                Type = "GTX"
            };
            Engine engine2 = new()
            {
                Power = 300,
                Capacity = 3,
                SerialNumber = 321,
                Type = "GTX"
            };
            Engine engine3 = new()
            {
                Power = 100,
                Capacity = 1,
                SerialNumber = 111,
                Type = "GTX"
            };

            Transmission transmission1 = new()
            {
                Manufacturer = "Chevralet",
                NumOfGears = 6,
                Type = "Front wheel drive"
            };
            Transmission transmission2 = new()
            {
                Manufacturer = "BMW",
                NumOfGears = 6,
                Type = "all-wheel drive"
            };
            Transmission transmission3 = new()
            {
                Manufacturer = "Mercedes",
                NumOfGears = 6,
                Type = "Back wheel drive"
            };

            Chassis chassis1 = new()
            {
                LoadCapacity = 1500,
                Number = 4,
                NumOfWheels = 4
            };
            Chassis chassis2 = new()
            {
                LoadCapacity = 1000,
                Number = 444,
                NumOfWheels = 4
            };
            Chassis chassis3 = new()
            {
                LoadCapacity = 500,
                Number = 234,
                NumOfWheels = 4
            };

            List<Vehicle> vehicles = new();

            Bus bus = new()
            {
                Chassis = chassis1,
                Engine = engine2,
                Transmission = transmission3,
                NumOfSeats = 27
            };
            Car car = new()
            {
                Chassis = chassis2,
                Transmission = transmission2,
                Engine = engine1,
                Weight = 1500,
            };
            Scooter scooter = new()
            {
                Chassis = chassis3,
                Transmission = transmission1,
                Engine = engine3
            };
            Truck truck = new()
            {
                Chassis = chassis1,
                Transmission = transmission2,
                Engine = engine2,
                WheelSize = 50
            };

            Car car1 = new Car
            {
                Chassis = chassis1,
                Engine = engine1,
                Transmission = transmission1,
                Weight = 1000
            };

            vehicles.Add(car);
            vehicles.Add(bus);
            vehicles.Add(scooter);
            vehicles.Add(truck);
            vehicles.Add(car1);

            using (FileStream file =
                File.OpenWrite(
                    @"E:\Epam_Stajirovka\Automated-Testing-Foundations-with-.NET\" 
                    + @"Collections\ConsoleApp1\ConsoleApp1\Transports.xml"))
            {
                xmlSerializer.Serialize(file, vehicles);
            }
        }

        public static List<Vehicle> GetRecords()
        {
            FileStream file = File.OpenRead(@"E:\Epam_Stajirovka\Automated-Testing-Foundations-with-.NET\"
                                            + @"Collections\ConsoleApp1\ConsoleApp1\Transports.xml");

            var vehicles = xmlSerializer.Deserialize(file);

            file.Close();

            return vehicles as List<Vehicle>;
        }
    }
}
