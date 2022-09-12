using System.Collections.Generic;
using System.Web.Http;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.WebApi;
using UmbracoCar.Models;

namespace UmbracoCar.Controllers
{
    public class ModelController : UmbracoApiController
    {
        // GET: api/Model
        [Route("api/Model")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Model/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Model
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Model/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Model/5
        public void Delete(int id)
        {
        }
    }
}
