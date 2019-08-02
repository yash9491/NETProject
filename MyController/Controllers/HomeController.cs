using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBusinessDomain.BusinessDomain;
using MyModels.Model;

namespace MyController.Controllers
{
   
    public class HomeController : Controller
    {
        public IDisplayEmployee _displayemployee;
        public HomeController()
        {

        }
        public HomeController(IDisplayEmployee displayEmployee)
        {
            this._displayemployee = displayEmployee;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "My Home Page";
            return View();
        }

        [HttpGet]
        [ActionName("GetEmployees")]
        public ActionResult GetEmployees()
        {
          
            List<EmployeeDetails> empdata = this._displayemployee.ShowEmployeeDetails();
            return View(empdata);

        }

        public JsonResult GetEmployeeDetails(int i, string j)
        {
            IDisplayEmployee ds = new DisplayEmployee();
            return Json(this._displayemployee.ShowEmployeeDetails(), JsonRequestBehavior.AllowGet);

        }
    }
}
