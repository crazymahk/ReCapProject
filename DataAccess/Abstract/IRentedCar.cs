using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface IRentedCar : IEntityRepository<RentedCars>
    {

        List<RentCarDto> GetRentalDetails(Expression<Func<RentedCars, bool>> filter = null);
    }
}
