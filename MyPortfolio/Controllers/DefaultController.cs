using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = true;
            context.Messages.Add(message);
            context.SaveChanges();
            return View();
        }
    }
}
