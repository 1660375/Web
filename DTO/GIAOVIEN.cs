using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Giaovien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string MAGV { get; set; }
        public string HOTEN { get; set; }
      
    }
}
