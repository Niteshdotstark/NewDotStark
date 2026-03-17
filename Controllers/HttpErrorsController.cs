using Microsoft.AspNetCore.Mvc;

namespace DotStark.Controllers
{
    public class HttpErrorsController : Controller
    {
        public IActionResult Error(int code)
        {
            return code switch
            {
                404 => View("NotFound"),
                _ => View("Error")
            };
        }
    }
}
