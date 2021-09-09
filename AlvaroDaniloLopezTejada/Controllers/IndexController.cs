using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlvaroDaniloLopezTejada.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        //[HttpPost]
        public ActionResult Index()
        {

            //if ()
            //{


            //    return Redirect("/Index/Aprobado");
            //}
            //else
            //{

            //    return Redirect("/Index/Error");
            //}
            return View();
        }



        public ActionResult Aporbado()
        {

            return View();
        }

        public ActionResult Error()
        {


            return View();
        }
    }

}