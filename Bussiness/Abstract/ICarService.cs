using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
  public  interface ICarService
    {
        List<Car> GetAll();
    }
}
