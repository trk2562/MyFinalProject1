using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Result'ın constractor'ları olduğundan onları ctor ile implemente ederiz
    public class DataResult<T> : Result, IDataResult<T>
    {
        // Kodları tekrar yazmak istemeyeceğimizden base'e success ve message'ı yolladık.
        public DataResult(T data,bool success, string message) : base(success,message)
        {
            Data = data;
        }
        //Message'ı yollamak istemeyebilirdik;
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
