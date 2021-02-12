using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class ErrorDataResult<t> : DataResult<t>
    {
        public ErrorDataResult(t data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(t data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
