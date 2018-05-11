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
    public class SERVsController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/SERVs
        public IQueryable<SERV> GetSERVs()
        {
            return db.SERVs;
        }

        // GET: api/SERVs/5
        [ResponseType(typeof(SERV))]
        public async Task<IHttpActionResult> GetSERV(int id)
        {
            SERV sERV = await db.SERVs.FindAsync(id);
            if (sERV == null)
            {
                return NotFound();
            }

            return Ok(sERV);
        }

        // PUT: api/SERVs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSERV(int id, SERV sERV)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sERV.SERV_ID)
            {
                return BadRequest();
            }

            db.Entry(sERV).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SERVExists(id))
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

        // POST: api/SERVs
        [ResponseType(typeof(SERV))]
        public async Task<IHttpActionResult> PostSERV(SERV sERV)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SERVs.Add(sERV);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sERV.SERV_ID }, sERV);
        }

        // DELETE: api/SERVs/5
        [ResponseType(typeof(SERV))]
        public async Task<IHttpActionResult> DeleteSERV(int id)
        {
            SERV sERV = await db.SERVs.FindAsync(id);
            if (sERV == null)
            {
                return NotFound();
            }

            db.SERVs.Remove(sERV);
            await db.SaveChangesAsync();

            return Ok(sERV);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SERVExists(int id)
        {
            return db.SERVs.Count(e => e.SERV_ID == id) > 0;
        }
    }
}