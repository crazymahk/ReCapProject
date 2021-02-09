using Core;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFCarDal : EfEntityRepositoryBase<Car, yilmazContext>, ICarDal
    {
        public List<CarDto> GetCarDetailDtos()
        {
            using (yilmazContext Context = new yilmazContext())
            {
                var result = from ca in Context.Car
                             join co in Context.Brand on ca.BrandID equals co.BrandID join cosl in Context.Color on ca.ColorID equals cosl.ColorID
                             select new CarDto {CarID =ca.CarID ,CarName= ca.CarName,BrandName=co.BrandName,ColorName=cosl.ColorName,DailyPrice=ca.DailyPrice   };

                return result.ToList();
            }
        }

 
    }
}
