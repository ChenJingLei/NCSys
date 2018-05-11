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
    public class SERV_IDENTIFICATIONController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/SERV_IDENTIFICATION
        public IQueryable<SERV_IDENTIFICATION> GetSERV_IDENTIFICATION()
        {
            return db.SERV_IDENTIFICATION;
        }

        // GET: api/SERV_IDENTIFICATION/5
        [ResponseType(typeof(SERV_IDENTIFICATION))]
        public async Task<IHttpActionResult> GetSERV_IDENTIFICATION(int id)
        {
            SERV_IDENTIFICATION sERV_IDENTIFICATION = await db.SERV_IDENTIFICATION.FindAsync(id);
            if (sERV_IDENTIFICATION == null)
            {
                return NotFound();
            }

            return Ok(sERV_IDENTIFICATION);
        }

        // PUT: api/SERV_IDENTIFICATION/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSERV_IDENTIFICATION(int id, SERV_IDENTIFICATION sERV_IDENTIFICATION)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sERV_IDENTIFICATION.SERV_ID)
            {
                return BadRequest();
            }

            db.Entry(sERV_IDENTIFICATION).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SERV_IDENTIFICATIONExists(id))
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

        // POST: api/SERV_IDENTIFICATION
        [ResponseType(typeof(SERV_IDENTIFICATION))]
        public async Task<IHttpActionResult> PostSERV_IDENTIFICATION(SERV_IDENTIFICATION sERV_IDENTIFICATION)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SERV_IDENTIFICATION.Add(sERV_IDENTIFICATION);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SERV_IDENTIFICATIONExists(sERV_IDENTIFICATION.SERV_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sERV_IDENTIFICATION.SERV_ID }, sERV_IDENTIFICATION);
        }

        // DELETE: api/SERV_IDENTIFICATION/5
        [ResponseType(typeof(SERV_IDENTIFICATION))]
        public async Task<IHttpActionResult> DeleteSERV_IDENTIFICATION(int id)
        {
            SERV_IDENTIFICATION sERV_IDENTIFICATION = await db.SERV_IDENTIFICATION.FindAsync(id);
            if (sERV_IDENTIFICATION == null)
            {
                return NotFound();
            }

            db.SERV_IDENTIFICATION.Remove(sERV_IDENTIFICATION);
            await db.SaveChangesAsync();

            return Ok(sERV_IDENTIFICATION);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SERV_IDENTIFICATIONExists(int id)
        {
            return db.SERV_IDENTIFICATION.Count(e => e.SERV_ID == id) > 0;
        }
    }
}