using BigonApp2.Models;
using BigonApp2.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace BigonApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _db;
        public HomeController(DataContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Subscribe(string Email)
        {
          bool IsEmail=  Regex.IsMatch(Email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!IsEmail)
            {
                return Json(new
                {
                    error = true,
                    message = "Please enter correct mail adress"
                });
            }


            var subscriber=_db.Subscribers.FirstOrDefault(s => s.EmailAdress == Email);
            if (subscriber != null && !subscriber.IsApproved)
            {
                return Json(new
                {
                    error = false,
                    message = $"Bu {Email}-e link gonderilmishdir,Zehmet olmasa tesdiq edin"
                });
            }

            if (subscriber != null && subscriber.IsApproved)
            {
                return Json(new
                {
                    error = false,
                    message = $"Bu {Email} tesdiq olunmushdur"
                });
            }

            var newSubscriber = new Subscriber
            { 
            CreatedAt = DateTime.Now,
            EmailAdress = Email 
            };
            _db.Subscribers.Add(newSubscriber);
            _db.SaveChanges();




            return Ok(new
            {
                succes = true,
                message=$"Link sent to this {Email} please aprrove"
            });
        }
    }
}
