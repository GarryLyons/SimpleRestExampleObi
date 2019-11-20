using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiRestExample.Models;

namespace ApiRestExample.Controllers
{
    public class SccmController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public SccmDataResponse Post([FromBody]SccmDataRequest request)
        {
            var response = new SccmDataResponse();

            try
            {
                if (request==null)
                {
                    throw new ArgumentNullException($"request is null");
                }

                response.Success = true;


            }
            catch (Exception e)
            {
                response.Errors.Add(e.Message);
                response.Success = false;
            }

            return response;

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}