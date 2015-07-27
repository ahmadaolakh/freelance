using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/

        public ActionResult signin()
        {
            return View();
        }
        public ActionResult home()
        {
            return View();
        }

    }
}
