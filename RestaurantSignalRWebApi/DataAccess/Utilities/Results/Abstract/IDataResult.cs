using DataAccess.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Utilities.Results.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; }

    }
}
