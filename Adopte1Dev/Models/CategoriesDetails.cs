using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adopte1Dev.ASP.Models
{
    public class CategoriesDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdCategory { get; set; }
        public string CategLabel { get; set; }
        
    }
}
