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
    public class CUSTsController : ApiController
    {
        private NCSysAPIContext db = new NCSysAPIContext();

        // GET: api/CUSTs
        public IQueryable<CUST> GetCUSTs()
        {
            return db.CUSTs;
        }

        // GET: api/CUSTs/5
        [ResponseType(typeof(CUST))]
        public async Task<IHttpActionResult> GetCUST(int id)
        {
            CUST cUST = await db.CUSTs.FindAsync(id);
            if (cUST == null)
            {
                return NotFound();
            }

            return Ok(cUST);
        }

        // PUT: api/CUSTs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCUST(int id, CUST cUST)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cUST.CUST_ID)
            {
                return BadRequest();
            }

            db.Entry(cUST).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CUSTExists(id))
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

        // POST: api/CUSTs
        [ResponseType(typeof(CUST))]
        public async Task<IHttpActionResult> PostCUST(CUST cUST)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CUSTs.Add(cUST);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cUST.CUST_ID }, cUST);
        }

        // DELETE: api/CUSTs/5
        [ResponseType(typeof(CUST))]
        public async Task<IHttpActionResult> DeleteCUST(int id)
        {
            CUST cUST = await db.CUSTs.FindAsync(id);
            if (cUST == null)
            {
                return NotFound();
            }

            db.CUSTs.Remove(cUST);
            await db.SaveChangesAsync();

            return Ok(cUST);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CUSTExists(int id)
        {
            return db.CUSTs.Count(e => e.CUST_ID == id) > 0;
        }
    }
}