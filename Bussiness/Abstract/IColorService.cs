using Core.Utilities.Result;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
  public  interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        void Add(Color renk);
        void Delete(Color renk);
        void Update(Color renk);
    }
}
