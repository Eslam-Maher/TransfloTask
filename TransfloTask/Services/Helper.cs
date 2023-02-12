using Newtonsoft.Json;
using System.Collections.Generic;
using TransfloTask.Models;

namespace TransfloTask.Services
{
    public static class Helper
    {
        public static List<Driver> getDriversFromJson()
        {
            string projectDirectory = Directory.GetCurrentDirectory();
            object driverData = File.ReadAllText(projectDirectory + "/InputJsons/drivers.json");
            return JsonConvert.DeserializeObject<List<Driver>>(driverData.ToString());
        }




        public static void PostDriversToJson(Driver newDriver){

            List<Driver> drivers = getDriversFromJson();
            drivers.Add(newDriver);

            // serialize JSON directly to a file again
            using (StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() + "/InputJsons/drivers.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, drivers);
            }
        }
        public static void PostDriversToJson(List<Driver> newDrivers)
        {
            // serialize JSON directly to a file again
            using (StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() + "/InputJsons/drivers.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, newDrivers);
            }
        }
    }
}
