using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using DTO;
namespace Business
{
    public class KHOAs:IDisposable
    {
        public QLDTEntities db = new QLDTEntities();
        public IEnumerable<Khoa> LoadBomon()
        {
            var a = db.KHOAs
                .Select(x => new { x.MAKHOA,x.TENKHOA })
                .AsEnumerable()
                .Select(s => new Khoa { MAKHOA= s.MAKHOA, TENKHOA= s.TENKHOA });
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
