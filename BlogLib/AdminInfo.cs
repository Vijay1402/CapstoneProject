using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    
    public class AdminInfo
    {
        [Key]
        public int AdminId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
