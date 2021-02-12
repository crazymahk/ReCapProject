using Core.Utilities.Result;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int brandid);

        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        IDataResult<List<CarDto>> GetCarsDdetails();

        IResult Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        
    }
}
