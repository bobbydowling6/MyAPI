using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAPI.Controllers
{
    public class SomePathController : Controller
    {
        public ActionResult Index()
            
            {

                return Content("You've reached a customed path");
            }
     }
 }

