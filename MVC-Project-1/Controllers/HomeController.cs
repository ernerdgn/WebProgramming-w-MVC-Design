using Microsoft.AspNetCore.Mvc;
using MVC_Project_1.Models;

namespace MVC_Project_1.Controllers
{
    /* hostAddress/controller/action
    example: localhost/Home/Index  */
    public class HomeController : Controller
    {
        public IActionResult Index()  //action (method)
        {
            MessageModel messageModel = new MessageModel();
            messageModel.MessageId = 1;
            messageModel.Message = "I like apples.";

            return View(messageModel);  //view page (result page)
        }

        public IActionResult About()
        {
            MessageModel messageModel = new MessageModel();
            messageModel.MessageId = 2;
            messageModel.Message = "Do not go gentle into that good night. Rage, rage, against the dying of the light.";

            return View(messageModel);  //view page (result page)
        }
    }
}
