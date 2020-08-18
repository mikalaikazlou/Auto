using Service;
using System;
using System.Linq;
using AutoHouse.Filters;
using System.Web.Mvc;


namespace AutoHouse.Controllers
{
    [ExceptionLoggerAttribut]
    public class HomeController : Controller
    {
        CarContext context = new CarContext();
        ServiceDb db = new ServiceDb();

        
        public ActionResult AutoHouse()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult ListCar(string car)
        {
            var mm = context.Cars.Where(a => a.Model.Contains(car)).ToList();
            if (car == "BMW")
            {
                throw new Exception("NO!");
            }
            return PartialView(mm);
        }

        [MyAuthAttribut]
        public ActionResult Index()
        {
            ViewBag.Cars = context.Cars;
            //var listCar= db.GetList();
            return View();
        }

        [HttpGet]
        [MyAuthAttribut]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Test()
        {
            var mm = context.Cars;
            
            return PartialView(mm);
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            db.Create(car);
            return View();
        }

        public ActionResult Details(int id)
        {
           
            ViewBag.GetCar = db.Details(id);
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCar (int id)
        {
            Car car = db.Details(id);
            return View(car);
        }
        [HttpPost]
        public ActionResult UpdateCar(Car car)
        {
            db.Update(car);
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       
        public ActionResult Contact()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}