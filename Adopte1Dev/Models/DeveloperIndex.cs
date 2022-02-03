using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopte1Dev.ASP.Models
{
    public class DeveloperIndex
    {
        public IEnumerable<DeveloperListItem> Developer { get; set; }

        public IEnumerable<CategoriesDetails> Categories { get; set; }

    }
}
