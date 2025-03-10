﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class RentCarDto :IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }


        public int Duration { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
