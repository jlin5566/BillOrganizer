using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BillOrganizer.Models.ViewModels;

namespace BillOrganizer.Controllers
{
    public class BillController : Controller
    {
        List<BillViewModels> dataList = new List<BillViewModels>();

        // GET: Bill
        public ActionResult Create()
        {
            dataList.Add(new BillViewModels() { ID = 1, Type = "支出", CreateDate = DateTime.Now, Money = 300, Remark = "吃飯" });
            dataList.Add(new BillViewModels() { ID = 2, Type = "支出", CreateDate = DateTime.Now, Money = 250, Remark = "看電影" });
            dataList.Add(new BillViewModels() { ID = 3, Type = "支出", CreateDate = DateTime.Now, Money = 1000, Remark = "坐車" });
            Session["data"] = dataList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(BillViewModels models)
        {
            dataList = (List<BillViewModels>)Session["data"];
            dataList.Add(new BillViewModels()
            {
                ID = dataList.Count+1,
                Type = models.Type,
                CreateDate = models.CreateDate,
                Money = models.Money,
                Remark = models.Remark
            });
            Session["data"] = dataList;
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