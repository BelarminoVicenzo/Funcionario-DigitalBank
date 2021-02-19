using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Funcionario.DataAccess;
using Funcionario.Models;

namespace FuncionarioWeb.Controllers
{
    public class HomeController : Controller
    {

        //EmpresaEntities db = new EmpresaEntities();
        EmpresaContext emp = new EmpresaContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            var es = emp.Estado.ToList().Count;
            
            //ViewBag.Message = "Your application description page.";
            ViewBag.Message =es;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}