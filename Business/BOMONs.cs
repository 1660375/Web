using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using ConsoleApp1;
using DTO;
namespace Business
{
    public class BOMONs : IDisposable
    {
        public QLDTEntities db = new QLDTEntities();
        public IEnumerable<Bomon> LoadBomon()
        {
            var a = db.BOMONs
                .Select(x => new { x.MABM, x.TENBM, x.PHONG, x.DIENTHOAI, x.TRUONGBM, x.MAKHOA, x.NGAYNHANCHUC })
                .AsEnumerable()
                .Select(s => new Bomon { MABM = s.MABM, TENBM = s.TENBM, PHONG = s.PHONG, DIENTHOAI = s.DIENTHOAI, TRUONGBM = s.TRUONGBM, MAKHOA = s.MAKHOA, NGAYNHANCHUC = s.NGAYNHANCHUC });

            return a;
        }
        public IEnumerable<Bomon> LoadBomonByMABM(string MABM)
        {

            var Bomon = db.BOMONs.Where(p => p.MABM == MABM)
                .Select(x => new { x.MABM, x.TENBM, x.PHONG, x.DIENTHOAI, x.TRUONGBM, x.MAKHOA, x.NGAYNHANCHUC })
                .AsEnumerable()
                .Select(s => new Bomon { MABM = s.MABM, TENBM = s.TENBM, PHONG = s.PHONG, DIENTHOAI = s.DIENTHOAI, TRUONGBM = s.TRUONGBM, MAKHOA = s.MAKHOA, NGAYNHANCHUC = s.NGAYNHANCHUC });
            return Bomon;

        }


        private bool BomonExists(string id)
        {

            return db.BOMONs.Count(e => e.MABM == id) > 0;
        }

        public IEnumerable<Bomon> EditBomon(IEnumerable<Bomon> Bomon)
        {
            var temp = Bomon.First();
            BOMON Bomon1 = new BOMON()
            {
                MABM = temp.MABM,
                TENBM=temp.TENBM,
                MAKHOA=temp.MAKHOA,
                NGAYNHANCHUC= temp.NGAYNHANCHUC,
                PHONG= temp.PHONG,
                TRUONGBM= temp.TRUONGBM
            };
            db.Entry(Bomon1).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!BomonExists(Bomon1.MABM))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return Bomon;

        }


        public IEnumerable<Bomon> PostBomon(IEnumerable<Bomon> Bomon)
        {
            var temp = Bomon.First();
            BOMON Bomon1 = new BOMON()
            {
                MABM = temp.MABM,
                TENBM = temp.TENBM,
                MAKHOA = temp.MAKHOA,
                NGAYNHANCHUC = temp.NGAYNHANCHUC,
                PHONG = temp.PHONG,
                TRUONGBM = temp.TRUONGBM
            };
            db.BOMONs.Add(Bomon1);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (BomonExists(Bomon1.MABM))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Bomon;
        }

        private IEnumerable<Bomon> Conflict()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bomon> DeleteBomon(IEnumerable<Bomon> Bomon)
        {

            foreach (var Bomons in Bomon)
            {
                BOMON temp = db.BOMONs.Find(Bomons.MABM);
                if (temp == null)
                {
                    continue;
                }
                else
                {
                    db.BOMONs.Remove(temp);
                }
            }
            db.SaveChanges();
            return Bomon;
        }

        public void Dispose()
        {
            using (QLDTEntities db = new QLDTEntities())
            {
                db.Dispose();
                ((IDisposable)db).Dispose();
            }
        }


    }

    //private bool BomonExists(string id)
    //{
    //    return db.BOMONs.Count(e => e.MABM == id) > 0;
    //}
}
