﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class CarDto : IDto
    {

        public int CarID { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
