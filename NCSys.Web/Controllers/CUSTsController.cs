using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NCSys.Models;
using NCSys.Web.Models;

namespace NCSys.Web.Controllers
{
    public class CUSTsController : Controller
    {
        private NCSysWebContext db = new NCSysWebContext();

        // GET: CUSTs
        public async Task<ActionResult> Index()
        {
            return View(await db.CUSTs.ToListAsync());
        }

        // GET: CUSTs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUST cUST = await db.CUSTs.FindAsync(id);
            if (cUST == null)
            {
                return HttpNotFound();
            }
            return View(cUST);
        }

        // GET: CUSTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CUSTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CUST_ID,CUST_NAME,INDUSTRY_ID,CUST_LOCATION,PARENT_ID,CUST_CODE,STATE,EFF_DATE,EXP_DATE,PASSWD,CUST_CATEGORY,AGREEMENT_ID,IS_VIP,LATN_ID,IMP_CUST_TYPE,CUST_CLASS,CUST_TYPE,CHARGE_PROVINCE_CODE,CHARGE_LATN_ID,CUST_SUB_BRAND,CUST_BRAND,CUST_SERVD_LEVEL,SALE_ORGANIZE_ID,COUNTY_TYPE,MANAGE_LEVEL,GRID_CODE,NEW_CUST_TYPE,AREA_ID,MANAGE_CUST_ID,GROUP_GRADE,CUST_TYPE_ID,REGION_SALE_CODE")] CUST cUST)
        {
            if (ModelState.IsValid)
            {
                db.CUSTs.Add(cUST);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cUST);
        }

        // GET: CUSTs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUST cUST = await db.CUSTs.FindAsync(id);
            if (cUST == null)
            {
                return HttpNotFound();
            }
            return View(cUST);
        }

        // POST: CUSTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CUST_ID,CUST_NAME,INDUSTRY_ID,CUST_LOCATION,PARENT_ID,CUST_CODE,STATE,EFF_DATE,EXP_DATE,PASSWD,CUST_CATEGORY,AGREEMENT_ID,IS_VIP,LATN_ID,IMP_CUST_TYPE,CUST_CLASS,CUST_TYPE,CHARGE_PROVINCE_CODE,CHARGE_LATN_ID,CUST_SUB_BRAND,CUST_BRAND,CUST_SERVD_LEVEL,SALE_ORGANIZE_ID,COUNTY_TYPE,MANAGE_LEVEL,GRID_CODE,NEW_CUST_TYPE,AREA_ID,MANAGE_CUST_ID,GROUP_GRADE,CUST_TYPE_ID,REGION_SALE_CODE")] CUST cUST)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cUST).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cUST);
        }

        // GET: CUSTs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CUST cUST = await db.CUSTs.FindAsync(id);
            if (cUST == null)
            {
                return HttpNotFound();
            }
            return View(cUST);
        }

        // POST: CUSTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CUST cUST = await db.CUSTs.FindAsync(id);
            db.CUSTs.Remove(cUST);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
