using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MAKHOA { get; set; }
        public string TENKHOA { get; set; }
       
    }
}
