﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementProblems
{
    public class DataTable
    {
        public int ProductId {get;set;}
        public int UserId { get;set;}
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

    }
}
