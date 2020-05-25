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
    public class XepLoaisController : ApiController
    {
        private TestEntities db = new TestEntities();

        // GET: api/XepLoais
        public IQueryable<XepLoai> GetXepLoais()
        {
            return db.XepLoais;
        }

        // GET: api/XepLoais/5
        [ResponseType(typeof(XepLoai))]
        public IHttpActionResult GetXepLoai(int id)
        {
            XepLoai xepLoai = db.XepLoais.Find(id);
            if (xepLoai == null)
            {
                return NotFound();
            }

            return Ok(xepLoai);
        }

        // PUT: api/XepLoais/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutXepLoai(int id, XepLoai xepLoai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != xepLoai.ID)
            {
                return BadRequest();
            }

            db.Entry(xepLoai).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!XepLoaiExists(id))
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

        // POST: api/XepLoais
        [ResponseType(typeof(XepLoai))]
        public IHttpActionResult PostXepLoai(XepLoai xepLoai)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.XepLoais.Add(xepLoai);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = xepLoai.ID }, xepLoai);
        }

        // DELETE: api/XepLoais/5
        [ResponseType(typeof(XepLoai))]
        public IHttpActionResult DeleteXepLoai(int id)
        {
            XepLoai xepLoai = db.XepLoais.Find(id);
            if (xepLoai == null)
            {
                return NotFound();
            }

            db.XepLoais.Remove(xepLoai);
            db.SaveChanges();

            return Ok(xepLoai);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool XepLoaiExists(int id)
        {
            return db.XepLoais.Count(e => e.ID == id) > 0;
        }
    }
}