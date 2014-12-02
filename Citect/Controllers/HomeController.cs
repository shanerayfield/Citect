using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Citect.Domain.DataAccess;
using Citect.Domain.Entities;
using Citect.Models;



namespace Citect.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            AlarmLog alarmLog = new AlarmLog();
            ViewBag.count = alarmLog.GetLogLen();

            AlarmLogView alarmLogView = new AlarmLogView(alarmLog);

            return View(alarmLogView);
        }
    }
}