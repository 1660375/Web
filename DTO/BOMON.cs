using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bomon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MABM { get; set; }
        public string TENBM { get; set; }
        public string PHONG { get; set; }
        public string DIENTHOAI { get; set; }
        public string TRUONGBM { get; set; }
        public string MAKHOA { get; set; }
        public Nullable<System.DateTime> NGAYNHANCHUC { get; set; }
    }
}
