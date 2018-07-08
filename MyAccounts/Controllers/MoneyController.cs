using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAccounts.Enum;
using MyAccounts.Models.ViewModel;

namespace MyAccounts.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult MoneyReport()
        {
            var model = GetMoneyReport();
            return View(model);
        }

        /// <summary>
        /// 取得資料（目前為寫死假資料，以後要串資料庫資料改這邊就好）
        /// </summary>
        /// <param name="model"></param>
        private List<MoneyViewModel> GetMoneyReport()
        {
            var model = new List<MoneyViewModel>();
            for (var i = 0; i < 50; i++)
            {
                var fake = new MoneyViewModel
                {
                    Category = i % 2 == 0 ? Balance.支出 : Balance.收入,
                    Date = DateTime.Today.AddDays(-i),
                    Amount = i * 50 + 10
                };
                model.Add(fake);
            }

            return model;
        }
    }
}