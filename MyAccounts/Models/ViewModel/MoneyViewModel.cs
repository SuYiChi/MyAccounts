using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyAccounts.Enum;

namespace MyAccounts.Models.ViewModel
{
    public class MoneyViewModel
    {
        [DisplayName("類別")]
        public Balance Category { get; set; }
        [DisplayName("金額")]
        public int Amount { get; set; }
        [DisplayName("日期")]
        public DateTime Date { get; set; }
        [DisplayName("備註")]
        public string Description { get; set; }
    }
}