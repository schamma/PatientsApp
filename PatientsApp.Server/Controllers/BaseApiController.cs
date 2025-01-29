//using PatientsApp.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace PatientsApp.Server.Controllers
{
    //    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("PatientsApp/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}