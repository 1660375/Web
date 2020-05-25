using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using DTO;
namespace Business
{
    public class GIAOVIENs: IDisposable
    {
        private QLDTEntities db = new QLDTEntities();
     
        public IEnumerable<Giaovien> LoadTeacher()
        {
            var a = db.GIAOVIENs
               .Select(x => new { x.MAGV, x.HOTEN })
               .AsEnumerable()
               .Select(s => new Giaovien { MAGV = s.MAGV, HOTEN = s.HOTEN });

            return a;
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
}
