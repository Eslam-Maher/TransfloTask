using TransfloTask.Models;

namespace TransfloTask.Services
{
    public class DriverService
    {
        public List<Driver> getAllDrivers() {

            return Helper.getDriversFromJson();
        
        }
        public Driver getDriversById(int inputId)
        {

            return Helper.getDriversFromJson().FirstOrDefault(x=>x.Id== inputId);

        }

        public void postDriver(Driver newDriver)
        {

            Helper.PostDriversToJson(newDriver);

        }
        public void putDriver(int id ,Driver newDriver)
        {
            List<Driver> drivers = Helper.getDriversFromJson();

            Driver temp = drivers.Where(d => d.Id == id).FirstOrDefault();

            temp.FirstName = newDriver.FirstName;
            temp.LastName = newDriver.LastName;
            temp.Email = newDriver.Email;
            temp.PhoneNumber = newDriver.PhoneNumber;
            Helper.PostDriversToJson(drivers);

        }
        public void deleteDriver(int id)
        {
            List<Driver> drivers = Helper.getDriversFromJson();

            drivers.Remove(drivers.FirstOrDefault(d => d.Id == id));

            
            Helper.PostDriversToJson(drivers);

        }
    }
}
