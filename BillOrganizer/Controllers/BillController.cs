using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillOrganizer.Models.ViewModels;
using BillOrganizer.Models;
using BillOrganizer.Repositories;

namespace BillOrganizer.Controllers
{
    public class BillController : Controller
    {
        
        BillService service = new BillService(new EFUnitOfWork());       

        // GET: Bill
        public ActionResult Create()
        {
           
            Session["data"] = service.Lookup().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(BillViewModels models)
        {
            service.Add(models);
            Session["data"] = service.Lookup().ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "這是記帳程式";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData.Add("Name", "jLin");
            ViewData.Add("Tel", "12345678");

            return View();
        }
    }
}