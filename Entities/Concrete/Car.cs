﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Car : IEntity
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public DateTime ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
       

    }
}
