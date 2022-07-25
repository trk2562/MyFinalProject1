using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Birkaç farklı constraction yapısı örneklendiriyoruz.
    public class SuccessDataResult<T> : DataResult<T> 
    {
        //Base'in anlamı bu datası data'dır, işlem sonucu true'dur, mesajı message'dır.
        public SuccessDataResult(T data, string message) : base(data,true,message)
        {

        }
        public SuccessDataResult(T data) : base(data,true)
        {

        }

        //Burdaki base; bişi döndürmek istemiyor yani default, işlem sonucu true, mesajı message'dir.
        public SuccessDataResult(string message) : base(default,true,message)
        {

        }
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
