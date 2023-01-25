using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWProvincias_Kuttel.Data;
using SWProvincias_Kuttel.Models;
using System.Collections.Generic;
using System.Linq;

namespace SWProvincias_Kuttel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private readonly DBPaisFinalContext context;

        public ProvinciaController(DBPaisFinalContext context)
        {
            this.context = context;
        }

        //GET api/provincia
        [HttpGet]
        public ActionResult<IEnumerable<Provincia>> GetProvincias()
        {
            return context.Provincias.ToList();
        }


        //POST api/provincia
        [HttpPost]
        public ActionResult PostProvincia(Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Provincias.Add(provincia);
            context.SaveChanges();

            return Ok();
        }

        //PUT api/provincia/:id
        [HttpPut("{id}")]
        public ActionResult PutProvincia(int id, [FromBody] Provincia provincia)
        {
            if (id != provincia.IdProvincia)
            {
                return BadRequest();
            }

            context.Entry(provincia).State = EntityState.Modified;
            context.SaveChanges();

            return Ok();
        }

        //DELETE api/provincia/:id
        [HttpDelete("{id}")]
        public ActionResult<Provincia> DeleteProvincia(int id)
        {
            var provincia = (from a in context.Provincias
                         where a.IdProvincia == id
                         select a).SingleOrDefault();
            if (provincia == null)
            {
                return NotFound();
            }

            context.Provincias.Remove(provincia);
            context.SaveChanges();

            return provincia;
        }

    }
}
