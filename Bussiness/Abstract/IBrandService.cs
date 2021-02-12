using Core.Utilities.Result;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {

        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand marka);
        IResult Delete(Brand marka);
        void Update(Brand marka);

    }
}
