using Microsoft.AspNetCore.Mvc;
using MVC_Project_1.Models;

namespace MVC_Project_1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()  //IActionResult returns html
        {
            ViewBag.NameSurname = "Eren ERDOĞAN";

            var info = new MessageModel
            {
                MessageId = 2,
                Message = "This is model data"
            };

            return View(info);
        }


        //we can return any kind of data from server to client
        public string WhoAreYou()
        {
            return "My name is Eren!";
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }

            return sum;
        }

        public JsonResult GetMessages()  //one of the benefits of json type data, you can add extra data to return statement
        {
            List<MessageModel> messages = new List<MessageModel>();

            messages.Add(new MessageModel() { MessageId = 3, Message = "m3" });
            messages.Add(new MessageModel() { MessageId = 4, Message = "m4" });
            messages.Add(new MessageModel() { MessageId = 5, Message = "m5" });
            messages.Add(new MessageModel() { MessageId = 6, Message = "m6" });


            return Json(messages);
        }
    }
}
