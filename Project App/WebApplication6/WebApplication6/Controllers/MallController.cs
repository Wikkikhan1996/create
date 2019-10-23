using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class MallController : Controller
    {
        // GET: Mall
        public ActionResult Index()
        {
            return View();
        }
    }
}