using Core;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
   public class EFBrand : EfEntityRepositoryBase<Brand, yilmazContext>, IBrandDal
    {
    }
}
