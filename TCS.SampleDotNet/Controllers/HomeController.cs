using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace TCS.SampleDotNet.Controllers
{
    public class HomeController : Controller
    {

       


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "THIS IS A SAMPLE DOTNET CORE APP DEPLOYED via AWS CODEPIPELINE";
            


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}