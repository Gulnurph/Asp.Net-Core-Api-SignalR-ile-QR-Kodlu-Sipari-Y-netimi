using DataAccess.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }

        public string? Message { get; }

        public Exception Exception { get; }

    }
}
