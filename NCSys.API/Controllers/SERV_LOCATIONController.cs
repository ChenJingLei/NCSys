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
    public class SERV_LOCATIONController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/SERV_LOCATION
        public IQueryable<SERV_LOCATION> GetSERV_LOCATION()
        {
            return db.SERV_LOCATION;
        }

        // GET: api/SERV_LOCATION/5
        [ResponseType(typeof(SERV_LOCATION))]
        public async Task<IHttpActionResult> GetSERV_LOCATION(int id)
        {
            SERV_LOCATION sERV_LOCATION = await db.SERV_LOCATION.FindAsync(id);
            if (sERV_LOCATION == null)
            {
                return NotFound();
            }

            return Ok(sERV_LOCATION);
        }

        // PUT: api/SERV_LOCATION/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSERV_LOCATION(int id, SERV_LOCATION sERV_LOCATION)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sERV_LOCATION.SERV_ID)
            {
                return BadRequest();
            }

            db.Entry(sERV_LOCATION).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SERV_LOCATIONExists(id))
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

        // POST: api/SERV_LOCATION
        [ResponseType(typeof(SERV_LOCATION))]
        public async Task<IHttpActionResult> PostSERV_LOCATION(SERV_LOCATION sERV_LOCATION)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SERV_LOCATION.Add(sERV_LOCATION);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SERV_LOCATIONExists(sERV_LOCATION.SERV_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sERV_LOCATION.SERV_ID }, sERV_LOCATION);
        }

        // DELETE: api/SERV_LOCATION/5
        [ResponseType(typeof(SERV_LOCATION))]
        public async Task<IHttpActionResult> DeleteSERV_LOCATION(int id)
        {
            SERV_LOCATION sERV_LOCATION = await db.SERV_LOCATION.FindAsync(id);
            if (sERV_LOCATION == null)
            {
                return NotFound();
            }

            db.SERV_LOCATION.Remove(sERV_LOCATION);
            await db.SaveChangesAsync();

            return Ok(sERV_LOCATION);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SERV_LOCATIONExists(int id)
        {
            return db.SERV_LOCATION.Count(e => e.SERV_ID == id) > 0;
        }
    }
}