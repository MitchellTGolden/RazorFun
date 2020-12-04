using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class RazorController : Controller
    {

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View();
        }
        //for each route this controller is to handle:
    }
}
