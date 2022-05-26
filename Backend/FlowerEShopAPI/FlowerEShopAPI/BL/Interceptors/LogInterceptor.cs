using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FlowerEShopAPI.BL
{

    public class LogInterceptor : IAsyncActionFilter
    {
        private readonly ILogsService _logsService;
        public IConfiguration _configuration;

        public LogInterceptor(ILogsService logsService, IConfiguration config)
        {
            _logsService = logsService;
            _configuration = config;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var logsEnabled = bool.Parse(_configuration["Logging:EnableLogging"]);
            if (!logsEnabled)
            {
                var user = (User)context.HttpContext.Items["User"];
                var actionDescriptor = (ControllerActionDescriptor)context.ActionDescriptor;
                var controllerName = actionDescriptor.ControllerTypeInfo;
                var actionName = actionDescriptor.ActionName;
                await _logsService.LogAction(user?.UserName ?? "Guest", controllerName.ToString(), actionName, "ACTION STARTED");
                await next();
                await _logsService.LogAction(user?.UserName ?? "Guest", controllerName.ToString(), actionName, "ACTION FINISHED");

            }
        }
    }
}
