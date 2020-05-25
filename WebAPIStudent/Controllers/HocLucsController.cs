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
using Student_Class;

namespace WebAPIStudent.Controllers
{
    public class HocLucsController : ApiController
    {
        private TestEntities db = new TestEntities();

        // GET: api/HocLucs
        public IQueryable<HocLuc> GetHocLucs()
        {
            return db.HocLucs;
        }

        // GET: api/HocLucs/5
        [ResponseType(typeof(HocLuc))]
        public IHttpActionResult GetHocLuc(int id)
        {
            HocLuc hocLuc = db.HocLucs.Find(id);
            if (hocLuc == null)
            {
                return NotFound();
            }

            return Ok(hocLuc);
        }

        // PUT: api/HocLucs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHocLuc(int id, HocLuc hocLuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hocLuc.ID)
            {
                return BadRequest();
            }

            db.Entry(hocLuc).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HocLucExists(id))
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

        // POST: api/HocLucs
        [ResponseType(typeof(HocLuc))]
        public IHttpActionResult PostHocLuc(HocLuc hocLuc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HocLucs.Add(hocLuc);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hocLuc.ID }, hocLuc);
        }

        // DELETE: api/HocLucs/5
        [ResponseType(typeof(HocLuc))]
        public IHttpActionResult DeleteHocLuc(int id)
        {
            HocLuc hocLuc = db.HocLucs.Find(id);
            if (hocLuc == null)
            {
                return NotFound();
            }

            db.HocLucs.Remove(hocLuc);
            db.SaveChanges();

            return Ok(hocLuc);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HocLucExists(int id)
        {
            return db.HocLucs.Count(e => e.ID == id) > 0;
        }
    }
}