using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Server.Options;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly JwtIssuerOptions _jwtIssuerOptions;
        private readonly JsonSerializerSettings _serializerSettings;

        public ValuesController(IOptionsSnapshot<JwtIssuerOptions> jwtIssuerOptions)
        {
            _jwtIssuerOptions = jwtIssuerOptions.Value;
            _serializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
        }

        // GET api/values
        [HttpGet]
        public object Get()
        {
            var jwtId = User.Claims.First(x => x.Type == "jti").Value;
            var userId = User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
            return User.Claims.Select(c =>
            new
            {
                Type = c.Type,
                Value = c.Value
            });
            // return new string [] { _jwtIssuerOptions.Issuer, _jwtIssuerOptions.Audience };
            // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public string Get(int id)
        {
            var response = new 
            {
                made_it = "Welcome Admin!"
            };
            var json = JsonConvert.SerializeObject(response, _serializerSettings);
            return json;
            // return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
