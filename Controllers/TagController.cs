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
    [SwaggerTag("Create, read, update and delete Tags")]
    public class TagController : ControllerBase
    {

        private readonly ILogger<TagController> _logger;

        public TagController(ILogger<TagController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Retrieves queried tag(s) 
        /// </summary>
        [HttpGet()]
        //[ProducesResponseType(typeof(ResponsePage<Tag>), 200)]
        public ResponsePage<Tag> Tags(string code, string name, [FromQuery(Name = "page-index")] int pageIndex, [FromQuery(Name = "page-size")] int pageSize)
        {
            return new ResponsePage<Tag> { HasNextPage = true };
        }


        /// <summary>
        /// Creates new tag(s) 
        /// </summary>
        [HttpPost]
        public void Post([FromBody] IEnumerable<Tag> items)
        {

        }


        /// <summary>
        /// Updates existing tag 
        /// </summary>
        [HttpPatch("{tag-code}")]
        public void Patch([FromRoute(Name = "tag-code")] string tagCode, [FromBody] TagPatch patch)
        {

        }


        /// <summary>
        /// Deletes existing tag 
        /// </summary>

        [HttpDelete("{tag-code}")]
        public void Delete([FromRoute(Name = "tag-code")] string tagCode, [FromQuery(Name = "force-delete")] bool forceDelete = false)
        {
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
