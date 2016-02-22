using Brewr.Models.Brew;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Brewr.Controllers
{
    public class BrewsController : ApiController
    {
        private readonly BrewRepository _repo = new BrewRepository();
        // GET: Brew
        [HttpGet]
        public List<Brew> Get()
        {
            return _repo.GetAll();
        }
    }
}