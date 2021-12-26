using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace OrderServcie.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrder")]
        public string Get()
        {
            return "good";

           //var daprClient = new DaprClientBuilder().Build();
           // var conent = daprClient.InvokeMethodAsync<IEnumerable<Object>>(HttpMethod.Get, "ProductService", "WeatherForecast");
           // return conent.Result;

        }
    }
}