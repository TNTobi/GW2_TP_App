using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GW2_TP_App.Services;

namespace GW2_TP_App.Controllers
{
    public class BaseController : Controller
    {
        protected DataService dataService = new DataService();
    }
}