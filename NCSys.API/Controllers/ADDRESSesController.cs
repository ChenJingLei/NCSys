using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using NCSys.API.Models;
using NCSys.Models;

namespace NCSys.API.Controllers
{
    public class ADDRESSesController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/ADDRESSes
        public IQueryable<ADDRESS> GetADDRESSes()
        {
            return db.ADDRESSes;
        }

        // GET: api/ADDRESSes/5
        [ResponseType(typeof(ADDRESS))]
        public async Task<IHttpActionResult> GetADDRESS(int id)
        {
            ADDRESS aDDRESS = await db.ADDRESSes.FindAsync(id);
            if (aDDRESS == null)
            {
                return NotFound();
            }

            return Ok(aDDRESS);
        }

        // PUT: api/ADDRESSes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutADDRESS(int id, ADDRESS aDDRESS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aDDRESS.ADDRESS_ID)
            {
                return BadRequest();
            }

            db.Entry(aDDRESS).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ADDRESSExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ADDRESSes
        [ResponseType(typeof(ADDRESS))]
        public async Task<IHttpActionResult> PostADDRESS(ADDRESS aDDRESS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ADDRESSes.Add(aDDRESS);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = aDDRESS.ADDRESS_ID }, aDDRESS);
        }

        // DELETE: api/ADDRESSes/5
        [ResponseType(typeof(ADDRESS))]
        public async Task<IHttpActionResult> DeleteADDRESS(int id)
        {
            ADDRESS aDDRESS = await db.ADDRESSes.FindAsync(id);
            if (aDDRESS == null)
            {
                return NotFound();
            }

            db.ADDRESSes.Remove(aDDRESS);
            await db.SaveChangesAsync();

            return Ok(aDDRESS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ADDRESSExists(int id)
        {
            return db.ADDRESSes.Count(e => e.ADDRESS_ID == id) > 0;
        }
    }
}