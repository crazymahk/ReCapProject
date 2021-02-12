using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class SuccessDataResult<t> : DataResult<t>
    {
        public SuccessDataResult(t data, string message) : base(data,true, message)
        {

        }
        public SuccessDataResult(t data):base(data,true)
        {

        }
        public SuccessDataResult(string message):base(default,true)
        {

        }
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
