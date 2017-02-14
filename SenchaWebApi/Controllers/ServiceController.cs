using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using SenchaWebApi.Models;

namespace SenchaWebApi.Controllers
{
    [RoutePrefix("api/reservation")]
    public class ServiceController : ApiController
    {
        [HttpGet, Route("")]
        public IHttpActionResult GetAll()
        {
            var db = new Context();
            return Ok(JsonConvert.SerializeObject(db.Reservations));
        }

        [HttpGet, Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            var db = new Context();
            var context = db.Reservations.FirstOrDefault(x => x.Id == id);
            if (context == null)
            {
                return NotFound();
            }
            return Ok(JsonConvert.SerializeObject(context));
        }
    }
}
