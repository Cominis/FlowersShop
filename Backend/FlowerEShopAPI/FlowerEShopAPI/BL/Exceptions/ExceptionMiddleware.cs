using FlowerEShopAPI.BL.Models;
using System.Net;

namespace FlowerEShopAPI.BL.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            if (exception.GetType().IsAssignableFrom(typeof(ArgumentException)))
            {
                return context.Response.WriteAsync(new ErrorDetails()
                {
                    Error = new ApiError()
                    {
                        StatusCode = context.Response.StatusCode = 400,
                        Message = exception.Message
                    }
                }.ToString());
            }
            else
            {
                return context.Response.WriteAsync(new ErrorDetails()
                {
                    Error = new ApiError()
                    {
                        StatusCode = context.Response.StatusCode,
                        Message = "Internal Server Error"
                    }
                }.ToString());
            }
        }
    }
}
