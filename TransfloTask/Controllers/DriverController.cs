using Microsoft.AspNetCore.Mvc;
using TransfloTask.Models;
using TransfloTask.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransfloTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private DriverService driverService;
        public DriverController() {
            driverService= new DriverService();
        }

        // GET: api/<DriverController>
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            return driverService.getAllDrivers();
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public Driver Get(int id)
        {
           return driverService.getDriversById(id);
        }

        // POST api/<DriverController>
        [HttpPost]
        public void Post([FromBody] Driver value)
        {
            driverService.postDriver(value);
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Driver value)
        {
            driverService.putDriver(id, value);
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            driverService.deleteDriver(id);
        }
    }
}
