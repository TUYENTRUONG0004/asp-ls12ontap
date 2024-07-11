using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tdt_lession12ontap.Controllers
{
    public class TdtHomeController : Controller
    {
        public ActionResult TdtIndex()
        {
            return View();
        }

        public ActionResult TdtAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();

        }

        public ActionResult TdtContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}