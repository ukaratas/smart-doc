using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace smart_doc.Controllers
{
    [ApiController]
    [Route("tag")]
    public class TagInstanceController : ControllerBase
    {

        private readonly ILogger<TagInstanceController> _logger;

        public TagInstanceController(ILogger<TagInstanceController> logger)
        {
            _logger = logger;
        }


        [HttpGet("{tag-code}/instance/{instance-id}")]
        [SwaggerOperation(OperationId = "TagInstanceGet", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> Instance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }



        [HttpGet("{tag-code}/instance/{instance-id}/History")]
        [SwaggerOperation(OperationId = "TagInstanceHistory", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> InstanceHistory()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }



        [HttpPost("{tag-code}/instance")]
        [SwaggerOperation(OperationId = "TagInstancePost", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> PostInstance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpPatch("{tag-code}/instance/{instance-id}")]
        [SwaggerOperation(OperationId = "TagInstancePatch", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> PatchInstance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpDelete("{tag-code}/instance/{instance-id}")]
        [SwaggerOperation(OperationId = "TagInstanceDelete", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> DeleteInstance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

    }
}
