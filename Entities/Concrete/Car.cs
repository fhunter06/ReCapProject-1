﻿using Core.Entities;
// using Entities.Abstract; sildik
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car :IEntity //public ve inherit
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Descriptions { get; set; }
    }
}
