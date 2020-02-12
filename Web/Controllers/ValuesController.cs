using System.Collections.Generic;
using System.Web.Http;

namespace Web.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("test")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Teste de Get
        /// </summary>
        /// <remarks>
        /// Teste
        /// </remarks>
        /// <param name="id">ID irrelevante ao processo.</param>
        /// <param name="valor1">Valores para teste.</param>
        /// <param name="valor2">Valores para teste.</param>
        /// <returns>Uma string fixa.</returns>
        /// <response code="200">Returns the newly created item</response>
        [Route("teste")]
        public string Get(int id, int valor1, int valor2)
        {
            var test = id * valor1;
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
