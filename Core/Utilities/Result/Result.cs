using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public bool success { get; }

        public string Messages { get; }

        public Result(bool succes, string Message):this(succes)
        {
            Messages = Message;
        }
        public Result(bool succes)
        {
            success = succes;
        }
    }
}
