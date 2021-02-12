using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
   public class ColorManager : IColorService
    {
        IColorDal _icolorDal;

        public ColorManager(IColorDal icolorDal)
        {
            _icolorDal = icolorDal;
        }

        public void Add(Color renk)
        {
            _icolorDal.Add(renk);
        }

        public void Delete(Color renk)
        {
            _icolorDal.Delete(renk);
        }

        public IDataResult <List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_icolorDal.GetAll());
        }

        public void Update(Color renk)
        {
            throw new NotImplementedException();
        }
    }
}
