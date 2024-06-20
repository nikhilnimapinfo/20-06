using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleError.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
         
            
            return View();
           

        }

        public ActionResult About()
        {
            throw new Exception("It a Exception");

        }
    }
}