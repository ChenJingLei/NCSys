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
    public class PARTY_ROLEController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/PARTY_ROLE
        public IQueryable<PARTY_ROLE> GetPARTY_ROLE()
        {
            return db.PARTY_ROLE;
        }

        // GET: api/PARTY_ROLE/5
        [ResponseType(typeof(PARTY_ROLE))]
        public async Task<IHttpActionResult> GetPARTY_ROLE(int id)
        {
            PARTY_ROLE pARTY_ROLE = await db.PARTY_ROLE.FindAsync(id);
            if (pARTY_ROLE == null)
            {
                return NotFound();
            }

            return Ok(pARTY_ROLE);
        }

        // PUT: api/PARTY_ROLE/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPARTY_ROLE(int id, PARTY_ROLE pARTY_ROLE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pARTY_ROLE.PARTY_ROLE_ID)
            {
                return BadRequest();
            }

            db.Entry(pARTY_ROLE).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PARTY_ROLEExists(id))
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

        // POST: api/PARTY_ROLE
        [ResponseType(typeof(PARTY_ROLE))]
        public async Task<IHttpActionResult> PostPARTY_ROLE(PARTY_ROLE pARTY_ROLE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PARTY_ROLE.Add(pARTY_ROLE);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pARTY_ROLE.PARTY_ROLE_ID }, pARTY_ROLE);
        }

        // DELETE: api/PARTY_ROLE/5
        [ResponseType(typeof(PARTY_ROLE))]
        public async Task<IHttpActionResult> DeletePARTY_ROLE(int id)
        {
            PARTY_ROLE pARTY_ROLE = await db.PARTY_ROLE.FindAsync(id);
            if (pARTY_ROLE == null)
            {
                return NotFound();
            }

            db.PARTY_ROLE.Remove(pARTY_ROLE);
            await db.SaveChangesAsync();

            return Ok(pARTY_ROLE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PARTY_ROLEExists(int id)
        {
            return db.PARTY_ROLE.Count(e => e.PARTY_ROLE_ID == id) > 0;
        }
    }
}