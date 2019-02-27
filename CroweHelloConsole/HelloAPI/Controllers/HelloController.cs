using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using HelloService;
using HelloAPI.Models;

namespace HelloAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        IWriter Writer;

        public HelloController(IOptions<WriterConfig> options)
        {
            Writer = (IWriter)System.Reflection.Assembly.GetAssembly(typeof(IWriter)).CreateInstance(options.Value.WriterClass);
        }

        [HttpPost]
        public string SayHello([FromBody] string value)
        {
            Writer.Write(value);
            return value;
        }
    }
}