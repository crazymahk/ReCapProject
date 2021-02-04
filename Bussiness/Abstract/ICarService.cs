using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int brandid);

        List<Car> GetCarsByColorId(int colorid);

    }
}
