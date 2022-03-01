using FluentValidation;
using System;
using System.Linq;

namespace NorthwindBusiness.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var result = validator.Validate(new ValidationContext<object>(entity));

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}
