using BussinessObject.Data;
using BussinessObject.Models;
using BussinessObject.Status;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotelManagementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;


        IManagerRepo managerRepo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IManagerRepo managerRepo)
        {
            _logger = logger;
            this.managerRepo = managerRepo;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public string Test()
        {
            try
            {
                Manager manager = new Manager();
                manager.FullName = "1";
                manager.Status = AccountStatus.ACTIVE;
                manager.IdentityCardNumber = "123456789012";
                manager.UserName = "1";
                manager.Password = "1";

                managerRepo.AddManager(manager);

                return "Ahihi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
