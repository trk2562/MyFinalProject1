using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Aspect
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değildir.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); //Alınacak validatorü newle(örneğin ProductValidator-Activator direkt newliyor-)
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //Add methodunda birden fazla tip olabilirdi hangi tip olacağını buradan seçiyor(Burada Product).Tipinin ne olduğunu yakala
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); //eğerki tip product tipindeyse foreach'in içini uygula.
            foreach (var entity in entities)//Birden fazla argüman olabileceğinden örn, productaki add'in argümanlarını geziyor.
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
