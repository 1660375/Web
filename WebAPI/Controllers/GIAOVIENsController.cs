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
    public class GIAOVIENsController : ApiController
    {

        [HttpGet]
        [Route("api/GIAOVIENs")]

        //GET: api/GIAOVIENs
        public IHttpActionResult GetGIAOVIENs()
        {
            using (GIAOVIENs gv = new GIAOVIENs())
            {
                var gIAOVIEN = gv.LoadTeacher();
                if (gIAOVIEN == null)
                {
                    return NotFound();
                }
                return Ok(gIAOVIEN);
            }
        }

        // GET: api/GIAOVIENs/5
        //[ResponseType(typeof(GIAOVIEN))]
        //public IHttpActionResult GetGIAOVIEN(string id)
        //{
        //    GIAOVIEN gIAOVIEN = db.GIAOVIENs.Find(id);
        //    if (gIAOVIEN == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(gIAOVIEN);
        //}

        //// PUT: api/GIAOVIENs/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutGIAOVIEN(string id, GIAOVIEN gIAOVIEN)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != gIAOVIEN.MAGV)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(gIAOVIEN).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!GIAOVIENExists(id))
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

        //// POST: api/GIAOVIENs
        //[ResponseType(typeof(GIAOVIEN))]
        //public IHttpActionResult PostGIAOVIEN(GIAOVIEN gIAOVIEN)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.GIAOVIENs.Add(gIAOVIEN);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (GIAOVIENExists(gIAOVIEN.MAGV))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = gIAOVIEN.MAGV }, gIAOVIEN);
        //}

        //// DELETE: api/GIAOVIENs/5
        //[ResponseType(typeof(GIAOVIEN))]
        //public IHttpActionResult DeleteGIAOVIEN(string id)
        //{
        //    GIAOVIEN gIAOVIEN = db.GIAOVIENs.Find(id);
        //    if (gIAOVIEN == null)
        //    {
        //        return NotFound();
        //    }

        //    db.GIAOVIENs.Remove(gIAOVIEN);
        //    db.SaveChanges();

        //    return Ok(gIAOVIEN);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool GIAOVIENExists(string id)
        //{
        //    return db.GIAOVIENs.Count(e => e.MAGV == id) > 0;
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