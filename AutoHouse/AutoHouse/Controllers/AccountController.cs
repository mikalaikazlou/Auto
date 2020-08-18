using AutoHouse.Filters;
using AutoHouse.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace AutoHouse.Controllers
{
    [ExceptionLoggerAttribut]
    public class AccountController : Controller
    {
        UserContext context = new UserContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (User user)
        {
            if (ModelState.IsValid)
            {
                User userNew = null;
                userNew = context.Users.FirstOrDefault(m => m.Name == user.Name && m.Password == user.Password);
                if (userNew !=null)
                {
                    FormsAuthentication.SetAuthCookie(user.Name, true);
                    return RedirectToAction("AutoHouse", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Логин существует");
                }
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
           
            if (ModelState.IsValid)
            {
                User userNew = null;
                userNew=context.Users.FirstOrDefault(m => m.Name == user.Name&& m.Password==user.Password);
                if (userNew==null)
                {
                    context.Users.Add(new User
                    {
                        Name = user.Name,
                        Password = user.Password
                    });
                    context.SaveChanges();
                    userNew = context.Users.Where(m => m.Name == user.Name && m.Password == user.Password).FirstOrDefault();
                    if (userNew!=null)
                    {
                        FormsAuthentication.SetAuthCookie(user.Name, true);
                        return RedirectToAction("AutoHouse", "Home");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Логин существует");
            }
            return View(user);
        }
    }
}