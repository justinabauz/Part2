using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebResources.Models;

namespace WebResources.Controllers
{
    public class GateController: ODataController
    {
        private List<Gate> _gates = new List<Gate>()
        {
            new Gate(){ Id = 1, Code = "G001", Description = "North gate"},
            new Gate(){ Id = 2, Code = "G002", Description = "West gate"},
            new Gate(){ Id = 3, Code = "G003", Description = "South gate"},
            new Gate(){ Id = 4, Code = "G004", Description = "East gate"}
        };

        [EnableQuery]
        public IHttpActionResult Get()
        {
            return Ok(_gates.AsQueryable());
        }
        [EnableQuery]
        public SingleResult<Gate> Get([FromODataUri] int key)
        {
            IQueryable<Gate> result = _gates.Where(p => p.Id == key).AsQueryable();
            return SingleResult.Create(result);
        }

        private bool ProductExists(int key)
        {
            return _gates.Any(p => p.Id == key);
        }
        protected override void Dispose(bool disposing)
        {            
            base.Dispose(disposing);
        }


    }
}