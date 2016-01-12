using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThaiNationalIDCard;
using WebThaiNationalIDCard.Models;

namespace WebThaiNationalIDCard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult IDCard()
        {
            return View();
        }

        public ActionResult test()
        {
            return View();
        }

        public ActionResult Read()
        {
            Person person = new Person()
            {
                id = "11",Birthday = "10/10/2000",Sex="M",
                Th_Prefix = "Mr.", Th_Firstname = "Test", Th_Lastname = "test"
            };
            ThaiIDCard idcard = new ThaiIDCard();
            Personal personal = idcard.readAll();
            return RedirectToAction("Test", "Home");
            if (personal != null)
            {
                person.id = personal.Citizenid;
                person.Birthday = personal.Birthday.ToString("dd/MM/yyyy");
                person.Sex = personal.Sex;
                person.Th_Prefix = personal.Th_Prefix;
                person.Th_Firstname = personal.Th_Firstname;
                person.Th_Lastname = personal.Th_Lastname;
            }
            else
            {

            }
            return View("Test", person);
        }
    }
}