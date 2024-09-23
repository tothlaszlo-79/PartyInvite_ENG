using Microsoft.AspNetCore.Mvc;
using PartyInvite.Models;
using System.Diagnostics;

namespace PartyInvite.Controllers
{
    public class HomeController : Controller
    {
       public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = 
                hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult InviteForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InviteForm(GuestResponse guestResponse) 
        {
            //todo store response from the guest
            return View();
        }
    }
}
