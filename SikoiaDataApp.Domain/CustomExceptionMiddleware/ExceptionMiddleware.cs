using Microsoft.AspNetCore.Http;
using SikoiaDataApp.Domain.Models;
using System.Web.Http;

namespace SikoiaDataApp.Domain.Extensions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (HttpResponseException ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, HttpResponseException ex)
        {
            context.Response.StatusCode = (int)ex.Response.StatusCode;

            await context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = (int)ex.Response.StatusCode,
                Message = ex.Response.ReasonPhrase
            }.ToString());
        }
    }
}
