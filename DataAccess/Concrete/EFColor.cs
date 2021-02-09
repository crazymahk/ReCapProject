using Core;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFColor : EfEntityRepositoryBase<Color,yilmazContext>,IColorDal
    {
    }
}
