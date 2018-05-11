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
    public class COMPETITORsController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/COMPETITORs
        public IQueryable<COMPETITOR> GetCOMPETITORs()
        {
            return db.COMPETITORs;
        }

        // GET: api/COMPETITORs/5
        [ResponseType(typeof(COMPETITOR))]
        public async Task<IHttpActionResult> GetCOMPETITOR(int id)
        {
            COMPETITOR cOMPETITOR = await db.COMPETITORs.FindAsync(id);
            if (cOMPETITOR == null)
            {
                return NotFound();
            }

            return Ok(cOMPETITOR);
        }

        // PUT: api/COMPETITORs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCOMPETITOR(int id, COMPETITOR cOMPETITOR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cOMPETITOR.PARTY_ROLE_ID)
            {
                return BadRequest();
            }

            db.Entry(cOMPETITOR).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!COMPETITORExists(id))
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

        // POST: api/COMPETITORs
        [ResponseType(typeof(COMPETITOR))]
        public async Task<IHttpActionResult> PostCOMPETITOR(COMPETITOR cOMPETITOR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.COMPETITORs.Add(cOMPETITOR);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cOMPETITOR.PARTY_ROLE_ID }, cOMPETITOR);
        }

        // DELETE: api/COMPETITORs/5
        [ResponseType(typeof(COMPETITOR))]
        public async Task<IHttpActionResult> DeleteCOMPETITOR(int id)
        {
            COMPETITOR cOMPETITOR = await db.COMPETITORs.FindAsync(id);
            if (cOMPETITOR == null)
            {
                return NotFound();
            }

            db.COMPETITORs.Remove(cOMPETITOR);
            await db.SaveChangesAsync();

            return Ok(cOMPETITOR);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool COMPETITORExists(int id)
        {
            return db.COMPETITORs.Count(e => e.PARTY_ROLE_ID == id) > 0;
        }
    }
}