using Microsoft.AspNetCore.Mvc.Filters;
using PatientsApp.Server.Extensions;
using PatientsApp.Server.Interfaces;

namespace PatientsApp.Server.Helpers
{
    public class LogUserActivity
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;

            var userId = resultContext.HttpContext.User.GetUserId();
            var repo = resultContext.HttpContext.RequestServices.GetService<IUserRepository>();
            var user = await repo.GetUserByIdAsync(userId);
            user.LastActive = DateTime.UtcNow;
            await repo.SaveAllAsync();
        }
    }
}
