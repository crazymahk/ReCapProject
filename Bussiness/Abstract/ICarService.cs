using Entities;
using Entities.Concrete;
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
        List<CarDto> GetCarsDdetails();

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        
    }
}
