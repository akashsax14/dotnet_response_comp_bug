using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ResponseCompBug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/value
        [HttpGet(Name = "GetObject")]
        [HttpHead(Name = "HeadObject")]
        public IActionResult Get()
        {
            string resultjson = "{ \"FirstName\":\"Dwight\",\"LastName\":\"Schrute\" }";
            var data = Encoding.ASCII.GetBytes(resultjson);
            var fileResult = new FileContentResult(data, "application/json");
            return fileResult;
        }
    }
}