using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1Dev.BLL.Entities
{
    public class ClientEndorseDev
    {
        public int IdClient { get; set; }

        public int IdDev { get; set; }

        public DateTime Begindate { get; set; }

        public DateTime EndDate { get; set; }

        public int EndorseNumber { get; set; }
    }
}
