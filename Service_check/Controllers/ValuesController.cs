using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_check.Services;

namespace Service_check.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITransitService _transitService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;

        public ValuesController(ITransitService transitService ,ISingletonService singletonService,IScopedService scopedService)
        {
            _scopedService= scopedService;
            _transitService= transitService;
            _singletonService= singletonService;
        }

        [HttpGet("singleton")]
        public string GetSingleton()
        {
            var ab = _singletonService.GetGuid();
            return ab;
        }
        [HttpGet("scoped")]
        public string GetScoped()
        {
            return _scopedService.GetGuid();
        }

        [HttpGet("transient")]
        public string GetTransient()
        {
            return _transitService.GetGuid();
        }


    }
}
