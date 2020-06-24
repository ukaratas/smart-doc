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
    [Route("[controller]")]
    public class TagController : ControllerBase
    {

        private readonly ILogger<TagController> _logger;

        public TagController(ILogger<TagController> logger)
        {
            _logger = logger;
        }


        [HttpGet()]
        public IEnumerable<string> Tags()
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


        [HttpGet("{tag-code}")]
        public IEnumerable<string> Tag()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPatch("{tag-code}")]
        public IEnumerable<string> Patch()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpDelete("{tag-code}")]
        public IEnumerable<string> Delete()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpGet("{tag-code}/Statistics")]
        public IEnumerable<string> Statistics()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpGet("{tag-code}/History")]
        public IEnumerable<string> History()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        #region  Instance


        [HttpGet("{tag-code}/Instance/{instance-id}")]
        [SwaggerOperation(OperationId = "TagInstanceGet", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> Instance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }



        [HttpGet("{tag-code}/Instance/{instance-id}/History")]
        [SwaggerOperation(OperationId = "TagInstanceHistory", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> InstanceHistory()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }



        [HttpPost("{tag-code}/Instance")]
        [SwaggerOperation(OperationId = "TagInstancePost", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> PostInstance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpPatch("{tag-code}/Instance/{instance-id}")]
        [SwaggerOperation(OperationId = "TagInstancePatch", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> PatchInstance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpDelete("{tag-code}/Instance/{instance-id}")]
        [SwaggerOperation(OperationId = "TagInstanceDelete", Tags = new[] { "Tag - Instance" })]
        public IEnumerable<string> DeleteInstance()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        #endregion

        #region Properties

        [HttpGet("{tag-code}/Property")]
        [SwaggerOperation(OperationId = "TagPropertyGet", Tags = new[] { "Tag - Properties" })]
        public IEnumerable<string> Properties()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpPost("{tag-code}/Property")]
        [SwaggerOperation(OperationId = "TagPropertyPost", Tags = new[] { "Tag - Properties" })]
        public IEnumerable<string> PostProperty()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }


        [HttpPatch("{tag-code}/Property/{property-code}")]
        [SwaggerOperation(OperationId = "TagPropertyPatch", Tags = new[] { "Tag - Properties" })]
        public IEnumerable<string> PatchProperty()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        [HttpDelete("{tag-code}/Property/{property-code}")]
        [SwaggerOperation(OperationId = "TagPropertyDelete", Tags = new[] { "Tag - Properties" })]
        public IEnumerable<string> DeleteProperty()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => index.ToString()).ToArray();
        }

        #endregion

    }
}
