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
    public class PARTY_SERVController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/PARTY_SERV
        public IQueryable<PARTY_SERV> GetPARTY_SERV()
        {
            return db.PARTY_SERV;
        }

        // GET: api/PARTY_SERV/5
        [ResponseType(typeof(PARTY_SERV))]
        public async Task<IHttpActionResult> GetPARTY_SERV(int id)
        {
            PARTY_SERV pARTY_SERV = await db.PARTY_SERV.FindAsync(id);
            if (pARTY_SERV == null)
            {
                return NotFound();
            }

            return Ok(pARTY_SERV);
        }

        // PUT: api/PARTY_SERV/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPARTY_SERV(int id, PARTY_SERV pARTY_SERV)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pARTY_SERV.PARTY_SERV_ID)
            {
                return BadRequest();
            }

            db.Entry(pARTY_SERV).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PARTY_SERVExists(id))
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

        // POST: api/PARTY_SERV
        [ResponseType(typeof(PARTY_SERV))]
        public async Task<IHttpActionResult> PostPARTY_SERV(PARTY_SERV pARTY_SERV)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PARTY_SERV.Add(pARTY_SERV);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pARTY_SERV.PARTY_SERV_ID }, pARTY_SERV);
        }

        // DELETE: api/PARTY_SERV/5
        [ResponseType(typeof(PARTY_SERV))]
        public async Task<IHttpActionResult> DeletePARTY_SERV(int id)
        {
            PARTY_SERV pARTY_SERV = await db.PARTY_SERV.FindAsync(id);
            if (pARTY_SERV == null)
            {
                return NotFound();
            }

            db.PARTY_SERV.Remove(pARTY_SERV);
            await db.SaveChangesAsync();

            return Ok(pARTY_SERV);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PARTY_SERVExists(int id)
        {
            return db.PARTY_SERV.Count(e => e.PARTY_SERV_ID == id) > 0;
        }
    }
}