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
    public class BOMONsController : ApiController
    {
        [HttpGet]
        [Route("api/BOMONs")]
        // GET: api/BOMONs
        public IHttpActionResult GetBOMONs()
        {
            using (BOMONs bs = new BOMONs())
            {
                var bOMON = bs.LoadBomon();
                if (bOMON == null)
                {
                    return NotFound();
                }
                return Ok(bOMON);
            }

        }


        // GET: api/BOMONs/5
        public IHttpActionResult GetBOMON(string id)
        {
            using (BOMONs bs = new BOMONs())
            {
                var bOMON = bs.LoadBomonByMABM(id);
                if (bOMON == null)
                {
                    return NotFound();
                }
                return Ok(bOMON);
            }
        }
        [ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/BOMONs/put")]
        public IHttpActionResult PutBOMON([FromBody]IEnumerable<Bomon> bOMON)
        {
            using (BOMONs bs = new BOMONs())
            {
                //  BOMON bOMONs = bOMON.First();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var edit = bs.EditBomon(bOMON);
                return StatusCode(HttpStatusCode.NoContent);
            }

        }
        [HttpPost]
        // POST: api/BOMONs
        [ResponseType(typeof(Bomon))]
        [Route("api/BOMONs/post")]

        public IHttpActionResult PostBOMON([FromBody]IEnumerable<Bomon> bOMON)
        {

            using (BOMONs bs = new BOMONs())
            {
                //  BOMON bOMONs = bOMON.First();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var edit = bs.PostBomon(bOMON);
                return StatusCode(HttpStatusCode.NoContent);
            }

            Bomon bOMONs = bOMON.First();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           

            return CreatedAtRoute("DefaultApi", new { id = bOMONs.MABM }, bOMON);
        }

        // DELETE: api/BOMONs/5
        [ResponseType(typeof(Bomon))]
        [HttpDelete]
        [Route("api/BOMONs/delete")]
        public IHttpActionResult DeleteBOMON([FromBody]IEnumerable<Bomon> bOMON)
        {
            using (BOMONs bs=new BOMONs())
            {
                if (bOMON == null)
                {
                    return NotFound();
                }

                bs.DeleteBomon(bOMON);

                return Ok();
            }
                
        }

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

        //private bool BOMONExists(string id)
        //{
        //    return db.BOMONs.Count(e => e.MABM == id) > 0;
        //}
    }
}