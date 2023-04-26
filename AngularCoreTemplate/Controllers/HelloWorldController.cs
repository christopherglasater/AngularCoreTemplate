using Microsoft.AspNetCore.Mvc;
using AngularCoreTemplate.Models;
using AngularCoreTemplate.Services;

namespace AngularCoreTemplate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class HelloWorldController : Controller
    {
        IHelloWorldService _helloWorldService;
        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService; 
        }

        [HttpGet]
        [Route("GetSomething")]
        public IEnumerable<SomethingModel> GetSomething()
        {
            return _helloWorldService.GetSomething().ToArray();
        }


        [HttpGet]
        [Route("DoSomething/{input}")]
        public SomethingModel DoSomething(string input)
        {
            return _helloWorldService.DoSomething(input);
        }

        [HttpPost]
        [Route("DoSomethingElse")]
        public SomethingModel DoSomethingElse([FromBody] SomethingModel input)
        {
            return _helloWorldService.DoSomethingElse(input);
        }
    }
}
