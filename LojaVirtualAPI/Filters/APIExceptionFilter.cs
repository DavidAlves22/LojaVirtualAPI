using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LojaVirtualAPI.Filters
{
    public class APIExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<APIExceptionFilter> _logger;
        public APIExceptionFilter(ILogger<APIExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {      
            _logger.LogError(context.Exception, "Ocorreu uma exceção.");

            context.Result = new ObjectResult(new
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Message = context.Exception.Message,
                Detail = context.Exception.InnerException?.ToString()
            });
        }
    }
}
