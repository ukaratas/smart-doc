using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace smart_doc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnotationController : ControllerBase
    {

        private readonly ILogger<AnnotationController> _logger;

        public AnnotationController(ILogger<AnnotationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPost]
        public IEnumerable<string> Post()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPatch("{annotation-id}")]
        public IEnumerable<string> Patch()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpDelete("{annotation-id}")]
        public IEnumerable<string> Delete()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpGet("{annotation-id}")]
        public IEnumerable<string> Annotation()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


    }
}
