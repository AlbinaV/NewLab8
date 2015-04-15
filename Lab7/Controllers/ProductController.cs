using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab7.Controllers
{

    public class ProductController : Controller
    {



        //
        // GET: /Product/
        public ActionResult Index()
        {
           // ViewBag.myText = "По коду продукта";

            return View();
        }

        public ActionResult Print()
        {
            ViewBag.myText = "Вывод продукта по коду";
            return View();
        }

        public ActionResult Category()
        {
            ViewBag.myText = " По категории продукта";
            return View();
        }

        public ActionResult Date()
        {
            ViewBag.myText = "По дате";
            return View();
        }
	}
}