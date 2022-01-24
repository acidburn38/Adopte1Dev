using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1Dev.BLL.Entities
{
    class Client
    {
        public int IdClient { get; set; }

        public string CliName { get; set; }

        public string CliFirstName { get; set; }

        public string CliMail { get; set; }

        public string CliCompany { get; set; }

        public string? CliLogin { get; set; }

        public string? CliPassword { get; set; }

    }
}
