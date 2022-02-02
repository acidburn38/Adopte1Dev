using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adopte1Dev.ASP.Models
{
    public class DeveloperDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int IdDev { get; set; }
        public string DevName { get; set; }
        public string DevFirstName { get; set; }
        public DateTime DevBirthDate { get; set; }
        public string DevPicture { get; set; }
        public double DevHourCost { get; set; }
        public double DevDayCost { get; set; }
        public double DevMonthCost { get; set; }
        public string DevMail { get; set; }
        public int? DevCategPrincipal { get; set; }
        public CategoriesDetails CatePrincipal { get; set; }
        public string CategPrincipalName { get { return this.CatePrincipal?.CategLabel; } }
    }
}
