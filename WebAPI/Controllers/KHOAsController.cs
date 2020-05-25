using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Business;
using DTO;

namespace WebAPI.Controllers
{
    public class KHOAsController : ApiController
    {
        [HttpGet]
        [Route("api/KHOAs")]
        // GET: api/KHOAs
        public IHttpActionResult GetKHOAs()
        {
            using (KHOAs bs = new KHOAs())
            {
                var bOMON = bs.LoadBomon();
                if (bOMON == null)
                {
                    return NotFound();
                }
                return Ok(bOMON);
            }
        }
        // GET: api/KHOAs/5
        //[ResponseType(typeof(KHOA))]
        //public IHttpActionResult GetKHOA(string id)
        //{
        //    KHOA kHOA = db.KHOAs.Find(id);
        //    if (kHOA == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(kHOA);
        //}

        //// PUT: api/KHOAs/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutKHOA(string id, KHOA kHOA)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != kHOA.MAKHOA)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(kHOA).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!KHOAExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/KHOAs
        //[ResponseType(typeof(KHOA))]
        //public IHttpActionResult PostKHOA(KHOA kHOA)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.KHOAs.Add(kHOA);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (KHOAExists(kHOA.MAKHOA))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = kHOA.MAKHOA }, kHOA);
        //}

        //// DELETE: api/KHOAs/5
        //[ResponseType(typeof(KHOA))]
        //public IHttpActionResult DeleteKHOA(string id)
        //{
        //    KHOA kHOA = db.KHOAs.Find(id);
        //    if (kHOA == null)
        //    {
        //        return NotFound();
        //    }

        //    db.KHOAs.Remove(kHOA);
        //    db.SaveChanges();

        //    return Ok(kHOA);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool KHOAExists(string id)
        //{
        //    return db.KHOAs.Count(e => e.MAKHOA == id) > 0;
        //}

        protected override void Dispose(bool disposing)
        {
            using (BOMONs bs = new BOMONs())
            {
                if (disposing)
                {
                    //  db.Dispose();
                }
                base.Dispose(disposing);
            }
        }
    }
}