using CrmSalesProject.IRepositories;
using CrmSalesProject.Models;
using CrmSalesProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrmSalesProject.Controllers
{
    public class HomeController : Controller
    {
        CrmSalesProjectRepository db =  new CrmSalesProjectRepository();

        // GET: Home
        public ActionResult Index()
        {
            var accounts = db.GetAllAccounts();
            return View(accounts);
        }
    }
}