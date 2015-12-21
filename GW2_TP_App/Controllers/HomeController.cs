using GW2_TP_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GW2_TP_App.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //dataService.SaveAll();
            var model = new BoughtItemsVM(); 
            model.boughtItems =  dataService.GetAll(); 
            return View(model);
        }

       


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}