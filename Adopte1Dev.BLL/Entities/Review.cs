﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopte1Dev.BLL.Entities
{
    class Review
    {
        public int IdReview { get; set; }

        public string ReviewName { get; set; }

        public string ReviewText { get; set; }

        public string ReviewMail { get; set; }

        public DateTime ReviewDate { get; set; }

        public int IdDev { get; set; }

    }
}
