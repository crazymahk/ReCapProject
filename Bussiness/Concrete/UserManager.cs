using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult("Kullanıcı Eklendi");
            // return new ErrorResult("Kullanıcı Eklenemedi");
        }

        public IResult Delete(User user)
        {
            string tempuser = user.FirstName;
            if (user.Id != 0)
            {

                _userDal.Delete(user);

                return new SuccessResult(tempuser + " kullanıcısı Başarılı İle silindi");
            }
            return new ErrorResult(tempuser + "Kulanıcıs Silinemedi");

        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), "bütün kullanıclar listelendi");
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult("Güncellendi");
        }
    }
}
