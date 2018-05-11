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
    public class PARTiesController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/PARTies
        public IQueryable<PARTY> GetPARTies()
        {
            return db.PARTies;
        }

        // GET: api/PARTies/5
        [ResponseType(typeof(PARTY))]
        public async Task<IHttpActionResult> GetPARTY(int id)
        {
            PARTY pARTY = await db.PARTies.FindAsync(id);
            if (pARTY == null)
            {
                return NotFound();
            }

            return Ok(pARTY);
        }

        // PUT: api/PARTies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPARTY(int id, PARTY pARTY)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pARTY.PARTY_ID)
            {
                return BadRequest();
            }

            db.Entry(pARTY).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PARTYExists(id))
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

        // POST: api/PARTies
        [ResponseType(typeof(PARTY))]
        public async Task<IHttpActionResult> PostPARTY(PARTY pARTY)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PARTies.Add(pARTY);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pARTY.PARTY_ID }, pARTY);
        }

        // DELETE: api/PARTies/5
        [ResponseType(typeof(PARTY))]
        public async Task<IHttpActionResult> DeletePARTY(int id)
        {
            PARTY pARTY = await db.PARTies.FindAsync(id);
            if (pARTY == null)
            {
                return NotFound();
            }

            db.PARTies.Remove(pARTY);
            await db.SaveChangesAsync();

            return Ok(pARTY);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PARTYExists(int id)
        {
            return db.PARTies.Count(e => e.PARTY_ID == id) > 0;
        }
    }
}