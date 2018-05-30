using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FluentValidationFilter
{
    public class FluentValidationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid)
                return;

            context.Result = new BadRequestObjectResult(
                        context.ModelState.Select(x => 
                        new {
                            x.Key,
                           Value = x.Value
                           .Errors
                           .Select(y => y.ErrorMessage)
                        }
                    )
                );
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
