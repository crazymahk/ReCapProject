using Core;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFRentedCars : EfEntityRepositoryBase<RentedCars, yilmazContext>, IRentedCar
    {
        public List<RentCarDto> GetRentalDetails(Expression<Func<RentedCars, bool>> filter = null)
        {

            using (yilmazContext context = new yilmazContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Car
                             on re.CarId equals ca.CarID
                             join cus in context.Customer
                             on re.CustomerId equals cus.CustomerId
                             join us in context.User
                             on cus.UserId equals us.Id
                             select new RentCarDto
                             {
                                 Id = re.CarId,
                                 CarName = ca.CarName,
                                 CustomerName = cus.CompanyName,
                                 CarId = ca.CarID,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName
                             };

                return result.ToList();

            }



        }
    }
}