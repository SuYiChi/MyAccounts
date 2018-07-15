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
        private IEnumerable<MoneyViewModel> GetMoneyReport()
        {
            for (var i = 0; i < 50; i++)
            {
                yield return new MoneyViewModel()
                {
                    Category = i % 2 == 0 ? Balance.Expend : Balance.Income,
                    Date = DateTime.Today.AddDays(-i),
                    Amount = i * 50 + 10
                };
            }
        }
    }
}